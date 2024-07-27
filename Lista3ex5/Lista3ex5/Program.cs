using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
               Console.WriteLine("Digite um valor positivo");
               num = int.Parse(Console.ReadLine());

            }
            while (num < 0);
            for (int i = 0; i < 11; i++)
                Console.WriteLine("{0} X {1} = {2}", i,num, i * num);
        }
    }
}
