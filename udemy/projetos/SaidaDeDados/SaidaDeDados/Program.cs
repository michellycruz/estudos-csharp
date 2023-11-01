using System;
using System.Globalization;

namespace MyApp {
    class Program {
        static void Main(string[] args) {

            int idade = 25;
            double saldo = 10.26789;
            string nome = "camila";

            Console.WriteLine("{0} tem {1} anos de idade e tem o saldo igual a {2:F2} reais", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos de idade e tem o saldo igual a {saldo:F2} reais");
            Console.WriteLine(nome + " tem " + idade + " anos de idade e o tem saldo igual a " + saldo.ToString("F2") + " reais");
        }
    }
}