using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_po_ST_ot_8._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число и разберете дали е четно: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Числото ви е четно!");
            }
            else
            {
                Console.WriteLine("Числото ви не е четно!");
            }
            Console.ReadKey();
        }
    }
}
