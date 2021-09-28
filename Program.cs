using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i+", ");
                }

            }
            bool runProgram = true;
            while (runProgram == true)
            {
                Console.WriteLine("\nDo you want to keep going? y/n");
                string answerYN = Console.ReadLine();
               
                if (answerYN.ToLower() == "n")
                {
                    runProgram = false;
                }
                else
                {
                    continue;
                }
            }
            int sum=0;
            for(int l = 0; l <= 5; l++)
            {
                sum += l;
            }
            Console.WriteLine("The sum is " + sum);
            Console.WriteLine("Press any key to exit program.");
            Console.ReadKey();
        }
    }
}
