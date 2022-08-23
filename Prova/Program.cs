using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 8
            Console.WriteLine("\t\t\t\tProgramas");
            Console.WriteLine();

            Console.WriteLine("Selecione o programa desejado: ");
            Console.WriteLine("1.Calcular IMC     2.Média aluno     3.Mostrar os dois maiores números inteiros     \n4.Número impar ou par/negativo ou positivo     5.Calcular a área do terreno     6.Calcular salário     \n7.Converter anos em dias\n\n");
            Console.Write("Opção: ");
            int escolha = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if(escolha == 1) 
            {
                Console.WriteLine("\t\t\tPrograma para calcular IMC");
                Console.WriteLine();

                Console.Write("Qual seu peso: ");
                double peso = Convert.ToDouble(Console.ReadLine());
                Console.Write("Altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());
                double IMC = peso / (altura * altura);
                Console.Write("Seu IMC é: " + IMC); 
            }
            else if(escolha == 2)
            {
                Console.WriteLine("\t\t\tPrograma para calcular a média do aluno");
                Console.WriteLine();

                Console.Write("Nota 1: ");
                double nota1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nota 2 : ");
                double nota2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nota 3: ");
                double nota3 = Convert.ToDouble(Console.ReadLine());

                double total = nota1 + nota2 + nota3;
                double media = total / 3;

                if (media >= 6)
                    Console.WriteLine("Sua média é: " + media + " , então você está aprovado!");
                else
                    Console.WriteLine("Sua média é: " + media + " , você está reprovado!");
            }
            else if(escolha == 3)
            {
                Console.WriteLine("\t\tPrograma para mostrar os dois maiores números inteiros");
                Console.WriteLine();

                Console.Write("Número 1: ");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Número 2: ");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Número 3: ");
                int numero3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if((numero1 > numero2)&&(numero1 > numero3))
                {
                    if ((numero2 > numero3) && (numero2 < numero1))
                    {
                        Console.WriteLine("Número maior: " + numero1);
                        Console.WriteLine("Segundo número maior: " + numero2);
                    }
                }
                if ((numero2 > numero1) && (numero2 > numero3))
                {
                    if ((numero1 > numero3) && (numero1 < numero2))
                    {
                        Console.WriteLine("Número maior: " + numero2);
                        Console.WriteLine("Segundo número maior: " + numero1);
                    }
                }
                if ((numero3 > numero1) && (numero3 > numero2))
                {
                    if ((numero2 > numero1) && (numero2 < numero3))
                    {
                        Console.WriteLine("Número maior: " + numero3);
                        Console.WriteLine("Segundo número maior: " + numero2);
                    }
                }
                if ((numero3 > numero1) && (numero3 > numero2))
                {
                    if ((numero1 > numero2) && (numero1 < numero3))
                    {
                        Console.WriteLine("Número maior: " + numero3);
                        Console.WriteLine("Segundo número maior: " + numero1);
                    }
                }
                if ((numero1 > numero3) && (numero1 > numero2))
                {
                    if ((numero3 > numero2) && (numero3 < numero1))
                    {
                        Console.WriteLine("Número maior: " + numero1);
                        Console.WriteLine("Segundo número maior: " + numero3);
                    }
                }
            }
            else if(escolha == 4)
            {
                Console.WriteLine("\t\tPrograma para descobrir se o número é impar ou par e positivo e negativo");
                Console.WriteLine();

                Console.Write("Insira um número: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if((numero % 2 == 0) && (numero >= 0))
                {
                    Console.WriteLine("Seu número é par e é positivo");
                }
                else if((numero % 2 == 0) && (numero < 0))
                {
                    Console.WriteLine("Seu número é par e é negativo");
                }
                else if((numero % 2 == 1) && (numero >= 0))
                {
                    Console.WriteLine("Seu número é impar e é positivo");
                }
                else if((numero % 2 == 1) && (numero < 0))  // Ver
                {   
                    Console.WriteLine("Seu número é impar e é negativo");
                }
                else
                {
                    Console.WriteLine("Erro");
                }
            }
            else if(escolha == 5)
            {
                Console.WriteLine("\t\tPrograma para calcular a área do terreno");
                Console.WriteLine();

                Console.Write("Lado: ");
                double lado = Convert.ToDouble(Console.ReadLine());
                Console.Write("Comprimento: ");
                double comprimento = Convert.ToDouble(Console.ReadLine());

                double area = lado * comprimento;
                Console.WriteLine("A área do terreno é: " + area + " metros quadrados");
            }
            else if(escolha == 6)
            {
                Console.WriteLine("\t\tPrograma para salario");
                Console.WriteLine();

                Console.Write("Salário: ");
                double salario = Convert.ToDouble(Console.ReadLine());
                double aumento = 15.0 / 100.0;
                double resultado_aumento = salario + (aumento * salario);
                double desconto = 8.0 / 100.0;
                double resultado_desconto = resultado_aumento - (desconto * resultado_aumento);
                Console.WriteLine("Salário final é de: R$" + resultado_desconto);
            }
            else if(escolha == 7)
            {
                Console.WriteLine("\t\tPrograma para mostrar quantos dias de vida você possui");
                Console.WriteLine();

                Console.Write("Insira sua idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                int final = idade * 365;
                Console.WriteLine("Você já viviu " + final + " dias");
            }

            Console.ReadKey();
        }
    }
}
