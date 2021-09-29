using System;
using System.Globalization;

namespace atividade2209
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //declarações
            double media;
            double soma = 0.0;
            //recebe o número de pessoas e envia para um array.
            Console.WriteLine("insira o número de pessoas:");
            int n = int.Parse(Console.ReadLine());
            double[] vector = new double[n];

            for (int i = 0; i < n; i++)
            {
                //pede a altura de cada pessoa e guarda em seu array respectivo.
                Console.WriteLine();
                Console.Write("INSIRA A ALTURA DA PESSOA (" + (i + 1) + "):");
                vector[i] = double.Parse(Console.ReadLine(),
                 CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < n; i++)
            {
                //soma todos dados.
                soma += vector[i];
            }
            //cria a média da altura de cada um.
            media = soma / n;
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                //apresenta a altura de cada pessoa.
                Console.WriteLine("ALTURA DA PESSOA (" + i + "): " + vector[i]);
            }
            //apresenta a média das alturas.
            Console.WriteLine("A MÉDIA DE ALTURA DAS PESSOAS INSERIDAS É = " + media);
        }
    }
}