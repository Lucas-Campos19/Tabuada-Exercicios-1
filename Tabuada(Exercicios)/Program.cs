using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada_Exercicios_
{
    internal class Program
    {
        static void Main(string[] args)
        {//Tabuada digitada pelo usuario.

            //int a = 0;
            //int b = 0;
            //Console.Write(" Digite um número:");
            //a = int.Parse(Console.ReadLine());  

            //while(b <= 10)
            //{
            //    Console.WriteLine( a + " x " + b + " = " + a * b);
            //    b = b + 1;  
            //}
            //Console.ReadKey();

            //_________________________________________________________

            //tabuada ordem do maior para o menor.

            //int a = 0;
            //int b = 10;
            //Console.Write(" Digite um número:");
            //a = int.Parse(Console.ReadLine());

            //while (b > 0)
            //{
            //    Console.WriteLine(a + " x " + b + " = " + a * b);
            //    b = b - 1;
            //}
            //Console.ReadKey();

            //________________________________________________________________

            //Modificar o código e mostrar tabuadas de 1 até o 10 em sequencia.

            int a = 1;
            int b = 1;
            while (a <= 10)
            {
                Console.WriteLine("Tabuada do: " + a);

                while (b <= 10)
                {
                    Console.WriteLine(a + " x " + b + " = " + a * b);
                    b = b + 1;
                }
                Console.WriteLine();
                a++;
                b = b - 10;
            }

            Console.ReadKey();
        }
    }
}
