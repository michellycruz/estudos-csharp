using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Xml.Linq;

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

            //Console.WriteLine("Selecione o que deseja comprar e a quantidade:");
            //Console.WriteLine("1 - Cachorro Quente R$4.00");
            //Console.WriteLine("2 - X-Salada R$4.50");
            //Console.WriteLine("3 - X-Bacon R$5.00");
            //Console.WriteLine("4 - Torrada simples R$2.00");
            //Console.WriteLine("5 - Refrigerante R$1.50");

            //string[] valores = Console.ReadLine().Split(' ');

            //int produto = int.Parse(valores[0]);
            //double quantidade = double.Parse(valores[1], CultureInfo.InvariantCulture);
            //double total = 0.0;



            //switch(produto) {
            //    case 1:
            //        total = 4.00 * quantidade;
            //        break;
            //    case 2:
            //        total = 4.50 * quantidade;
            //        break;
            //    case 3:
            //        total = 5.00 * quantidade;
            //        break;
            //    case 4:
            //        total = 2.00 * quantidade;
            //        break;
            //    case 5:
            //        total = 1.50 * quantidade;
            //        break;
            //    default: Console.WriteLine("Opção inválida");
            //        break;

            //}

            //Console.WriteLine("TOTAL: " + total.ToString("F2", CultureInfo.InvariantCulture));

            // ------------------------------------- PARTE 2 - EXERCICIO 6

            //Console.WriteLine("Informe um valor");

            //double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //if (numero < 0.0 || numero > 100.0) {
            //    Console.WriteLine("Fora de intervalo");
            //}
            //else if (numero <= 25.0) {
            //    Console.WriteLine("Intervalo [0, 25]");
            //}
            //else if (numero <= 50.0) {
            //    Console.WriteLine("Intervalo [25, 50]");
            //}
            //else if (numero <= 75.0) {
            //    Console.WriteLine("Intervalo [50, 75]");
            //}
            //else {
            //    Console.WriteLine("Intervalo [75, 100]");
            //}

            // ------------------------------------- PARTE 2 - EXERCICIO 7

            //string[] valores = Console.ReadLine().Split(' ');

            //double x = double.Parse(valores[0]);
            //double y = double.Parse(valores[1]);

            //if(x == 0.0 && y == 0.0) {
            //    Console.WriteLine("ORIGEM");
            //} else if (x > 0.0 && y > 0.0) {
            //    Console.WriteLine("Q1");
            //} else if (x < 0.0 && y > 0.0) {
            //    Console.WriteLine("Q2");
            //} else if (x < 0.0 && y < 0.0) {
            //    Console.WriteLine("Q3");
            //} else { Console.WriteLine("Q4"); 

            //}

            // ------------------------------------- PARTE 2 - EXERCICIO 8

            //double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double imposto;


            //if (salario <= 2000.0) {
            //    imposto = 0.0;
            //}
            //else if (salario <= 3000.0) {
            //    imposto = (salario - 2000.0) * 0.08;
            //}
            //else if (salario <= 4500.0) {
            //    imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            //}
            //else {
            //    imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            //}

            //if (imposto == 0.0) {
            //    Console.WriteLine("Isento");
            //}
            //else {
            //    Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            //}


            // ------------------------------------- AULA 30 - FUNÇÕES (SINTAXE)

            //    Console.WriteLine("Digite três números: ");
            //    int n1 = int.Parse(Console.ReadLine());
            //    int n2 = int.Parse(Console.ReadLine());
            //    int n3 = int.Parse(Console.ReadLine());

            //    double resultado = Maior(n1, n2, n3);



            //    Console.WriteLine("Maior = " + resultado);
            //}

            //static int Maior(int a, int b, int c) {
            //    int m;

            //    if(a > b && a > c) {
            //        m = a;
            //    }
            //    else if (b > c) {
            //        m = b;
            //    } else {
            //        m = c;
            //    }

            //    return m;

            // ------------------------------------- AULA 31 - DEBUGGING COM VISUAL STUDIO

            //    Console.WriteLine("Digite três números: ");
            //    int n1 = int.Parse(Console.ReadLine());
            //    int n2 = int.Parse(Console.ReadLine());
            //    int n3 = int.Parse(Console.ReadLine());

            //    double resultado = Maior(n1, n2, n3);



            //    Console.WriteLine("Maior = " + resultado);
            //}

            //static int Maior(int a, int b, int c) {
            //    int m;

            //    if(a > b && a > c) {
            //        m = a;
            //    }
            //    else if (b > c) {
            //        m = b;
            //    } else {
            //        m = c;
            //    }

            //    return m;

            // ------------------------------------- AULA 32 - ESTRUTURA REPETITIVA ENQUANTO (WHILE)

            //Console.Write("Digite um número: ");
            //double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            //while (x >= 0.0) {
            //    double raiz = Math.Sqrt(x);
            //    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));

            //    Console.Write("Digite outro número: ");
            //    x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}

            //Console.WriteLine("Número negativo, encerrando...");

            // ------------------------------------- PARTE 3 - EXERCICIO 01

            //Console.WriteLine("Informe a senha correta: ");
            //int senha = int.Parse(Console.ReadLine());

            //while (senha != 2002) {
            //    Console.WriteLine("Senha Inválida");
            //    senha = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Acesso Permitido");

            // ------------------------------------- PARTE 3 - EXERCICIO 02

            //Console.WriteLine("Informe o valor de X e de Y do plano cartesiano: ");
            //string[] valores = Console.ReadLine().Split(" ");
            //int x = int.Parse(valores[0]);
            //int y = int.Parse(valores[1]);

            //while (y != 0 && x != 0) {
            //    if (x > 1 && y > 1) {
            //        Console.WriteLine("PRIMEIRO");
            //    }
            //    else if (x < 0 && y > 0) {
            //        Console.WriteLine("SEGUNDO");
            //    }
            //    else if (x < 0 && y < 0) {
            //        Console.WriteLine("TERCEIRO");
            //    }
            //    else {
            //        Console.WriteLine("QUARTO");
            //    }

            //    valores = Console.ReadLine().Split(" ");
            //    x = int.Parse(valores[0]);
            //    y = int.Parse(valores[1]);
            //}
            //Console.WriteLine(" ");

            // ------------------------------------- PARTE 3 - EXERCICIO 03

            //Console.WriteLine("1. Álcool \n2. Gasolina \n3. Diesel");
            //int alcool = 0;
            //int gasolina = 0;
            //int diesel = 0;
            //int opcao = int.Parse(Console.ReadLine());

            //while (opcao != 4) {
            //    switch (opcao) {
            //        case 1:
            //            alcool++;
            //            break;
            //        case 2:
            //            gasolina++;
            //            break;
            //        case 3:
            //            diesel++;
            //            break;
            //    }
            //    opcao = int.Parse((Console.ReadLine()));
            //}
            //Console.WriteLine("MUITO OBRIGADO");
            //Console.WriteLine("Alcool: " +  alcool);
            //Console.WriteLine("Gasolina: " +  gasolina);
            //Console.WriteLine("Diesel: " + diesel);

            // ------------------------------------- AULA 34 - ESTRUTURA REPETITIVA PARA (FOR)

            //Console.WriteLine("Quantos números inteiros você vai digitar?");
            //int n = int.Parse(Console.ReadLine());

            //int soma = 0;
            //for(int i = 1; i <= n; i++) {
            //    Console.WriteLine("Valor #{0}: ", i);
            //    int valor = int.Parse(Console.ReadLine());
            //    soma += valor;
            //}

            //Console.WriteLine("Soma = " + soma);

            // ------------------------------------- PARTE 4 - EXERCICIO 01

            //Console.Write("X = ");
            //int x = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= x; i++) {
            //    if (i % 2 != 0) {
            //        Console.WriteLine(i);
            //    }
            //}

            // ------------------------------------- PARTE 4 - EXERCICIO 02

            //Console.WriteLine("Informe o valor de N:");
            //int n = int.Parse(Console.ReadLine());

            //int count_in = 0;
            //int count_out = 0;

            //for(int i = 0; i < n; i++) {
            //    Console.WriteLine("Informe os valores de X:");
            //    int x = int.Parse(Console.ReadLine());

            //    if(x >=10 && x <=20) {
            //        count_in++;
            //    }
            //    else {
            //        count_out++;
            //    }
            //}

            //Console.WriteLine(count_in + " in");
            //Console.WriteLine(count_out + " out");

            // ------------------------------------- PARTE 4 - EXERCICIO 03

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++) {
            //    string[] valores = Console.ReadLine().Split(" ");

            //    double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //    double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            //    double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //    double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

            //    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            //}

            // ------------------------------------- PARTE 4 - EXERCICIO 04

            //Console.WriteLine("Informe o valor de N:");
            //int n = int.Parse(Console.ReadLine());

            //for(int i = 0; i < n; i++) {

            //    string[] line = Console.ReadLine().Split(" ");

            //    int x = int.Parse(line[0]);
            //    int y = int.Parse(line[1]);

            //    if(y == 0) {
            //        Console.WriteLine("Divisão impossível");
            //    }
            //    else {
            //        double div = (double)x / y;
            //        Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
            //    }
            //}

            // ------------------------------------- PARTE 4 - EXERCICIO 05

            //Console.WriteLine("Informe o valor de n");
            //int n = int.Parse(Console.ReadLine());
            //int fatorial = 1;

            //for (int i = 1; i <= n; i++) {
            //    fatorial = fatorial * i;
            //}

            //Console.WriteLine("O fatorial de " + n + " é " + fatorial);

            // ------------------------------------- PARTE 4 - EXERCICIO 06

            //Console.WriteLine("Informe o valor de N");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++) {
            //    if (n % i == 0) {
            //        Console.WriteLine(i);
            //    }
            //}

            // ------------------------------------- PARTE 4 - EXERCICIO 07

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++) {
            //    int valor1 = i;
            //    int valor2 = i * i;
            //    int valor3 = i * i * i;
            //    Console.WriteLine($"{valor1} {valor2} {valor3}");
            //}

            // ------------------------------------- AULA 38 - RESOLVENDO O PROBLEMA SEM ORIENTAÇÃO A OBJETOS

            //double xA, xB, xC, yA, yB, yC;

            //Console.WriteLine("Entre com as medidas do triângulo X: ");
            //xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com as medidas do triângulo Y: ");
            //yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double p = (xA + xB + xC) / 2.0;
            //double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            //p = (yA + yB + yC) / 2.0;
            //double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            //Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            //Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //if (areaX > areaY) {
            //    Console.WriteLine("Maior área: X");
            //}
            //else {
            //    Console.WriteLine("Maior área: Y");
            //}

            // ------------------------------------- AULA 39 - CRIANDO UMA CLASSE COM TRÊS ATRIBUTOS

            //Triangulo x, y;

            //x = new Triangulo();
            //y = new Triangulo();

            //Console.WriteLine("Entre com as medidas do triângulo X: ");
            //x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com as medidas do triângulo Y: ");
            //y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double p = (x.A + x.B + x.C) / 2.0;
            //double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            //p = (y.A + y.B + y.C) / 2.0;
            //double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            //Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            //Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //if (areaX > areaY) {
            //    Console.WriteLine("Maior área: X");
            //}
            //else {
            //    Console.WriteLine("Maior área: Y");
            //}

            // ------------------------------------- PRIMEIROS EXERCÍCIOS - EXERCÍCIO 01
            //Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.


            //Pessoas p1 = new Pessoas();
            //Pessoas p2 = new Pessoas();

            //Console.WriteLine("Dados da primeira pessoa");
            //Console.Write("Nome: ");
            //p1.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //p1.Idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados da segunda pessoa");
            //Console.Write("Nome: ");
            //p2.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //p2.Idade = int.Parse(Console.ReadLine());

            //if( p1.Idade > p2.Idade) {
            //    Console.WriteLine(p1.Nome + " é mais velho(a) que " + p2.Nome);
            //} else if ( p2.Idade > p1.Idade) {
            //    Console.WriteLine(p2.Nome + " é mais velho(a) que " + p1.Nome);
            //} else {
            //    Console.WriteLine("Tem a mesma idade");
            //}

            // ------------------------------------- PRIMEIROS EXERCÍCIOS - EXERCÍCIO 02
            //Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.

            Pessoas p1 = new Pessoas();
            Pessoas p2 = new Pessoas();

            Console.WriteLine("Informe os dados do primeiro funcionário");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.Write("Salário: ");
            p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe os dados do segundo funcionário");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());
            Console.Write("Salário: ");
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Media = (p1.Salario +  p2.Salario)/2;
            Console.WriteLine("Media: " + Media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}