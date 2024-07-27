using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

                Console.WriteLine("Digite o primeiro valor");
                num1 = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Digite o segundo valor");
                num2 = int.Parse(Console.ReadLine());


            } while (num1 >= num2);
            Console.WriteLine("{0} é maior que {1}",num2,num1);

        }
    }
}
