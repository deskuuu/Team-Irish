namespace IrishNotes
{
    using IrishCommon.Common;
    using IrishCommon.Common.Menu;
    using System;
    using System.Threading;

    /// <summary>
    /// The entry class of the IrishNotesApp.
    /// </summary>
    public class MainIrishNotes
    {
        public static void Main()
        { 
            App.SetUpConsole();

            // Just for test
            var a = new string[] { "Welcome", "To", "IrishNotes!" };
            Console.CursorLeft = Console.WindowWidth / 2;
            // 
            int z = 1;
            int r = 3;

            for (int i = 0; i < a.Length; i++)
            {
                Thread.Sleep(300);

                Console.CursorTop = z;
                if (i != 0)
                {
                    z = 0;
                }
                z += 1;

                Console.CursorLeft = r;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                foreach (var item in a[i])
                {
                    Console.Write(item);
                    Console.CursorTop = z+2;
                    Console.CursorLeft = r;
                    r += 5;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Printer.PrintTextFile("../../logo.txt");
            Console.ForegroundColor = ConsoleColor.DarkGreen;


            var menu = new Menu();
            menu.PrinMenu();
            Console.CursorVisible = false;
            Console.ReadLine();
        }
    }
}
