using System;

class Program
{
//1.	Você está trabalhando como estagiário em uma empresa de desenvolvimento de sistemas e sua líder técnica te 
//pediu para desenvolver o protótipo de um sistema de login.
//O protótipo é razoavelmente simples, sua líder descreveu ele da seguinte forma:Crie um programa na linguagem C# 
//que receba o nome de usuario e a senha de uma pessoa. Se o nome de usuário for igual a “admin” e a senha igual a 
//“123senha” seu programa deve exibir a mensagem: “Login realizado com sucesso!”. Caso contrário, seu programa deve 
//exibir a mensagem “Credenciais inválidas…”:Exemplo de entrada:
//●	Juca
//●	123senha
//Saída esperada:
//●	Credenciais invalidas
//Exemplo 2 de entrada:
//●	admin
//●	123senha
//Saída esperada:
//●	Login realizado com sucesso! 
    static void Main(string[] args)
    {
        Console.WriteLine("Digite seu usuario: ");
        string usuario = Console.ReadLine();
        Console.WriteLine("Digite sua senha: ");
        string senha = Console.ReadLine();
        if (usuario = "admin" && senha = "123senha");
        {
            Console.WriteLine("Login realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Credenciais invalidas");
        }
    }
}