using System;

namespace MyApp {
    class Program {
        static void Main(string[] args) {
            char genero = 'F';
            int idade = 25;
            double saldo = 10.26789;
            string nome = "camila";

            Console.WriteLine(nome);
            Console.WriteLine(genero);
            Console.WriteLine(idade);   
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
        }
    }
}