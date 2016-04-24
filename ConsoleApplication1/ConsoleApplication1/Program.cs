using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




//do error checking 
//test
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int randno = Newnum(1, 101);
                int count = 1;
                while (true)
                {
                    Console.Write("Enter a number from 1 to 100 (enter 0 to quit): ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 0)
                        return;
                    else if (input < randno)
                    {
                        Console.WriteLine("The number is too low, try again!");

                        ++count;
                        continue;
                    }
                    else if (input > randno)
                    {
                        Console.WriteLine("The number is too high, try again!");
                        ++count;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("You guessed the number, well done! The number was {0}!", randno);
                        Console.WriteLine("It took you {0} {1}.\n", count, count == 1 ? "try" : "Tries");
                        break;
                    }
                }
            }
        }
        static int Newnum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
