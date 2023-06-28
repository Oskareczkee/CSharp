//old main function, made some cleaning, code is here ready to copy if needed

//Console.WriteLine("Hello World!");

/*
Chapter1.ShowMessageThread();
Chapter1.ShowMessageThreadPool();
Chapter1.ShowMessageUnsafeThreadPool();
Chapter1.ShowMessageTask();
Chapter1.ShowMessageTimer();
Chapter1.ShowMessageCancellationToken();
 */

//Chapter1.DrawLines();

//Chapter1.CTSUpgraded();


//Does not work yet :(
//SafeTimer st = new SafeTimer((object? obj) => Console.Write("*"), null, 1000, 2000);

//RunC2();

//await Chapter3.NumeroUno();

/*
var Task = new Chapter3.AwaiterClass<int>();
var Result = await Task;
await 3000;
Console.WriteLine(Result);
string str=string.Empty;
str=str.ReturnDuck();
Console.WriteLine(str);
 */
//Console.SetCursorPosition(2, 3);
//Console.ReadKey(true);


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace CSAsync
{
#nullable enable
    class Test
    {
        static void WriteLine(object? state)
        {
            Console.WriteLine("*");
        }

        static async void RunC2()
        {

            AsciiArtWriter writer = new AsciiArtWriter();

            await writer.LoadImage(@"P:\Visual Studio Programy\CSAsync\Chapters\Test.txt");
            //writer.DrawLine(0);
            writer.DrawImage();
            //I dont know why DrawImage method does not work, it uses litterally the same syntax

            /*
            Parallel.For(0,100, element =>
            {
                writer.DrawLine(element);
            }
               );
             */ 
        }

        static async Task Main(string[] args)
        {
            /*
            Random rnd = new Random();
            for (int x = 0; x < 10; x++)
                await Task.Run(() =>Chapter4.ShowCharacter(new Chapter4.Point(rnd.Next(0, 10), rnd.Next(0, 10), (char)rnd.Next(97, 122)), new object(), 500));
             */

            await Task.Run(Chapter4.ClientServer.StartServer);

        }
    }
}
