using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1;
            int n2 = 1;

            Console.WriteLine(n1);
            Console.WriteLine(n2);

            for (int i = 3; i <= 30; i++)
            {
                int n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;


            }
        }
    }
}
