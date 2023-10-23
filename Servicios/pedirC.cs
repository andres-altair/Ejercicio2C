using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2C.Servicios
{
    internal class pedirC : pedirI
    {
        public int pedir()
        {
            Console.WriteLine("escribe un numero entero");
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
}
