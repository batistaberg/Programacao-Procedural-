using System;

class Program
{
    static void Main(string[] args)
    {
        string usuario = "admin";
        string senha = "123senha";
        int contador = 1;
        do
        {
            System.Console.WriteLine("Informe seu usuario: ");
            string respostaUsuario = Console.ReadLine();
            System.Console.WriteLine("Informe sua senha: ");
            string respostaSenha = Console.ReadLine();
            if (respostaUsuario == usuario && respostaSenha == senha)
            {
                System.Console.WriteLine("Login realizado com sucesso");
                break;
            }
            else
            {
                System.Console.WriteLine("Digitar a senha novamente");
            }
            contador++;
        System.Console.WriteLine("Sua conta foi bloqueada");
        }
        while (contador <= 3);
    }
}