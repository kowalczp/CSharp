using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNum();
            Console.ReadKey();

        }

        static void PrimeNum()
        {


            while (true)
                {
                    Console.Write("Please enter en integer: ");//hhhhh
                    String number = Convert.ToString(Console.ReadLine());
                   

                if (Regex.IsMatch(number, @"^\d+$") == false)    
                    {
                        Console.WriteLine("Wrong data type");                        
                    }
                    else
                    {

                    int numberIfTrue = int.Parse(number);
                    bool ifPrime = true;

                    for (int i = numberIfTrue - 1; i > 1; i--)
                    {
                        if ((numberIfTrue % i) == 0)
                        {
                            ifPrime = false;
                            break;
                        }
                    }
                    
                    Console.WriteLine("Your number {0} is " + ((ifPrime && numberIfTrue > 1) ? "a prime value"  : "not a prime value"), numberIfTrue);
                    break;


                }
                }


        }
    }
}
