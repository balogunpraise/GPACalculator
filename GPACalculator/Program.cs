using System;

namespace GPACalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            TableClass.PrintLines();
            TableClass.Rows("COURSE & CODE", "COURSE UNIT", "GRADE", "GRADE UNIT", "WEIGTH Pt", "REMARK");
            TableClass.PrintLines();
        }
    }
}
