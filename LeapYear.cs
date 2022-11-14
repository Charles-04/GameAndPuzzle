using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAndPuzzle
{
    public class LeapYear
    {
        public static void PrintLeapYear()
        {
            int lastLeapYear = 2020;
            for (int i = 0; i < 20; i++)
            {
                lastLeapYear += 4;
                if(i == 0) {
                    Console.Write("The next ");
                    Console.Write(i + 1);
                    Console.Write(" Leap year is ");
                    Console.WriteLine(lastLeapYear);
                }
                else
                {
                    Console.Write("The next ");
                    Console.Write(i + 1);
                    Console.Write(" Leap years is ");
                    Console.WriteLine(lastLeapYear);
                }
               

            }
        }
    }
}
