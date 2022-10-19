using System;
using System.Diagnostics;
using System.Globalization;

namespace Preferencia
{    
    internal class PrefWhile
    {
        static void Main(string[] args)
        {
        
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            
            Console.WriteLine("Bem-vindo a nossa pesquisa !");
            Console.WriteLine("1 = alcool, 2 = gasolina, 3  diesel");
            Console.WriteLine("DIGITE O NUMERO DO COMBUSTIVEL");
            int tipo = int.Parse(Console.ReadLine());


            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool = alcool + 1;
                }
                else if (tipo == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (tipo == 3)
                {
                    diesel = diesel + 1;
                }
                Console.WriteLine("Proximo");
                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("TOTAL VOTOS:");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        
        }
    }
}
