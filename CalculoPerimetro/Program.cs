using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declarar las variables necesarias para mostrar en pantalla el calculo del perímetro
            int a = 10;
            int b = 10;
            int c = 7;
            int p = a + b + c;

            //del triangulo que se encuentra a la derecha.
            //Debera imprimir el siguiente mensaje: “El perímetro del triangulo es: “ < perímetro“>
            // a = 10, b = 10 , c = 7
            Console.WriteLine("El perímetro del triangulo es:" + p);
            Console.WriteLine("Presiona cualquier tecla para finalizar");
            Console.ReadKey();

        }
    }
}
