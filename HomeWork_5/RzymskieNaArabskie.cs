using System;
using System.Collections.Generic;
using System.Linq;
 
namespace HomeWork_5
{
    class RzymskieNaArabskie
    {
        public int result = 0;
 
        public static IDictionary<char, int> RzymskieArabskie
        {
            get
            {
                return new Dictionary<char, int>
            {{'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}};
            }
        }

        public  RzymskieNaArabskie(IEnumerable<char> liczba)
        {


            for (int i = liczba.Count() - 1; i >= 0; i--)
            {
                
                char c = liczba.ElementAt(i);
               // Console.WriteLine(c);

                bool op = liczba.Skip(i).Any(rn => RzymskieArabskie[rn] > RzymskieArabskie[c]);
            //    Console.WriteLine(op);

                result = op ? result - RzymskieArabskie[c] : result + RzymskieArabskie[c];
             //   Console.WriteLine(result);
                
            }
            Console.WriteLine(result);


        }
    }
}
