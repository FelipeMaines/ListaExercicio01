﻿using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace listaExercicio.Exercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = 0;

            Console.Write("Sequência de Fibonacci até {0}: ", num);

            while (a <= num)
            {
                Console.Write(a + " ");

                c = a + b;
                a = b;
                b = c;
            }


        }
    }
}

//DIFICULDADE