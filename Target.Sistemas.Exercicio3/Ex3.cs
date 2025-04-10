//3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
//• O menor valor de faturamento ocorrido em um dia do mês;
//• O maior valor de faturamento ocorrido em um dia do mês;
//• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

using System;
using System.Text.Json;

class FaturamentoDia
{
    public int dia { get; set; }
    public decimal valor { get; set; }
}

class Ex3
{
    static void Main()
    {
        var json = File.ReadAllText("faturamento.json");
        var dados = JsonSerializer.Deserialize<List<FaturamentoDia>>(json);

        foreach (var item in dados)
            Console.WriteLine($"Dia {item.dia:D2} - R$ {item.valor:F2}");

        var menor = dados.Where(d => d.valor > 0).Min(d => d.valor);
        var maior = dados.Max(d => d.valor);
        var media = dados.Where(d => d.valor > 0).Average(d => d.valor);
        var acimaMedia = dados.Count(d => d.valor > media);

        Console.WriteLine($"\nMenor faturamento: R$ {menor:F2}");
        Console.WriteLine($"Maior faturamento: R$ {maior:F2}");
        Console.WriteLine($"Dias com faturamento acima da média: {acimaMedia}");
    }
}

