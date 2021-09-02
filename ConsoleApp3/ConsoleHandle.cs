using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace ConsoleApp3
{
    class ConsoleHandle
    {
        private const int MF_BYCOMMAND = 0x00000000;
        public const int SC_CLOSE = 0xF060;
        public const int SC_MINIMIZE = 0xF020;
        public const int SC_MAXIMIZE = 0xF030;
        public const int SC_SIZE = 0xF000;

        [DllImport("user32.dll")]
        public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        public static void ConsoleHandleMain()
        {
            IntPtr handle = GetConsoleWindow();
            IntPtr sysMenu = GetSystemMenu(handle, false);
            if (handle != IntPtr.Zero)
            {
                DeleteMenu(sysMenu, ConsoleHandle.SC_MINIMIZE, ConsoleHandle.MF_BYCOMMAND);
                DeleteMenu(sysMenu, ConsoleHandle.SC_MAXIMIZE, ConsoleHandle.MF_BYCOMMAND);
                DeleteMenu(sysMenu, ConsoleHandle.SC_SIZE, ConsoleHandle.MF_BYCOMMAND);
            }
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
        }

        public static void ConsoleHandleTitleBar()
        {
            Thread.CurrentThread.IsBackground = true;
            for (int i = 0; i < 9999999999999999; i++)
            {
                Console.Title = $"Time open : {i} seconds       |  *.*  |       Ham Mafia Lua Downloader v1.0";
                Thread.Sleep(1000);
            }
        }
    }
}
