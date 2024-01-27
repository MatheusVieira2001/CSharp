using System;
using System.Diagnostics;
using System.Globalization;

namespace CalculoSalarioT
{
    internal class CalculaSalario
    {
        static void Main(string[] args)
        {
//Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
//hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
//decimais.
            
            Console.WriteLine("Digite o NUMERO DO FUNCIONARIO: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu numero de horas, ");
            int horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o valor por hora:");
            double salario = double.Parse(Console.ReadLine());
            
            double result = horas * salario;

            Console.WriteLine("Numero do funcionario: " + numero);
            Console.WriteLine($"E seu salário será de : R${result.ToString("F2", CultureInfo.InvariantCulture)}");
            
             }
    }
}
