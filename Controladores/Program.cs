using Ejercicio2C;
using Ejercicio2C.Servicios;

namespace Ejercicio2C
{
    class program
    {
        /// <summary>
        /// metodo por donde entra la aplicacion
        /// 231023-aamd
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            pedirI pI = new pedirC();
            int a = pI.pedir();
            if (a == (Math.Sqrt(a) % == 0))
            {
                Console.WriteLine("se puede expresar como el cuadrado de otro número entero ");
            }
            else { Console.WriteLine("no se puede expresar como el cuadrado de otro número entero"); }
        }
    }
}  

