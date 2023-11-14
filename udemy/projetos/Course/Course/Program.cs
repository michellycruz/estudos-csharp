using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            //Console.WriteLine("Informe o primeiro número");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Informe o segundo número");
            //int n2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("SOMA = " + (n1 + n2));

            double raio, area, pi = 3.14159;
            Console.WriteLine("Informe o valor do raio: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * raio * raio;

            Console.WriteLine("Área igual a " +  area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}