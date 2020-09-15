using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            String genero;
            double edad,numPulsacionF,numPulsacionM, pulsacion =0;

            Console.WriteLine("Ingrese el Genero 'F' o 'M' ");
            genero = Console.ReadLine();

            Console.WriteLine("Ingrese la edad");
            edad = int.Parse(Console.ReadLine());

            if(pulsacion>0) 
            {
                pulsacion = 'F';
                pulsacion = 'f';
                numPulsacionF = (220 - edad) / 10;
                Console.WriteLine("El numero de pulsuaciones es: "+numPulsacionF);
            }
            else
            {
                pulsacion = 'M';
                pulsacion = 'm';
                numPulsacionM = (210 - edad) / 10;
                Console.WriteLine("El numero de pulsuaciones es: " + numPulsacionM);
            }
            Console.ReadLine();
        }
    }
}
