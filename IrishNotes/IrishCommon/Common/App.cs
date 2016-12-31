namespace IrishNotes.Common
{
    using System;

    public class App
    {
        public static void SetUpConsole()
        {
            var width = ConsoleInfoConstants.AppWidth;
            var height = ConsoleInfoConstants.AppHeight;

            Console.SetWindowSize(width, height);
            Console.BufferWidth = width;
            Console.BufferHeight = height;
            Console.Title = ConsoleInfoConstants.AppName;
            Console.CursorVisible = false;
        }
    }
}
