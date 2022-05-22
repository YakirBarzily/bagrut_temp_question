using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int day_month = 1;
            float day_temp;
            float Max_temp = 1;
         //   float month_average; 
            float all_temp = 1;
            int counter = 0;

            while (day_month <= 31 && day_month >= 1)
            {
               
                Console.WriteLine("please enter day month");
                day_month = int.Parse(Console.ReadLine());
                Console.WriteLine("please enter day temp");
                day_temp = int.Parse(Console.ReadLine());
                if (day_month <= 31 && day_month >= 1)
                {
                    counter++;
                    if (day_temp > Max_temp)
                        Max_temp = day_temp;

                    all_temp = all_temp + day_temp;
                }
            }
            Console.WriteLine("Max_temp is {0}", Max_temp);
            Console.WriteLine("counter is {0}", counter );
            Console.WriteLine("average is {0}", all_temp / counter - 1);
                
        }
    }
}
