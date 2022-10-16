using System;
using System.Diagnostics;
using System.Globalization;

namespace CalculoAreaCirculo
{    
    internal class AreaCirculo
    {
        static void Main(string[] args)
        {
        
 //exercicio 02 calculadora de area de um circulo
           Console.WriteLine("Digite o valor do raio");
           double raio = double.Parse(Console.ReadLine());
           double pi = 3.14159;
           double result = Math.Pow(raio, 2) * pi;
           
           Console.WriteLine($"O valor da area deste circulo é {result.ToString("F4", CultureInfo.InvariantCulture)}");
           
           }
    }
}
