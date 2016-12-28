namespace IrishCommon.Common
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Printer
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
    }
}
