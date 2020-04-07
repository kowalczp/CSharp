using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    class Program
    {
        static void Main(string[] args)

        {
            ArabskieNaRzymskie naRzymskie = new ArabskieNaRzymskie(140);
            RzymskieNaArabskie naArabskie = new RzymskieNaArabskie("CXL");
            Console.ReadKey();
        }

}
}
