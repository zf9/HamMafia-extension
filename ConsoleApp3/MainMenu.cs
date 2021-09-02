using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp3
{
    class MainMenu
    {
        public static void Main_Menu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("  [ 1 ] --> Page 1");
            Console.WriteLine("  [ 2 ] --> Page 2");
            Console.WriteLine("  [ 3 ] --> Page 3");
            Console.WriteLine("\n  [ 4 ] --> Open Ham Mafia Website");
            Console.WriteLine("  [ 5 ] --> Download Version 1.0 Source");
            Console.Write("\n  [*.*] --> Option : ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            string option = Console.ReadLine();
            if (option == "1")
            {
                PageHandle.Page1();
            }
            else if (option == "2")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("\n   Page 2 release on version 1.1");
                Thread.Sleep(1000);
                MainMenu.Main_Menu();
            }
            else if (option == "3")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("\n   Page 3 release on version 1.2");
                Thread.Sleep(1000);
                MainMenu.Main_Menu();
            }
            else if (option == "4")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Clear();
                Process.Start("https://hammafia.co/");
                Console.WriteLine("\n   Opened hammafia.co");
                Thread.Sleep(1000);
                MainMenu.Main_Menu();
            }
            else if (option == "5")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Process.Start("https://hammafia.co/");
                Console.WriteLine("\n   Redirecting you to github");
                Thread.Sleep(1000);
                MainMenu.Main_Menu();
            }
        }
    }
}
