using System;

class Program
{
    static void Main(string[] args)
/*    {
        double somatorio = 0;
        System.Console.WriteLine("Digite o valor que deseja doar: ");
        double valorInserido = double.Parse(Console.ReadLine());
        while (valorInserido >= 0)
        {
            somatorio = somatorio + valorInserido;
            System.Console.WriteLine("Digite o valor que deseja doar: ");
            valorInserido = double.Parse(Console.ReadLine());
        }
        //System.Console.WriteLine("O valor arrecadado foi: " + somatorio);
        System.Console.WriteLine("O valor arrecadado foi: " + Math.Round(somatorio, 2));
        //Math.Round- serve para arredondar o valor. Ex. Math.Round(valor, 2)- para extenção com 2 numeros. 
    }*/
    {
        quantidadeCompra = 0;
        double somatorio = 0;
        System.Console.WriteLine("Digite a quantidade de itens comprados: ");
        double quantidadeCompra = double.Parse(Console.ReadLine());
//        System.Console.WriteLine("Digite o valor da compra: ");
//        double valorCompra = double.Parse(Console.ReadLine());
        while (valorCompra >= 0)
        {
            somatorio = somatorio + valorCompra;
            System.Console.WriteLine("Digite o valor da compra: ");
            valorCompra = double.Parse(Console.ReadLine());
        }
        //System.Console.WriteLine("O valor arrecadado foi: " + somatorio);
        System.Console.WriteLine("O valor arrecadado foi: " + Math.Round(somatorio, 2));
        //Math.Round- serve para arredondar o valor. Ex. Math.Round(valor, 2)- para extenção com 2 numeros. 
    }
/*    {
        double item;
        double somaItens = 0.0;
        int quantidadeDeItens;
        int contador = 0;
        System.Console.WriteLine("São quantos itens: ");
        quantidadeDeItens = double.Parse(Console.ReadLine());
        while (contador < quantidadeDeItens)
        {
            somaItens = somaItens + contador;
            System.Console.WriteLine("Digite o valor " + contador + " º item: ");
            somaItens = somaItens + item;
            contador++
        }
        if
        {
            System.Console.WriteLine("Parabens Voce ganhou frete gratis em sua compra de valor " + somaItens);
        }
        else        
        {
            System.Console.WriteLine("A compra não possui frete gratis");
        }
    }*/
}