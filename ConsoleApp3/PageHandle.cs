using System;

namespace ConsoleApp3
{
    class PageHandle
    {
        public static void Page1()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("  [ 1 ] --> Lux.lua");
            Console.WriteLine("  [ 2 ] --> Eulen.lua");
            Console.WriteLine("  [ 3 ] --> Fallout.lua");
            Console.WriteLine("  [ 4 ] --> atg.lua");
            Console.WriteLine("  [ 5 ] --> Maestro-Avux.lua");
            Console.WriteLine("  [ 6 ] --> HugeV.lua");
            Console.WriteLine("  [ 7 ] --> Lynx.lua");
            Console.WriteLine("  [ 8 ] --> HamxLynx.lua");
            Console.WriteLine("  [ 9 ] --> FiveSenseNertigel.lua\n");
            Console.WriteLine("  [ 0 ] --> Exit to main menu");
            Console.Write("\n  [*.*] --> Option : ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            string option = Console.ReadLine();
            if (option == "1")
            {
                DownloadHandle.DownloadLux();
            }
            else if (option == "2")
            {
                DownloadHandle.DownloadEulen();
            }
            else if (option == "3")
            {
                DownloadHandle.DownloadFallout();
            }
            else if (option == "4")
            {
                DownloadHandle.DownloadATG();
            }
            else if (option == "5")
            {
                DownloadHandle.DownloadMaestro();
            }
            else if (option == "6")
            {
                DownloadHandle.DownloadHugeV();
            }
            else if (option == "7")
            {
                DownloadHandle.DownloadLynx();
            }
            else if (option == "8")
            {
                DownloadHandle.DownloadHamxLynx();
            }
            else if (option == "9")
            {
                DownloadHandle.DownloadFiveSenseNertigel();
            }
            else if (option == "0")
            {
                MainMenu.Main_Menu();
            }
        }
    }
}
