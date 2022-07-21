using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
     
        static void Main(string[] args)
        {
             Console.WriteLine("Digite seu nome:");
             string nome =(Console.ReadLine());
             Console.WriteLine("Bem Vindo, seu nome é:");
             Console.WriteLine(nome);
             Console.WriteLine();

             // EXERCÍCIO 01) FINALIZADO !!!

               int num1;
               int num2;
               int num3;

               Console.WriteLine("Digite o primero número.");
               num1 = int.Parse(Console.ReadLine());
               Console.WriteLine("Digite o segundo número");
               num2 = int.Parse(Console.ReadLine());
               Console.WriteLine("Digite o terceiro número");
               num3 = int.Parse(Console.ReadLine());

               Console.WriteLine("=========================");

               Console.WriteLine("O menor número é: ");

               if (num1 < num2 && num1 < num3)
               {
                   Console.WriteLine("O primeiro número ");
               }
               else if (num2 < num1 && num2 < num3)
               {
                   Console.WriteLine("O segundo número ");
               }
               else if (num3 < num1 && num3 < num2)
               {
                   Console.WriteLine("O terceiro número ");
               }
               else if (num1 == num2 && num2 == num3 && num1 == num3)
               {
                   Console.WriteLine("Todos Iguais !");
               }
               else
               {
                   Console.WriteLine("Dados Inválidos !");
               }


             // EXERCÍCIO 02) FINALIZADO !!!

             Console.ReadLine(); 

             int n1;
             int n2;
             int n3;

             Console.WriteLine("Digite o primeiro número");
             n1 = int.Parse(Console.ReadLine());
             Console.WriteLine("Digite o segundo número");
             n2 = int.Parse(Console.ReadLine());
             Console.WriteLine("Digite o terceiro número");
             n3 = int.Parse(Console.ReadLine());

             Console.WriteLine("=================");
             Console.WriteLine("O maior número é: ");

             if (n1 > n2 && n1 > n3)
             {
                 Console.WriteLine("O primeiro número");
             }
             else if (n2 > n1 && n2 > n3)
             {
                 Console.WriteLine("O segundo número");
             }
             else if (n3 > n1 && n3 > n2)
             {
                 Console.WriteLine("O terceiro número");
             }
             else if (n1 == n2 && n2 == n3 && n1 == n3)
             {
                 Console.WriteLine("Todos Iguais !");
             }
             else
             {
                 Console.WriteLine("Dados Inválidos !");
             }

             Console.ReadLine();

             Console.WriteLine("Obrigado !");

            Console.ReadLine();

            // EXERCÍCIO 03) FINZALIZADO !!!

             Console.WriteLine("fale o grau de sua emergencia de 0 a 10!");
             int chamada = int.Parse(Console.ReadLine());

             if (chamada <=3)
             {
                 Console.WriteLine("grau BAIXO, descanse e caso piorar nos ligue, 190. Obrigado !");
             }
             else if (chamada <=6)
             {
                 Console.WriteLine("grau MÉDIO, se persistir o problema nos ligue, 190 !");
             }
             else if (chamada <=9)
             {
                 Console.WriteLine("ALTO, Procure ajuda ! número 190 LIGUE !");
             }
             else 
             {
                 Console.WriteLine("GRAVE, Estamos te encaminhnado para a emergência !");
             }

             Console.WriteLine("Obrigado !");
            Console.ReadLine();

            //====================================================================

            //EXERCÍCIO FUNÇÕES:

            Console.WriteLine("Ajustanto em 25% a mais do valor inicial dos produtos: ");
            Console.ReadLine();

            Precofinal(30);
            Precofinal(50);
            Precofinal(45);
            Precofinal(60);
            Precofinal(15);
            
            Console.WriteLine("==========================");
            Console.ReadLine();

            float Recebe_Area = Pizza(30);
            Console.WriteLine("A área da Pizza de raio 30 é: " + Recebe_Area + " cm");
            
            Console.WriteLine("==============================");

            trianguloArea();

            Console.WriteLine("Love c# . ");

            Console.ReadLine();
        }

        //EX 01) FEITO !!!
        static void Precofinal(int valor)
        {
            int valorFinal = valor + (valor / 4);
            Console.WriteLine("O valor final é: " + valorFinal + "$");
        }

        //EX 02) FEITO !!!
        static float Pizza(int valor)
        {
            float pi = 3.14f;
            float area = pi * (valor * valor);
            return area;
     
        }

        //EX 03) FEITO !!!
        static void trianguloArea()
        {
            int calcbase = 250;
            int calcaltura = 350;
            float result = calcbase * calcaltura / 2;
            Console.WriteLine("A área de uma praça cuja a altura é 350 e a base é 250, é: " + result + " m²");

        }
    }
}
