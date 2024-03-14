using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Qual o tamanho do triangulo: ");
        int tamanhoQuadrado = int.Parse(Console.ReadLine());
        for (int linha = 0; linha < tamanhoQuadrado; linha++)
        {
            for (int coluna = 0; coluna <= linha; coluna++)
            {
                System.Console.Write(linha * 1);
            }
            System.Console.WriteLine();
        } 
    }
}