namespace IrishNotes.Common
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;

    public static class Printer
    {
        public static void PrintTextFile(string textFile)
        {
            var readText = File.ReadAllText(textFile);

            Console.WriteLine(readText);
        }

        public static void PrintText(List<string> text)
        {
            foreach (var item in text)
            {
                Console.WriteLine(item);
            }
        }

        public static void ChangeColorWrite(ConsoleColor color, string text)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = originalColor;
        }

        public static void PrintWelcomeText(IList<ConsoleColor> colors, int top = ConsoleInfoConstants.TopWelcome, int left = ConsoleInfoConstants.LeftWelcome)
        {
            var headerText = ConsoleInfoConstants.AppWelcomeText.Split(' ');

            var random = new Random();

            foreach (var word in headerText)
            {
                Console.CursorTop = top;
                Console.CursorLeft = Console.BufferWidth / 2 - left;

                foreach (var item in word)
                {
                    ChangeColorWrite(colors[random.Next(0, 3)], item.ToString());
                    Thread.Sleep(ConsoleInfoConstants.ThreadSleepForWelcomeText);
                }

                top++;

                ClearCurrentConsoleLine();
            }
        }

        public static void PrintFrame()
        {
            //Test
            var name = "Irish Notes";
            var length = name.Length - 1;

            for (int row = 0; row < ConsoleInfoConstants.AppHeight - 1; row++)
            {
                for (int col = 0; col < ConsoleInfoConstants.AppWidth - 1; col++)
                {
                    Console.SetCursorPosition(col, row);
                    if (row == 0 || row == ConsoleInfoConstants.AppHeight - 2)
                    {
                        if (col == 0)
                        {
                            while (col < length)
                            {
                                Console.Write(name[col++]);
                            }
                        }
                        else
                        {
                            Console.Write("|");
                        }
                    }
                    else if(row==1 || row == ConsoleInfoConstants.AppHeight - 3)
                    {
                        Console.Write("~");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
            }
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        public static void Clear(int fromLine, int toLine)
        {
            for (int i = fromLine; i < toLine; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine(new string(' ', ConsoleInfoConstants.AppWidth));
            }
        }
    }
}
