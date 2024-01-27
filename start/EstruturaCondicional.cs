using System;
using System.Diagnostics;
using System.Globalization;

namespace Exercicios
{    
    internal class EstruturaCondicional
    {
        static void Main(string[] args)
        {
            //exercicio estrutura condicional 01
           
            string produto;
            int codigo,qtd;
            double preco, total;
            
            


            Console.WriteLine("Bem vindo !");
            Console.WriteLine("digite o codigo do produto e a quantidade consumida separado por espaços (COD - QTD):");
            string[] valores = Console.ReadLine().Split(' ');
            codigo = int.Parse(valores[0]);
            qtd = int.Parse(valores[1]);

            
            if (codigo == 1)
            {
                produto = "cachorro quente";
                preco = 4.00;

                Console.WriteLine($"O codigo digitado foi: {codigo}, o produto {produto}, valor total R$:{total = qtd * preco}");
            }
            else if(codigo == 2)
            {
                produto = "x salada";
                preco = 4.50;
                Console.WriteLine($"O codigo digitado foi: {codigo}, o produto {produto}, valor total R$:{total = qtd * preco}");
            }
            else if(codigo == 3)
            {
                produto = "x bacon";
                preco = 5.00;
                Console.WriteLine($"O codigo digitado foi: {codigo}, o produto {produto}, valor total R$:{total = qtd * preco}");
            }
            else if(codigo == 4) 
            {
                produto = "torrada";
                preco = 2.00;
                Console.WriteLine($"O codigo digitado foi: {codigo}, o produto {produto}, valor total R$:{total = qtd * preco}");
            }
            else if (codigo == 5)
            {
                produto = "refri";
                preco = 1.50;
                Console.WriteLine($"O codigo digitado foi: {codigo}, o produto {produto}, valor total R$:{total = qtd * preco}");
            }
            else
            {
                Console.WriteLine("CODIGO INCORRETO, POR FAVOR DIGITE UM CODIGO VALIDO.");
            }
            
       }
    }
}
