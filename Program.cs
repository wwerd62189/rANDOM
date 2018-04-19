using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rand = new Random();
            int i = 0;
            while (i <= 9)
            {
                
                i++;
                int r1 = Rand.Next(1, 43);
                int r2 = Rand.Next(1, 43);
                int r3 = Rand.Next(1, 43);
                int r4 = Rand.Next(1, 43);
                int r5 = Rand.Next(1, 43);
                int r6 = Rand.Next(1, 43);
                
                

               


                Console.WriteLine("號碼: {0} {1} {2} {3} {4} {5} ", r1, r2, r3, r4, r5, r6);
            }
            Console.ReadLine();

        }
    }
}
