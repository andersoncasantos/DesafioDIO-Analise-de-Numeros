using static System.Console;

class Program
{
    static void Main()

    {
        int numero = 0;

        int quantidadePares = 0;
        int quantidadeImpares = 0;
        int quantidadePositivos = 0;
        int quantidadeNegativos = 0;

        for (int i = 0; i < 5; ++i)
        {
            numero = int.Parse(ReadLine());
            if (numero % 2 == 0) { ++quantidadePares; }
            else { ++quantidadeImpares; }
            if (numero > 0) { ++quantidadePositivos; }
            else if (numero < 0) { ++quantidadeNegativos; }
        }

        WriteLine($"{quantidadePares} par(es)");

        WriteLine($"{quantidadeImpares} impar(es)");

        WriteLine($"{quantidadePositivos} positivo(s)");

        WriteLine($"{quantidadeNegativos} negativo(s)");

    }
}