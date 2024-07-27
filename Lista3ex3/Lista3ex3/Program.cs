using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sexo;

            do
            {
                Console.WriteLine("Digite seu sexo 'F ou M'");
                sexo = Console.ReadLine();

            }
            while (sexo.ToUpper() != "F" && sexo.ToUpper() != "M");
            Console.WriteLine("Seu sexo é {0}",sexo.ToUpper());
        }
    }
}
