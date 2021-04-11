using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_ej._12_03._04._21_cadenas
//12. Solicite el ingreso de dos frases y determine si son iguales.	
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase1;
            string frase2;

            Console.WriteLine("Ingrese frase 1");
            frase1 = Console.ReadLine();
            Console.WriteLine("Ingrese frase 2");
            frase2 = Console.ReadLine();

            Console.WriteLine(frase1 == frase2);

            Console.ReadKey();
        }
    }
}
