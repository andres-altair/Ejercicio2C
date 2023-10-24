using Ejercicio2C;
using Ejercicio2C.Servicios;
using System.ComponentModel;

namespace Ejercicio2C
{
    class program
    {
        /// <summary>
        /// metodo por donde entra la aplicacion
        /// 231023-amd
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            pedirI pI = new pedirC(); 
            int a = pI.pedir();
            int b = Convert.ToInt32(Math.Sqrt(a));
            if (a == b*b)
            {
                Console.WriteLine(" tiene raiz entera es: " +a+"="+b+"*"+b);
            }
            else { Console.WriteLine("no tiene raiz entera"); }
        }
    }
}  



      