using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GPACalculator
{
    public static class TableClass
    {
        private const int tableWidth = 80;

        public static void PrintLines()
        {
            Console.WriteLine(new string('-', tableWidth));
        }


        public static void Rows(params string[] columns)
        { 
            int columnWidth = (tableWidth - columns.Length) / columns.Length;

            const string bar = "|";

            string row = columns.Aggregate(bar, (seperator, columnText) => seperator + TextAllignment(columnText, columnWidth) + bar);
            Console.WriteLine(row);
        }

        private static string TextAllignment(string columnText, int columnWidth)
        {
            columnText = columnText.Length > columnWidth ? columnText.Substring(0, columnWidth - 3) + "..." : columnText;

            return string.IsNullOrEmpty(columnText) ? new string (' ', columnWidth) : columnText.PadRight(columnWidth - ((columnWidth - columnText.Length))/2).PadLeft(columnWidth);
        }
    }
}
