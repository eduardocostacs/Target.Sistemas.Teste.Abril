//2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores 
//    (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, 
//    ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

//IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

using System;

class Ex2
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci: ");
            int numero;

            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
            {
                Console.Write("Por favor, insira um número inteiro não negativo: ");
            }

            if (PertenceAFibonacci(numero))
            {
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
            }

            Console.Write("\nDeseja verificar outro número? (s/n): ");
            string resposta = Console.ReadLine().Trim().ToLower();

            if (resposta != "s" && resposta != "sim")
            {
                Console.WriteLine("Programa encerrado.");
                break;
            }

            Console.WriteLine(); 
        }
    }

    static bool PertenceAFibonacci(int num)
    {
        if (num == 0 || num == 1) return true;

        int a = 0;
        int b = 1;

        while (b < num)
        {
            int temp = b;
            b = a + b;
            a = temp;
        }

        return b == num;
    }
}