using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            float x = 4.5f;

            double y = x;
            //Console.WriteLine(y);

            //double a;
            //float b;

            // a = 5.1;
            // b = a;  dá erro pois o double tem 8 bites e o float 4

            //como definir um casting

            //a = 5.1;
            //b = (float)a;

            //Console.WriteLine(b);

            //outro exemplo 

            //double a;
            //int b;

            //a = 5.1;
            //b = (int)a; //é arredondado pra 5

            //Console.WriteLine(b);

            int a = 5;
            int b = 2;

            double resultado = (double)a / b;
            Console.WriteLine(resultado);
        }
    }
}