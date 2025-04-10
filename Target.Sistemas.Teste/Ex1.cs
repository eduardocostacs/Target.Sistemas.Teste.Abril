//1) Observe o trecho de código abaixo: int INDICE = 13, SOMA = 0, K = 0;
//Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }
//Imprimir(SOMA);

using System;

class Ex1
{
    static void Main()
    {

        var indice = 13;
        var soma = 0;
        var k = 0;

        while (k < indice)
        {
            k++;
            soma += k;
        }

        Console.WriteLine($"O valor de soma ao final do código é {soma}");
    }
}
