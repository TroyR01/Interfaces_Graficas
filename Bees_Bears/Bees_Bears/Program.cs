using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Porblemas con la sincronizacion 
namespace Bees_Bears
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hilos h = new Hilos();
            while(h.cont<3)
            {

            }
            Console.WriteLine("Terminado");
            Console.ReadKey();
        }
    }
}
