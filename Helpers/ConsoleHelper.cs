using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odilibo.Helpers
{
    public static class ConsoleHelper
    {
        public static void WriteColored(string msg, ConsoleColor color)
        {
            ConsoleColor orgCol = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ForegroundColor = orgCol;
        }


        public static void WriteError(string msg)
        {
            WriteColored(msg, ConsoleColor.Red);
        }

        public static void WriteSuccess(string msg)
        {
            WriteColored(msg, ConsoleColor.Green);
        }


    }
}
