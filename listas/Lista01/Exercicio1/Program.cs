using System;

class Program
{
    
    public static void Main (string[] args)
    /*1. Você está fazendo um teste prático para conseguir um estágio em uma empresa de desenvolvimento 
    de sistemas.
    O teste pede para que você faça o seguinte:Crie um programa na linguagem C# que calcule a média de 
    um aluno de uma escola. Seu programa deve receber as 4 notas do aluno e extrair a média das 4 notas 
    usando a seguinte fórmula:media = (nota1 + nota2 + nota3 + nota4) / 4.0Ao final, seu programa deve 
    exibir a mensagem: “A media do aluno eh: x“ Exemplo de entrada:
        ●	6.2
        ●	7.3
        ●	3.5
        ●	3.7

    Saída esperada:
        ●	A media do aluno eh: 5.175

    ⚠️Dica importante: Se o resultado da média estiver dando um valor errado, tente utilizar a vírgula 
    como separador de casas decimais. Caso dê errado mesmo assim, tente aparecer em uma monitoria para 
    que um monitor consiga te auxiliar.
    */

    {
        Console.WriteLine("A 1ª nota: ");
        double nota1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("A 2ª nota: ");
        double nota2 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("A 3ª nota: ");
        double nota3 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("A 4ª nota: ");
        double nota4 = double.Parse(Console.ReadLine());
        
        double mediaNota = (nota1 + nota2 + nota3 + nota4) / 4;
        Console.WriteLine("A média do aluno é: " + mediaNota);
    }
}