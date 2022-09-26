using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg az 1. számot:");
            int elso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg az 2. számot:");
            int masodik = Convert.ToInt32(Console.ReadLine());

            if (elso > masodik)
            {
                Console.WriteLine("A nagyobbik szám: {0}",elso);
            }
            else if (masodik > elso)
            {
                Console.WriteLine("A nagyobbik szám:{0}",masodik);
            }
        }
    }
}
