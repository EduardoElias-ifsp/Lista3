using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int interA;
            int interB;

            do
            {
                Console.WriteLine("Digite um valor positivo");
                num1 = int.Parse(Console.ReadLine());
            }
            while (num1 < 0);

            Console.WriteLine("Digite o primeiro valor do intervalo");
            interA = int.Parse(Console.ReadLine());

            do {
                Console.WriteLine("Digite o segundo valor do intervalo");
                interB = int.Parse(Console.ReadLine());
            }
            while (interA > interB);

            for (int i = interB; i > interA ; i--)
                Console.WriteLine("{0} X {1} = {2}", i, num1, i * num1);
           
        }
    }
}
