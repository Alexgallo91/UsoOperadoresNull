using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoalescingOperatorNull
{
    class Program
    {
        static void Main(string[] args)
        {
            int? ticketsVendidos = null;
            int ticketsDisponibles = ticketsVendidos ?? 10;

            //usamoes ?? cuando se trabaja con valores nulos, en el ejemplo de arriba
            //explica que ticketsDisponibles sera igual a, si ticketsVendidos es un valor null
            //este automaticamentes se convertira en 0, en caso contrario, tomara el valor 
            //que tenga asignado la variable ticketsVendidos
            Console.WriteLine("ticketsDisponibles = {0}", ticketsDisponibles);
            Console.ReadKey();
        }
    }
}
