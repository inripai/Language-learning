using System;
using System.Globalization;

namespace Curso1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int A = int.Parse(vet[0], CultureInfo.InvariantCulture);
            int B = int.Parse(vet[1], CultureInfo.InvariantCulture);
            int C = int.Parse(vet[2], CultureInfo.InvariantCulture);

            int MaiorAb = (A+B+Math.Abs(A-B))/2;
            int MaiorC = (MaiorAb+ C+Math.Abs(MaiorAb-C))/2;

            Console.WriteLine(MaiorC+" eh o maior");
            Console.WriteLine();
        }
    }
}

