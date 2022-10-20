
using System;
using System.Globalization;

namespace Course
{
    class FormulaHeron
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as 3 medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Entre com as 3 medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();


            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else if (areaY > areaX)
            {
                Console.WriteLine("Maior área: Y");
            }
            else
            {
                Console.WriteLine("AREAS IGUAIS");

            }

        }
        
        class Triangulo
        {
            public double A;
            public double B;
            public double C;
            public double Area()
            {
                double p = (A + B + C) / 2.0;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }
    }
}
