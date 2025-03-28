using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static List<int> EncontrarNumerosEscondidos(int A, int B, int C, int D, List<int> E)
    {     
        List<int> resultado = new List<int>();

        for (int i = A; i <= B; i++)
        {           
            if (i % C != 0)
                continue;
           
            if (SomaDosDigitos(i) < D)
                continue;

            if (ContemDigitosProibidos(i, E))
                continue;

            resultado.Add(i);
        }
       
        resultado.Sort();
        return resultado;
    }

    private static int SomaDosDigitos(int numero)
    {
        int soma = 0;
        while (numero > 0)
        {
            soma += numero % 10;
            numero /= 10;
        }
        return soma;
    }

    private static bool ContemDigitosProibidos(int numero, List<int> E)
    {
        string numeroStr = numero.ToString();
        foreach (int digito in E)
        {
            if (numeroStr.Contains(digito.ToString()))
                return true;
        }
        return false;
    }

    public static void Main()
    {
        int A = 10;
        int B = 50;
        int C = 5;
        int D = 5;
        List<int> E = new List<int> { 3, 7 };

        List<int> resultado = EncontrarNumerosEscondidos(A, B, C, D, E);
        Console.WriteLine(string.Join(", ", resultado));
    }
}