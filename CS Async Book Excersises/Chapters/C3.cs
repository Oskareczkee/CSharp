using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.CompilerServices;

namespace CSAsync
{
    class Chapter3
    {
        public static async Task NumeroUno()
        {
            async Task<int>MakeRequestAsync()
            {
                Console.WriteLine("MakeRequestAsync is running on thread: " + Environment.CurrentManagedThreadId);
                var task = Task.Run(() => { Console.WriteLine("Task is running on thread: "+ Environment.CurrentManagedThreadId); return 1; });
                var Result = await task;
                return Result;

            }

            Console.WriteLine("NumeroUno method is running on thread: " + Environment.CurrentManagedThreadId);
            var task = MakeRequestAsync();
            var Result = await MakeRequestAsync();
            Console.WriteLine(Result);
        }

        public class AwaiterClass<T>
        {
            public class AwaiterClassAwaiter<T> : INotifyCompletion
            {
                public bool IsCompleted
                {
                    get
                    {
                        Console.WriteLine("Is Completed() in awaiter has been invoked");
                        return false;
                    }
                }
                public void OnCompleted(Action action)
                {
                    Console.WriteLine("Awaiter On Completed has been invoked");
                    action();
                    Console.WriteLine("Awaiter Action has been invoked and done");
                }

                public T GetResult()
                {
                    Console.WriteLine("Awaiter getting Result");
                    return default;
                }

            }
            public AwaiterClassAwaiter<T> GetAwaiter()
            {
                Console.WriteLine("Returned new Awaiter");return new AwaiterClassAwaiter<T>();
            }
        };

    }

    static class Awaiters
    {
        public static TaskAwaiter GetAwaiter(this Int32 timeSpan)
        {
            return Task.Delay(timeSpan).GetAwaiter();
        }
        public static string ReturnDuck(this string text)
        {
            return "Duck";
        }
    }
        
}
