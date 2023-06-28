using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSAsync
{
    class Chapter4
    {
        public struct Point
        {
            public int Width;
            public int Height;
            public char Character;

            public Point(int width, int height, char character)
            {
                Width = width;
                Height = height;
                Character = character;
            }
        }

        public static void ShowCharacter(int width, int height, char character, object? _lock, int sleepTime=0)
        {
            lock(_lock)
            {
                Console.SetCursorPosition(width, height);
                Console.Write(character);
            }
            Thread.Sleep(sleepTime);
        }
        public static void ShowCharacter(Point point, object? _lock, int sleepTime = 0)
        {
            lock (_lock)
            {
                Console.SetCursorPosition(point.Width, point.Height);
                Console.Write(point.Character);
            }
            Thread.Sleep(sleepTime);
        }

        public static int InterlockedFunc(ref int a, int b, Func<int, int, int> function)
        {
            int prev = a;
            int start;
            int result;

            do
            {
                start = prev;
                result = function(start, b);
                prev = Interlocked.CompareExchange(ref a, result, start);
            } while (start != prev);

            return result;
        }

        //programmers are servers in this case, making computations
        public class ClientServer
        {
            public enum ProgrammerType{Junior, Mid, Senior};

            //max 30 tasks in queue
            public static BlockingCollection<Task> TaskQueue= new BlockingCollection<Task>(30);
            public readonly struct Task
            {
                public readonly int TaskTimeSpan;
                public Task(int time)
                {
                    TaskTimeSpan = time;
                }
            }

            private static void GenerateTasks(CancellationToken cts)
            {
                Random rnd = new Random();
                while(!cts.IsCancellationRequested)
                {
                  TaskQueue.Add(new Task(rnd.Next(200, 3000)));
                }
                TaskQueue.CompleteAdding();
            }

            private static void Program(ProgrammerType programmer)
            {
                while(!TaskQueue.IsCompleted)
                {
                    if (!TaskQueue.TryTake(out var task))
                        continue;
                    var timeNeeded = programmer switch
                    {
                        ProgrammerType.Junior => task.TaskTimeSpan * 2,
                        ProgrammerType.Mid => task.TaskTimeSpan,
                        ProgrammerType.Senior => task.TaskTimeSpan / 2,
                        _=>0
                    };

                    Console.WriteLine($"{programmer}: Time Needed - {timeNeeded}ms");
                    Thread.Sleep(timeNeeded);

                }
            }

            public static void StartServer()
            {
                CancellationTokenSource cts = new CancellationTokenSource();
                var task0=System.Threading.Tasks.Task.Run(() =>
                {
                    while (!cts.IsCancellationRequested)
                    {
                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                            cts.Cancel();
                    }
                }, cts.Token
                );
                Console.WriteLine("Read key ready");

                var task1 = System.Threading.Tasks.Task.Run(() => GenerateTasks(cts.Token));
                Console.WriteLine("Generate tasks ready");
                var task2 = System.Threading.Tasks.Task.Run(() => Program(ProgrammerType.Junior));
                Console.WriteLine("Junior Programmer ready");
                var task3 = System.Threading.Tasks.Task.Run(() => Program(ProgrammerType.Mid));
                Console.WriteLine("Mid programmer ready");
                var task4 = System.Threading.Tasks.Task.Run(() => Program(ProgrammerType.Senior));
                Console.WriteLine("Senior programmer ready");
                while(!cts.IsCancellationRequested)
                {/*this will work till the cancellation with escape key*/}
            }

        }
    }
}
