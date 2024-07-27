using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int N;

                do
                {
                    Console.WriteLine("Digite a quantidade de números (positivo e menor que 20): ");
                    N = int.Parse(Console.ReadLine());
                    if (N < 0 || N >= 20)
                    {
                        Console.WriteLine("Erro, digite o valor novamente ");
                    }
                } while (N < 0 || N >= 20);

                if (N == 0)
                {
                    Console.WriteLine("Não há valores para processar ");
                    return;
                }

                int[] numeros = new int[N];

                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine($"Escreva o número {i + 1}: ");
                    numeros[i] = int.Parse(Console.ReadLine());
                }

                int maior = numeros[0];
                int menor = numeros[0];
                int soma = 0;
                int positivos = 0;
                int negativos = 0;

                for (int i = 0; i < N; i++)
                {
                    if (numeros[i] > maior)
                    {
                        maior = numeros[i];
                    }

                    if (numeros[i] < menor)
                    {
                        menor = numeros[i];
                    }

                    soma += numeros[i];

                    if (numeros[i] > 0)
                    {
                        positivos++;
                    }
                    else if (numeros[i] < 0)
                    {
                        negativos++;
                    }
                }

                double media = (double)soma / N;
                double porcentagemPositivos = (double)positivos / N * 100;
                double porcentagemNegativos = (double)negativos / N * 100;

                Console.WriteLine($"O maior valor é: {maior} ");
                Console.WriteLine($"O menor valor é: {menor} ");
                Console.WriteLine($"A soma dos valores é: {soma} ");
                Console.WriteLine($"A média aritmética dos valores é: {media} ");
                Console.WriteLine($"A porcentagem de valores que são positivos: {porcentagemPositivos}% ");
                Console.WriteLine($"A porcentagem de valores que são negativos: {porcentagemNegativos}% ");
            }
        }
    }

