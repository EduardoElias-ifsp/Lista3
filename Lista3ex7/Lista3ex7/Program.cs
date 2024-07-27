using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i1 = 1; i1 < 21; i1++) 
            { 

            for (int i = 1; i < 11; i++)
                Console.WriteLine("{0} X {1} = {2}",i1,i,i1*i);
            
            Console.ReadLine();
            }
            
        }
    }
}
