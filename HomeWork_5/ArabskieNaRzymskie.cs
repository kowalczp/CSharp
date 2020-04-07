using System;
using System.Linq;
using System.Text;
 

namespace HomeWork_5
{
    class ArabskieNaRzymskie
    {
        public ArabskieNaRzymskie(int liczba)
        {
            StringBuilder result = new StringBuilder();
            int[] arabskie = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            string[] rzymskie = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            while (liczba > 0)
            {
                for (int i = arabskie.Count() - 1; i >= 0; i--)

                    if (liczba / arabskie[i] >= 1)
                    {

                        liczba -= arabskie[i];

                        result.Append(rzymskie[i]);

                        break;
                    }
            }
            Console.WriteLine(result);
        }
    }
}
