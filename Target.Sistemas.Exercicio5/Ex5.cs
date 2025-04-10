//5) Escreva um programa que inverta os caracteres de um string.

//IMPORTANTE:
//a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
//b) Evite usar funções prontas, como, por exemplo, reverse;

using System;

class Ex5
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Digite uma palavra: ");
            string entrada = Console.ReadLine();
            string invertida = "";

            for (int i = entrada.Length - 1; i >= 0; i--)
            {
                invertida += entrada[i];
            }

            Console.WriteLine($"Invertida: {invertida}");
        }
    }
}