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

            //int codigoPeca1, codigoPeca2, quantidadePeca1, quantidadePeca2;
            //double preco1, preco2, total;

            //Console.WriteLine("--- PRODUTO 1 ---");
            //Console.WriteLine("INFORME O CÓDIGO DO PRODUTO, QUANTIDADE E PREÇO POR UNIDADE");

            //string[] valores = Console.ReadLine().Split(' ');
            //codigoPeca1 = int.Parse(valores[0]);
            //quantidadePeca1 = int.Parse(valores[1]);
            //preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);


            //Console.WriteLine("--- PRODUTO 2 ---");
            //Console.WriteLine("INFORME O CÓDIGO DO PRODUTO, QUANTIDADE E PREÇO POR UNIDADE");

            //valores = Console.ReadLine().Split(' ');
            //codigoPeca2 = int.Parse(valores[0]);
            //quantidadePeca2 = int.Parse(valores[1]);
            //preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //total = preco1 * quantidadePeca1 + preco2 * quantidadePeca2;

            //Console.WriteLine("--- VALOR TOTAL ---");
            //Console.WriteLine("VALOR A PAGAR: R$" + total.ToString("F2", CultureInfo.InvariantCulture));

            // ------------------------------------- EXERCICIO 6

            //double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo;

            //Console.WriteLine("Informe o valor de A, B e C:");
            //String[] valores = Console.ReadLine().Split(' ');
            //a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            //c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //triangulo = a * c / 2;
            //circulo = 3.14159 * c * c;
            //trapezio = (a + b) / 2.0 * c;
            //quadrado = b * b;
            //retangulo = a * b;

            //Console.WriteLine(
            //    "TRIÂNGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture) +
            //    "\nCIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture) +
            //    "\nTRAPÉZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture) +
            //    "\nQUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture) +
            //    "\nRETÂNGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

            // ------------------------------------- TESTE AULA 27

            //Console.WriteLine("Entre com um número inteiro");
            //int x = int.Parse(Console.ReadLine());

            //if( x % 2 == 0) {
            //    Console.WriteLine("Par!");
            //}
            //else {
            //    Console.WriteLine("Impar");
            //}

            // ------------------------------------- PARTE 2 - EXERCICIO 1

            //Console.WriteLine("Informe um número inteiro");
            //int numero = int.Parse(Console.ReadLine());

            //if(numero < 0) {
            //    Console.WriteLine("NUMERO NEGATIVO");
            //}
            //else {
            //    Console.WriteLine("NUMERO POSITIVO");
            //}

            // ------------------------------------- PARTE 2 - EXERCICIO 2

            //Console.WriteLine("INFORME UM NUMERO INTEIRO");
            //int numero = int.Parse(Console.ReadLine());

            //if (numero % 2 == 0) {
            //    Console.WriteLine("PAR");
            //}
            //else {
            //    Console.WriteLine("IMPAR");
            //}

            // ------------------------------------- PARTE 2 - EXERCICIO 3

            //Console.WriteLine("INFORME O VALOR DO PRIMEIRO E DO SEGUNDO NÚMERO");

            //string[] valores = Console.ReadLine().Split(' ');

            //int n1 = int.Parse(valores[0]);
            //int n2 = int.Parse(valores[1]);

            //if (n1 % n2 == 0 || n2 % n1 == 0) {
            //    Console.WriteLine("SÃO MÚLTIPLOS");
            //}
            //else {
            //    Console.WriteLine("NÃO SÃO MÚLTIPLOS");
            //}

            // ------------------------------------- PARTE 2 - EXERCICIO 4

            //Console.WriteLine("Informe a hora de início e término de um jogo");
            //string[] valores = Console.ReadLine().Split(' ');
            //int inicio = int.Parse(valores[0]);
            //int termino = int.Parse(valores[1]);
            //int duracao;

            //if (inicio < termino) {
            //    duracao = termino - inicio;
            //}
            //else {
            //    duracao = 24 - inicio + termino;
            //}

            //Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

            // ------------------------------------- PARTE 2 - EXERCICIO 5

          

            Console.WriteLine("Selecione o que deseja comprar e a quantidade:");
            Console.WriteLine("1 - Cachorro Quente R$4.00");
            Console.WriteLine("2 - X-Salada R$4.50");
            Console.WriteLine("3 - X-Bacon R$5.00");
            Console.WriteLine("4 - Torrada simples R$2.00");
            Console.WriteLine("5 - Refrigerante R$1.50");

            string[] valores = Console.ReadLine().Split(' ');

            int produto = int.Parse(valores[0]);
            double quantidade = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double total = 0.0;

           

            switch(produto) {
                case 1:
                    total = 4.00 * quantidade;
                    break;
                case 2:
                    total = 4.50 * quantidade;
                    break;
                case 3:
                    total = 5.00 * quantidade;
                    break;
                case 4:
                    total = 2.00 * quantidade;
                    break;
                case 5:
                    total = 1.50 * quantidade;
                    break;
                default: Console.WriteLine("Opção inválida");
                    break;

            }

            Console.WriteLine("TOTAL: " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}