using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            // ------------------------------------- EXERCICIO 1

            //Console.WriteLine("Informe o primeiro número");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Informe o segundo número");
            //int n2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("SOMA = " + (n1 + n2));

            // ------------------------------------- EXERCICIO 2

            //double raio, area, pi = 3.14159;
            //Console.WriteLine("Informe o valor do raio: ");
            //raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //area = pi * raio * raio;

            //Console.WriteLine("Área igual a " +  area.ToString("F4", CultureInfo.InvariantCulture));

            // ------------------------------------- EXERCICIO 3

            //Console.WriteLine("Valor de A: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Valor de B: ");
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine("Valor de C: ");
            //int c = int.Parse(Console.ReadLine());

            //Console.WriteLine("Valor de D: ");
            //int d = int.Parse(Console.ReadLine());

            //int diferenca = (a * b - c * d);

            //Console.WriteLine("DIFERENÇA = " + diferenca);

            // ------------------------------------- EXERCICIO 4

            //Console.WriteLine("ID do funcionário: ");
            //int idFuncionario = int.Parse(Console.ReadLine());

            //Console.WriteLine("Número de horas trabalhadas");
            //double horasTrabalhadas = double.Parse(Console.ReadLine());

            //Console.WriteLine("Valor que recebe por hora: ");
            //double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double salario = horasTrabalhadas * valorPorHora;

            //Console.WriteLine("NUMBER: " + idFuncionario);
            //Console.WriteLine("SALARY: U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

            // ------------------------------------- EXERCICIO 5

            Console.WriteLine("ID Peça 1:");
            int peca1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade:");
            int qntPeca1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor da peça:");
            double valorPc1 = double.Parse(Console.ReadLine());

            Console.WriteLine("ID PEÇA 2:");
            int peca2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade:");
            int qntPeca2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor da peça:");
            double valorPc2 = double.Parse(Console.ReadLine());

            double total = (qntPeca1 * valorPc1) + (qntPeca2 * valorPc2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}