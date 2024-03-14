using System;

class Program
//2. Um antigo professor seu descobriu que você está estudando programação, e resolveu fazer o clássico pedido “Você pode criar um sistema para 
//mim, é super fácil”
//O sistema que ele te pediu consiste em uma calculadora de média de aluno, mas que deve verificar se o aluno foi aprovado, reprovado ou se está 
//em recuperação. Nas palavras dele: 
//“Eu preciso de um programa que receba as 4 notas de um aluno. O programa deve calcular a média aritmética das notas desse aluno. Após calculada 
//a média o programa deve verificar se o aluno foi aprovado, reprovado ou se está em recuperação”. Os critérios são: 
//Caso a ser verificado	Mensagem a ser exibida
//nota >= 5.0	Aluno aprovado
//nota < 5.0 && nota >= 3.0	Aluno em recuperacao
//nota < 3.0	Aluno reprovado
//Seu programa deve verificar todos os casos descritos pelo professor e ser capaz de fornecer a saída adequada 
//Exemplo de entrada: 
//●	5.0 
//●	2.5 
//●	4.2 
//●	7.2 
//Saída esperada: 
//●	Aluno em recuperacao
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a 1ª nota: ");
        double nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a 2ª nota: ");
        double nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a 3ª nota: ");
        double nota3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a 4ª nota: ");
        double nota4 = double.Parse(Console.ReadLine());
        media = (nota1 + nota2 + nota3 + nota4)/4;
        if (media >= 5.0)
        {
            Console.WriteLine("Aluno aprovado");
        }
        else if (media < 5.0 && media >= 3.0)
        {
            Console.WriteLine("Aluno em recuperacao");
        }
        else
        {
            Console.WriteLine("Aluno reprovado");
        }
    }
}