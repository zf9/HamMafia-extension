using System;
using System.Net;
using System.Threading;

namespace ConsoleApp3
{
    class DownloadHandle
    {
        public static void DownloadLux()
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/882952460572975134/882952516277534740/Lux.lua", @"C:\kekw\menus\Lux.lua");
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n   Downloaded Lux!");
            Thread.Sleep(1000);
            PageHandle.Page1();
        }
        public static void DownloadEulen()
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/882952460572975134/882952998601502730/Eulen1.0.lua", @"C:\kekw\menus\Eulen.lua");
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n   Downloaded Eulen!");
            Thread.Sleep(1000);
            PageHandle.Page1();
        }
        public static void DownloadFallout()
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/882952460572975134/882953021884088390/Fallout.lua", @"C:\kekw\menus\Fallout.lua");
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n   Downloaded Fallout!");
            Thread.Sleep(1000);
            PageHandle.Page1();
        }
        public static void DownloadATG()
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/882952460572975134/882953025067569162/atg.lua", @"C:\kekw\menus\ATG.lua");
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n   Downloaded ATG!");
            Thread.Sleep(1000);
            PageHandle.Page1();
        }
        public static void DownloadMaestro()
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/882952460572975134/882952987465621554/Maestro-Avux.lua", @"C:\kekw\menus\Maestro-Avux.lua");
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n   Downloaded Maestro-Avux!");
            Thread.Sleep(1000);
            PageHandle.Page1();
        }
        public static void DownloadHugeV()
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/882952460572975134/882953028049723393/HugeV.lua", @"C:\kekw\menus\HugeV.lua");
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n   Downloaded HugeV!");
            Thread.Sleep(1000);
            PageHandle.Page1();
        }
        public static void DownloadLynx()
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/882952460572975134/882953021070393374/lynx111.lua", @"C:\kekw\menus\Lynx.lua");
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n   Downloaded Lynx!");
            Thread.Sleep(1000);
            PageHandle.Page1();
        }
        public static void DownloadHamxLynx()
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/882952460572975134/882953021183623198/hamxlynx.lua", @"C:\kekw\menus\HamxLynx.lua");
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n   Downloaded HamxLynx!");
            Thread.Sleep(1000);
            PageHandle.Page1();
        }
        public static void DownloadFiveSenseNertigel()
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/882952460572975134/882953028896976956/FiveSenseNertigel.lua", @"C:\kekw\menus\FiveSenseNertigel.lua");
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n   Downloaded FiveSenseNertigel!");
            Thread.Sleep(1000);
            PageHandle.Page1();
        }
    }
}
