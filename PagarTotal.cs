using System;
using System.Diagnostics;
using System.Globalization;

namespace Recebe
{
    internal class PagarTotal
    {
        static void Main(string[] args)
        {

//Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
//código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

            Console.WriteLine("Entre com o código da peça 1, a quantidade de peças 1, o valor unitário da peça 1 (Separe por espaços)");
            string[] vet1 = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet1[0]);
            int qtd = int.Parse(vet1[1]);
            double valor = double.Parse(vet1[2]);

            double resultado = qtd * valor;

            Console.WriteLine("Entre com o código da peça 2, o quantidade de peças 2, o valor unitário da peça 2 (Separe por espaços)");
            string[] vet2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(vet2[0]);
            int qtd2 = int.Parse(vet2[1]);
            double valor2 = double.Parse(vet2[2]);

            double resultado2 = qtd2 * valor2;

            double total = resultado + resultado2;

            Console.WriteLine($"o valor total a pagar será R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            
         }
    }
}
