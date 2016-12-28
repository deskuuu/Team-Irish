namespace IrishCommon.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
        }
    }
}
