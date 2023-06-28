using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSAsync
{
    class Chapter1
    {
        static ConsoleKey Key = ConsoleKey.A;



        public static void DoWork() => Console.WriteLine("*"+Environment.CurrentManagedThreadId);

        public static void DoWork(CancellationToken token)
        {
            while(!token.IsCancellationRequested)
            {
               Console.WriteLine("*");
                //100 sec
               Thread.Sleep(100000);           
            }
            throw new OperationCanceledException();
        }
        public static void DoWork1(object o) => Console.WriteLine("*");
        public static void DoWork1(object o, int param) => Console.WriteLine(param);

        public struct DoWorkStruct : IThreadPoolWorkItem
        {
            public void Execute() => Console.WriteLine("*");
        };

        /*
         * 
         * 
         * 
         */ 

        public static void ShowMessageThread()
        {
            var t = new Thread(DoWork);
            t.Start();
            t.Join();
        }

        public static void ShowMessageThreadPool()
        {
            ThreadPool.QueueUserWorkItem(DoWork1);
        }

        public static void ShowMessageUnsafeThreadPool()
        {
            ThreadPool.UnsafeQueueUserWorkItem(new DoWorkStruct(), true);
        }

        public static void ShowMessageTask()
        {
            Task.Run(DoWork);
        }

        public static void ShowMessageCancellationToken()
        {
            //works best with funtions that must run in parrallel oterwise it is useless, thats why i created function with loop showing message every 100 secs

            var cts = new CancellationTokenSource();
            Task.Factory.StartNew(_=>DoWork(cts.Token), cts.Token, TaskCreationOptions.AttachedToParent);

            Console.ReadKey();
            cts.Cancel();
        }

        public static void ShowMessageTimer()
        {
            Timer timer = new Timer(DoWork1,null, Timeout.Infinite, Timeout.Infinite);
            timer.Change(0,Timeout.Infinite);
            timer.Dispose();
        }

        private static void DrawLine(string line, CancellationToken token)
        {
            while(!token.IsCancellationRequested)
            {
                 Console.WriteLine(line);
                Thread.Sleep(2000);
            }
        }

        public static void DrawLines()
        {
            var cts = new CancellationTokenSource();

            Task.Run(() => DrawLine("----------", cts.Token), cts.Token);
            Task.Run(() => DrawLine("++++++++++", cts.Token), cts.Token);

            Console.ReadKey();
            cts.Cancel();
        }

        private static void Display(CancellationToken token)
        {
            while(!token.IsCancellationRequested)
            { 
            Console.Write((char)Key);
            Thread.Sleep(100);
            }

            throw new OperationCanceledException();
        }

        public static void CTSUpgraded()
        {
            var cts = new CancellationTokenSource();

            Task.Run(() => Display(cts.Token), cts.Token);

            while ((int)Key is not (int)ConsoleKey.Escape and not (int)ConsoleKey.Enter)
                Key = Console.ReadKey(true).Key;

            //Console.ReadKey();
            cts.Cancel();

        }

    }

    class SafeTimer
    {
#nullable enable
        //callback, state, dueTime, period
        private readonly Timer? timer;

        public SafeTimer(TimerCallback Callback, object? State, int DueTime, int Period)
        {
            timer = new Timer(CallAction, State, Timeout.Infinite, Timeout.Infinite);
            timer.Change(DueTime, Timeout.Infinite);

            void CallAction(object? State)
            {
                Callback(State);
                timer?.Change(Period, Timeout.Infinite);
            }
        }
    }
}
