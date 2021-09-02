using System;
using System.IO;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHandle.ConsoleHandleMain();
            Thread thread1 = new Thread(ConsoleHandle.ConsoleHandleTitleBar);
            thread1.Start();

            string HamLocation = @"C:\kekw\menus";
            if (Directory.Exists(HamLocation))
            {
                Console.WriteLine("Found Ham Mafia folder.");
                Thread.Sleep(500);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Ham Mafia menu folder not found.");
                Thread.Sleep(5000);
                Environment.Exit(69);
            }

            MainMenu.Main_Menu();

            //Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Thread.Sleep(-1);
        }
    }
}
