using System;

class Program
{
    static void Main(string[] args)
    {
        for (int contador = 1; contador <=10; contador++)
        {
            System.Console.WriteLine($"7 X { contador } = {contador * 7}");
        }
    }
    /*{
        System.Console.WriteLine("Qual o tamanho do triangulo: ");
        int tamanhoQuadrado = int.Parse(Console.ReadLine());
        for (int linha = 0; linha < tamanhoQuadrado; linha++)
        {
            for (int coluna = 0; coluna <= linha; coluna++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        } 
    }*/
    /*{
        System.Console.WriteLine("Qual o tamanho do qadrado: ");
        int tamanhoQuadrado = int.Parse(Console.ReadLine());
        for (int linha = 0; linha < tamanhoQuadrado; linha++)
        {
            for (int coluna = 0; coluna < tamanhoQuadrado; coluna++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        } 
    }*/
    /*{            
        Tabuleiro.InicializaTabuleiro();            
        for (int linha = 0; linha < 8; linha++)
        {
            for (int coluna = 0; coluna < 8; coluna++)
            {
                if (linha == coluna)
                {
                    Tabuleiro.Adicionar(linha, coluna, "B");
                }
                else
                {                
                    Tabuleiro.Adicionar(linha, coluna, "I");
                }
            }
        }
    Tabuleiro.ImprimeTabuleiro();
    }*/
    /*{            
        Tabuleiro.InicializaTabuleiro();            
        for (int linha = 0; linha < 8; linha++)
        {
            for (int coluna = 0; coluna < 8; coluna++)
            {
                if (linha % 2 == 0)
                {
                    Tabuleiro.Adicionar(linha, coluna, "P");
                }
                else
                {                
                    Tabuleiro.Adicionar(linha, coluna, "I");
                }
            }
        }
    Tabuleiro.ImprimeTabuleiro();
    }*/
    /*{
        Tabuleiro.InicializaTabuleiro();            
        for (int linha = 0; linha < 8; linha++)
        {
            for (int coluna = 0; coluna < 8; coluna++)
            {
                Tabuleiro.Adicionar(linha, coluna, "B");
            }
            Tabuleiro.ImprimeTabuleiro();
        }
    }*/
    /*{
        Tabuleiro.InicializaTabuleiro();

        Tabuleiro.Adicionar(0,2, "B");
        Tabuleiro.ImprimeTabuleiro();
    }*/
    /*{
        System.Console.WriteLine("Digite um numero: ");
        int numero1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Digite outro numero: ");
        int numero2 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("A soma dos numeros eh: " + (numero1 + numero2));
    }*/
}