//4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
//• SP – R$67.836,43
//• RJ – R$36.678,66
//• MG – R$29.229,88
//• ES – R$27.165,48
//• Outros – R$19.849,53

//Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora. 

using System;

class Ex4
{
    static void Main()
    {
        List<Dictionary<string, decimal>> fatEstado = new List<Dictionary<string, decimal>>()
        {
            new Dictionary<string, decimal> { { "SP", 67836.43m } },
            new Dictionary<string, decimal> { { "RJ", 36678.66m } },
            new Dictionary<string, decimal> { { "MG", 29229.88m } },
            new Dictionary<string, decimal> { { "ES", 27165.48m } },
            new Dictionary<string, decimal> { { "Outros", 19849.53m } }
        };

        decimal total = fatEstado.Sum(dict => dict.Values.First());

        foreach (var estado in fatEstado)
        {
            var uf = estado.Keys.First();
            var valor = estado.Values.First();
            var perc = (valor / total) * 100;
            Console.WriteLine($"{uf}: {perc:F2}%");
        }
    }
}
