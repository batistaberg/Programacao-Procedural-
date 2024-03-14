using System;

class Program
{
    static void Main(string[] args)
    /*{
        const double valorBoleto = 100;
        string statusBoleto = Console.ReadLine();
        double valorFinal = (statusBoleto != "vencido") ? valorBoleto : valorBoleto + (valorBoleto * 0.15);
        System.Console.WriteLine("O valor final eh: " + valorFinal);
    }*/
    /*{
        string nome = Console.ReadLine();
        int idade = (nome == "Berg") ? 43 : 17;
    }*/
    /*{
        Console.WriteLine("Escolha um dos paises para visitar:\n[1] - Pais do vento\n[2] - Pais do fogo");
        int paisEscolhido = int.Parse(Console.ReadLine());
        if (paisEscolhido == 1)
        {
            Console.WriteLine("Você escolheu o pais do vento!");
            Console.WriteLine("escolha um ponto de exploracao para visitar: ");
            Console.WriteLine("[1] - Aldeia da areia");
            Console.WriteLine("[2] - Mina");
            Console.WriteLine("[3] - Caatinga");
            int pontoDeExploracao = int.Parse(Console.ReadLine());
            if (pontoDeExploracao == 1)
            {
                System.Console.WriteLine("Bem vindo a Aldeia da Areia");
            }
            else if (pontoDeExploracao == 2)
            {
                System.Console.WriteLine("Aqui fica a mina");
            }
            else
            {
                System.Console.WriteLine("Voce adentrou a Caatinga");
            }
        }
        else if(paisEscolhido == 2)
        {
            Console.WriteLine("Você escolheu o pais do fogo!");
            Console.WriteLine("escolha um ponto de exploracao para visitar: ");
            Console.WriteLine("[1] - Aldeia da folha");
            Console.WriteLine("[2] - Floresta da morte");
            int pontoDeExploracao = int.Parse(Console.ReadLine());
            if (pontoDeExploracao == 1)
            {
                System.Console.WriteLine("Bem vindo a Aldeia da Folha");
            }
            else
            {
                System.Console.WriteLine("Voce entrou na floresta da morte...");
            }
        }
        else
        {
            System.Console.WriteLine("Pais invalido...");
        }
    }*/
    /*{
        string nome = null
    }*/
    //Exercício: Crie um programa que receba a idade de três pessoas e verifique qual é o maior das três idades. Ao final seu programa 
    //deve imprimir a mensagem “A maior das três idades é: x
    /*{
        Console.WriteLine("Digite a idade da pessoa 1: ");
        int idadePessoa1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a idade da pessoa 2: ");
        int idadePessoa2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a idade da pessoa 3: ");
        int idadePessoa3 = int.Parse(Console.ReadLine());
        if (idadePessoa1 > idadePessoa2 && idadePessoa1 > idadePessoa3)
        {
            Console.WriteLine("A maior das tres idades eh: " + idadePessoa1);
        }
        else if (idadePessoa2 > idadePessoa1 && idadePessoa2 > idadePessoa3)
        {
            Console.WriteLine("A maior das tres idades eh: " + idadePessoa2);
        }
        else if (idadePessoa3 > idadePessoa1 && idadePessoa3 > idadePessoa2)
        {
            Console.WriteLine("A maior das tres idades eh: " + idadePessoa3);
        }
        else
        {
            Console.WriteLine("Não há uma maior idade...");
        }
    }*/
    /*{
        const double pesoGalo = 54;
        const double pesoPena = 57;
        const double pesoLeve = 60;
        Console.WriteLine("Digite o peso do lutador: ");
        double pesoLutador = double.Parse(Console.ReadLine());
        if (pesoLutador <= pesoGalo)
        {
            Console.WriteLine("A categoria do lutador é: Galo");
        }
        else if (pesoLutador <= pesoPena)
        {
            Console.WriteLine("A categoria do lutador é: Pena");
        }
        else if (pesoLutador <= pesoLeve)
        {
            Console.WriteLine("A categoria do lutador é: Leve");
        }
        else
        {
            Console.WriteLine("O lutador não esta apto a competir em nenhuma categoria.");
        }
    }*/
    //Execício: O pai de um rapaz deu a ele um cartão de vale presente com saldo de 200.00 reais. Crie um programa que valide se o 
    //presente comprado pelo menino ultrapassa o saldo do vale presente. Se ultrapassar o programa deve exibir a mensagem “Saldo 
    //insuficiente para realizar a compra”. Caso contrário, deve ser exibida a mensagem “Compra realizada com sucesso”.
    /*{
        const double saldo = 200;
        Console.WriteLine("Digite o valor do item que deseja comprar: ");
        double valorCompra = double.Parse(Console.ReadLine());

        if (valorCompra > saldo)
        {
            Console.WriteLine("Saldo insuficiente para realizar a compra!");
        }
        else
        {
            Console.WriteLine("Compra realizada com sucesso.");  
        }
    }*/
    /*{
        Console.WriteLine("Digite um numero inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("O numero eh par.");
        }
        else
        {
            Console.WriteLine("O numero eh impar.");           
        }
    }*/
    //Exercício: Crie um programa que receba um número inteiro do usuário. Seu programa deve ser capaz de verificar se o número é para, 
    //e caso seja, imprimir a mensagem “O número é par”.
    /*{
        Console.WriteLine("Digite um numero inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("O numero eh par.");
        }        
    }*/
    /*{
        Console.WriteLine("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 16)
        {
            Console.WriteLine("Você pode votar");
        }
    }*/
    /*{
        bool resultadoLogico = (1 >= 1) && (1 != 3) && (2 <= 2);
    }*/
    /*{
        && --> Só retorna true quando as duas condições são true.
        || --> Retorna true em todos os casos, menos quando as duas condições são false.
        ! --> 
    }*/
}