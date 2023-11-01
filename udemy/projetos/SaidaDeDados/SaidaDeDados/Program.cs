using System;
using System.Globalization;

namespace MyApp {
    class Program {
        static void Main(string[] args) {

            //int idade = 25;
            double saldo = 10.26789;
            string nome = "camila";

            //Console.WriteLine("{0} tem {1} anos de idade e tem o saldo igual a {2:F2} reais", nome, idade, saldo);
            //Console.WriteLine($"{nome} tem {idade} anos de idade e tem o saldo igual a {saldo:F2} reais");
            //Console.WriteLine(nome + " tem " + idade + " anos de idade e o tem saldo igual a " + saldo.ToString("F2") + " reais");

            //EXERCÍCIO DE FIXAÇÃO//

            Console.WriteLine("EXERCÍCIO DE FIXAÇÃO");
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($"Produtos:\n{produto1}, cujo preço é ${preco1:F2}\n{produto2}, cujo preço é ${preco2:F2}\n\n");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}