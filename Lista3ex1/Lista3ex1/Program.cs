using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int num ;
          
            do
            {

             Console.WriteLine("Digite um valor positivo");
             num = int.Parse(Console.ReadLine());

            }while (num < 0);
            Console.WriteLine(num + " é positivo");
               
        }
    }
}
