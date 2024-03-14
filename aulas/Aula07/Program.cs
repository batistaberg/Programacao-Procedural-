using System;

class Program
{
    static void Main(string[] args)
    /*{
        const int NUMERO_JOGADORES = 5;
        double somatorioAltura = 0;
        double maiorAltura = 0;
        for (int contador = 1; contador <= NUMERO_JOGADORES; contador++)
        {
            System.Console.WriteLine("Digite a altura do " + contador + "º jogador");
            double alturaJogadorAtual = double.Parse(Console.ReadLine());
            somatorioAltura = somatorioAltura +alturaJogadorAtual;
            if (alturaJogadorAtual > maiorAltura)
            {
                maiorAltura = alturaJogadorAtual;
            }
        }
        double alturaMediaDoTime = somatorioAltura / NUMERO_JOGADORES;
        System.Console.WriteLine("A altura média de altura do time eh: " + Math.Round(alturaMediaDoTime, 2));
        System.Console.WriteLine("A pessoa com maior altura do time: " + Math.Round(maiorAltura, 2) + "m");
    }*/
    //Exercício: Crie um programa que receba do usuário um número inteiro e imprima na tela a tabuada daquele número.
    {
        System.Console.WriteLine("Digite a Tabuada que gostaria de calcular: ");
        int valorRecebido = int.Parse(Console.ReadLine());
        for(int contador = 1; contador <= 10; contador++)
        {
            System.Console.WriteLine( valorRecebido + " X " + contador + " = " + valorRecebido * contador);
        }
    }
    /*{
        for (int contador = 10; contador <= 0; contador++)
        {
            System.Console.WriteLine(contador);
        }
    }*/
    /*{
        System.Console.WriteLine("Primeiro Laco");
        for (int contador = 10; contador >= 0; contador -= 3)
        {
            System.Console.WriteLine(contador);
        }
        System.Console.WriteLine("\nSegundo Laço");
        for (int contador = 10; contador >= 0; contador -= 2)
        {
            System.Console.WriteLine(contador);
        }
    }*/
    /*{
        //for (/*instrucao 1; instrucao 2; instrucao 3)
        //for (int contador = 10; contador >= 0; contador -= 3)
        //for (int contador = 0; contador <= 10; contador += 3)
        //for (int contador = 0; contador <= 10; contador++)
        //for (int contador = 10; contador >= 0; contador--)
        /*{
            System.Console.WriteLine(contador);
        }
    }*/
    /*{
        const string RESPOSTA_CORRETA = "Karpov";
        const int PONTUACAO_INICIAL = 100;
        const int NUMERO_MAXIMO_TENTATIVAS = 3;
        int contadorTentativas = 1;
        string respostaUsuario;
        do
        {
            System.Console.WriteLine("\n[Dica] - Foi campeão mundial de xadrez");
            System.Console.WriteLine("Digite o valor do campo: ");
            string respostaUsuario = Console.ReadLine();
        }
        while (respostaUsuario != RESPOSTA_CORRETA && contadorTentativas++ <= NUMERO_MAXIMO_TENTATIVAS);
        if (contadorTentativas > NUMERO_MAXIMO_TENTATIVAS)
        {
            System.Console.WriteLine("Gameover...");
        }
        else
        {
            double pontuacaoFinal = PONTUACAO_INICIAL / contadorTentativas;
            System.Console.WriteLine("Voce acertou!! ");
        }
    }*/
    /*{
        const string RESPOSTA_CORRETA = "Karpov";
        const int PONTUACAO_INICIAL = 100;
        const int NUMERO_MAXIMO_TENTATIVAS = 3;
        int contadorTentativas = 1;
        do
        {
            System.Console.WriteLine("\n[Dica] - Foi campão mundial de xadrez");
            System.Console.WriteLine("Digite o valor do campo: ");
            string respostaUsuario = Console.ReadLine();
            if (respostaUsuario == RESPOSTA_CORRETA)
            {
                double pontuacaoFinal = PONTUACAO_INICIAL / contadorTentativas;
                System.Console.WriteLine("Voce Acertou!! A sua pontuacao foi: " + pontuacaoFinal);
                break;
            }
            contadorTentativas++;
        }
        while (contadorTentativas <= NUMERO_MAXIMO_TENTATIVAS);
        if (contadorTentativas > NUMERO_MAXIMO_TENTATIVAS)
        {
            System.Console.WriteLine("Gameover...");
        }
    }*/ 
    /*{
        int contador = 0;
        while (contador <= 10)
        {
            if (contador > 7)
            {
                break;
                //break serve para parar laço de repetição
            }
            System.Console.WriteLine("Contador = " + contador);
            contador++;
        }
    }*/
    //Exercício: Crie um programa que some os números ímpares digitados até o somatório seles seja maior que 50 (números pares não devem entrar no somatório).
    /*{
        int somatorio = 0;
        int valorInserido = 0;
        do
        {
            if (valorInserido % 2 !=0)
            {
                somatorio = somatorio + valorInserido;
            }
            System.Console.WriteLine("Digite o valor que deseja inserir: ");
            valorInserido = int.Parse(Console.ReadLine());
        }
        while(somatorio <= 50);
        System.Console.WriteLine("O somatório dos valores impares eh: " + somatorio);
    }*/
    /*{
        double somatorio = 0;
        double valorInserido = 0;
        do
        {
            somatorio = somatorio + valorInserido;
            System.Console.WriteLine("Digite o valor que deseja doar: ");
            valorInserido = double.Parse(Console.ReadLine());
        }
        while (valorInserido >= 0);
        System.Console.WriteLine("O valor arrecadado foi: " + Math.Round(somatorio, 2));        
    }*/
    /*{
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
    /*{
        int numero = 10;
        System.Console.WriteLine(numero + 1);
        numero++;
        System.Console.WriteLine(numero);
    }*/
    /*{
        int numero = 10;
        numero++;
        System.Console.WriteLine(numero);
    }*/
}