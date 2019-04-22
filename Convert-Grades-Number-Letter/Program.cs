using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Grades_Number_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a number from 0 to 100");
                int grade = int.Parse(Console.ReadLine());

                if(grade >= 99 && grade <= 100)
                {
                    Console.WriteLine("Letter Grade: A+");
                }
                else if(grade >= 90 && grade <= 98)
                {
                    Console.WriteLine("Letter Grade: A");
                }
                else if (grade >= 88 && grade <= 89)
                {
                    Console.WriteLine("Letter Grade: A-");
                }
                else if (grade >= 86 && grade <= 87)
                {
                    Console.WriteLine("Letter Grade: B+");
                }
                else if (grade >= 82 && grade <= 85)
                {
                    Console.WriteLine("Letter Grade: B");
                }
                else if (grade >= 80 && grade <= 81)
                {
                    Console.WriteLine("Letter Grade: B-");
                }
                else if (grade >= 78 && grade <= 79)
                {
                    Console.WriteLine("Letter Grade: C+");
                }
                else if (grade >= 69 && grade <= 77)
                {
                    Console.WriteLine("Letter Grade: C");
                }
                else if (grade >= 67 && grade <= 68)
                {
                    Console.WriteLine("Letter Grade: C-");
                }
                else if (grade >= 65 && grade <= 66)
                {
                    Console.WriteLine("Letter Grade: D+");
                }
                else if (grade >= 62 && grade <= 64)
                {
                    Console.WriteLine("Letter Grade: D");
                }
                else if (grade >= 60 && grade <= 61)
                {
                    Console.WriteLine("Letter Grade: D-");
                }
                else if (grade >= 0 && grade <= 60)
                {
                    Console.WriteLine("Letter Grade: F");
                }

                Console.WriteLine("Press Y to enter more grades.");
                string response = Console.ReadLine().ToLower();
                if(response != "y")
                {
                    break;
                }
            }
        }
    }
}
