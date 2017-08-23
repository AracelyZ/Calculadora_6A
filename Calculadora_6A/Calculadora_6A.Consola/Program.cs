using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora_6A.Libreria;

namespace Calculadora_6A.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos misMetodos = new Metodos();
            Console.WriteLine(misMetodos.Saludo());
            Console.WriteLine(misMetodos.Sumar(6, 34));
            Console.WriteLine(misMetodos.Restar(70, 24));
            Console.WriteLine(misMetodos.Multiplicar(5, 5));
            Console.WriteLine(misMetodos.Dividir(8, 2));
            Console.ReadKey();
        }
    }
}
