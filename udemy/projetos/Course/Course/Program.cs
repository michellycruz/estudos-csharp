using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Informe o primeiro número");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("SOMA = " + (n1 + n2));
        }
    }
}