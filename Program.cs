using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma_de_2_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ingrese el primer numero");
            int N1= int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese el segundo numero");
            int N2= int.Parse(Console.ReadLine());
            int R= N1 + N2;
            System.Console.WriteLine("El resultado es:"+R);
            Console.ReadKey();

        }
    }
}
