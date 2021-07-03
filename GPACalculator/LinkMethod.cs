using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GPACalculator
{
    class LinkMethod
    {
        
        List<CourseInformation> resultList = new List<CourseInformation>();


        public void NewMethod()
        {
            Console.Clear();
            //LinkMethod linkageClass = new LinkMethod();
            Console.WriteLine("Enter \"start\" to start and \"end\" to exit:");
            string start = Console.ReadLine().ToLower();

            while(start == "start")
            {
                Console.WriteLine();
                Console.Write("Enter \"1\" to add result");
                Console.WriteLine("Enter \"2\" to end the process");
                string option = Console.ReadLine();

                if(option == "1")
                {

                }
            }
        }


        public void Add()
        {
            Console.WriteLine("Enter course code");
            string courseCode = Console.ReadLine();
            if (!(Regex.IsMatch(courseCode, @"[A-Z]{3}[0-9]{3}")))
            {
                Console.WriteLine("Enter correct course code");
            }
            else 
            {
                Console.WriteLine("Enter student's score");
                double studentScore = double.Parse(Console.ReadLine());
                if (studentScore.Equals(typeof(string)))
                {
                    Console.WriteLine("Not a valid score");
                }
                else
                {
                    Console.WriteLine("Enter the course unit");
                    int courseUnit = int.Parse(Console.ReadLine());
                    if(courseUnit > 5 || courseUnit < 0 || courseUnit.Equals(typeof(string)))
                    {
                        Console.WriteLine("Enter a valid course unit");
                    }
                    else
                    { 
                        var grade = LetterGrades.F;
                        int gradeUnit = (int)LetterGrades.F;
                        CourseInformation information = new CourseInformation(courseCode, courseUnit, studentScore, grade, gradeUnit, );
                        resultList.Add()
                    }
                    
                }
               
            }
            
        }
    }

   
}
