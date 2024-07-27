using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int valor;
                string loop = "nada";

            do
            {
                do
                {
                    Console.Write("Digite um valor não negativo para calcular o fatorial: ");
                    valor = int.Parse(Console.ReadLine());

                    if (valor < 0)
                    {
                        Console.WriteLine("Erro: O valor não pode ser negativo. Tente novamente.");
                    }
                } while (valor < 0);

                int fatorial = 1;
                for (int i = 1; i <= valor; i++)
                {
                    fatorial *= i;
                }

                Console.WriteLine($"O fatorial de {valor} é: {fatorial}");

                do
                {
                    Console.WriteLine("Deseja ou não uma nova execução do programa? (S para sim e N para não): ");
                    loop = Console.ReadLine();
                }
                while (loop.ToUpper() != "N" && loop.ToUpper() != "S");

            }
            while (loop.ToUpper() == "S");
            }
        }
    }
