using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KusanovicLenardProvjeraZnanjaZadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            string unos;

            Console.WriteLine("Upisi 3 razlicita broja: ");

            unos = Console.ReadLine();
            a = Convert.ToInt32(unos.Substring(0, 2));
            

            
            b = Convert.ToInt32(unos.Substring(3, 2));
            

            
            c = Convert.ToInt32(unos.Substring(6, 2));
            if (a > b && a > c) {
                Console.WriteLine(a);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine(c);
            }
            else if (b > c && b > a)
            {
                Console.WriteLine(b);
            }
            Console.ReadKey();




        }
    }
}
