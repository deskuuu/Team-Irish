namespace IrishNotes
{
    using System;
    using System.Threading;

    using Common;
    using System.Collections.Generic;
    using Common.Menu;

    /// <summary>
    /// The entry class of the IrishNotesApp.
    /// </summary>
    public class MainIrishNotes
    {
        public static void Main()
        {
            App.SetUpConsole();
            Printer.PrintFrame();

            IList<ConsoleColor> colors = new List<ConsoleColor> { ConsoleColor.DarkGreen, ConsoleColor.DarkYellow, ConsoleColor.DarkRed };
            Printer.PrintWelcomeText(colors, 2, 10);

            var from = Console.CursorTop;

            Console.ForegroundColor = ConsoleColor.Green;
            Printer.PrintTextFile("../../logo.txt");

            var to = Console.CursorTop;
            Thread.Sleep(1500);
            Printer.Clear(from, to);

            var menu = new Menu();
            menu.Draw();

            Console.ReadLine();
        }
    }
}
