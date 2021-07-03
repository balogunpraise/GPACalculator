using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GPACalculator
{
    public static class TableClass
    {
        private const int tableWidth = 97;

        public static void PrintLines()
        {
            Console.WriteLine(new string('-', tableWidth)); // I did this because i want th character to be printed for the number of times of tableWidth
        }


        public static void Rows(params string[] columns) //I included params because i do not know the amount of the input. 
        { 
            int columnWidth = (tableWidth - columns.Length) / columns.Length; //Defining the length of the column width

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
