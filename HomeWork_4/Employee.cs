using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    class Employee
    {

        public Employee(string imie, string nazwisko, double  stawkaGodzinowa)
        {
             
            Console.WriteLine("Pracownik {0} {1}, stawka godzinowa {2} zł/h", imie, nazwisko, stawkaGodzinowa);
            Console.Write("Podaj ilość przepracowanych godzin: ");
            Double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Do zapłaty " + ((number > 8) ? 8 * stawkaGodzinowa + (number - 8) * stawkaGodzinowa * 2 : (number * stawkaGodzinowa)) + " zł");
            // break;

        } 
        
    }
 
     
}
