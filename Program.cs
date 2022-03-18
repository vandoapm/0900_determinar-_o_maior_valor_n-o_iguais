using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0900_determinar__o_maior_valor_não_iguais
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Determinar o maior valor, sendo a diferente de b");
            Console.WriteLine();

            Console.Write("Valor a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Valor b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (a == b)
            {

                Console.WriteLine("Execute novamente e insira valores diferentes entre si.");

            }
            else if (a < b)
            {
                Console.Write(b + " é maior que " + a);
            }
            else
            {

                Console.Write(a + " é maior que " + b);

            }



            Console.ReadLine();

        }
    }
}
