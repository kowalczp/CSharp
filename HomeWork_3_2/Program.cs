using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3_2
{
    class Program
    {
        static void Main(string[] args)
        {

            IsPrime();
            Console.ReadKey();
        }

        public static void IsPrime()
        {
            Console.Write("Please enter en integer: ");//hhhhh
            int number = Convert.ToInt32(Console.ReadLine());
 

            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is not a prime number");
            }
            else
            {
                for (int i = 3; i <= (int)Math.Floor(Math.Sqrt(number)); i += 2)
                {
                    if ((number % i == 0) || (number % 2 == 0))
                    {
                        Console.WriteLine(number + " is not a prime number");
                        return;
                    }

                }
                Console.WriteLine(number + " is a prime number");
            }

          



        }
    }
}
