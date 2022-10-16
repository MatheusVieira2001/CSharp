using System;
using System.Diagnostics;
using System.Globalization;

namespace Calculo
{    
    internal class CaculaAreas
    {
        static void Main(string[] args)
        {
         //Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
            //  a) a área do triângulo retângulo que tem A por base e C por altura.
            //  b) a área do círculo de raio C. (pi = 3.14159)
            //  c) a área do trapézio que tem A e B por bases e C por altura.
            //  d) a área do quadrado que tem lado B.
            //  e) a área do retângulo que tem lados A e B

            double A, B, C;
            double pi = 3.14159;

            Console.WriteLine("Entre com os 3 valores (Separados por espaço):");
            string[] vet1 = Console.ReadLine().Split(' ');
            A = double.Parse(vet1[0]);
            B = double.Parse((vet1[1]));
            C = double.Parse((vet1[2]));

            double ATriangulo = A * C / 2;
            double ACirculo = Math.Pow(C, 2) * pi;
            double ATrapezio = (A + B) / 2.0 * C;
            double AQuadrado = B * B;
            double ARetangulo = A * B;

            Console.WriteLine("a área do triângulo retângulo é: " + ATriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("a área do círculo é: " + ACirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(" a área do trapézio é: " + ATrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("a área do quadrado é: " + AQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(" a área do retângulo é: " + ARetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }

    }
}
