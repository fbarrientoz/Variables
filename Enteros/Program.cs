using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear tres variables de tipo INT y asignarles valores estáticos.
            int numero_1 = 5;
            int numero_2 = 10;
            int numero_3 = 20;
            //Crear una variable de tipo INT la cual guardará la SUMA de las tres variables anteriores.
            int suma = numero_1 + numero_2 + numero_3 ;
            //Mostrar en pantalla el valor de SUMA, con el siguiente mensaje “El valor de SUMA es:” < suma >
            Console.WriteLine("El valor de SUMA es:" + suma);
            Console.WriteLine("Presiona cualquier tecla para finalizar");
            Console.ReadKey();


        }
    }
}
