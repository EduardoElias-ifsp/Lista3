using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine("Escreva um número positivo: ");
                    numeros[i] = int.Parse(Console.ReadLine());
                    if (numeros[i] < 0)
                        Console.WriteLine("Erro, tente denovo");
                } while (numeros[i] < 0);
            }

            int maior = numeros[0];
            for (int i = 1; i < 10; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
            }
            Console.WriteLine($"O maior valor é: {maior}");

            Console.Write("A soma dos valores é: ");
            Console.WriteLine(numeros[0] + numeros[1] + numeros[2] + numeros[3] + numeros[4] + numeros[5] + numeros[6] + numeros[7] + numeros[8] + numeros[9] );

            Console.Write("A média aritmética dos valores é: ");
            Console.WriteLine( (numeros[0] + numeros[1] + numeros[2] + numeros[3] + numeros[4] + numeros[5] + numeros[6] + numeros[7] + numeros[8] + numeros[9]) / 10 );
            


        }
    }
}
