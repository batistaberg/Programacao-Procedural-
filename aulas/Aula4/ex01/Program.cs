using System;

class Program
{
    static void Main(string[] args)
    /*{
        string nome = null;

        if (nome.// override object.Equals
        public override bool Equals(object obj)
        {
            //
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //
            
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            
            // TODO: write your implementation of Equals() here
            throw new System.NotImplementedException();
            return base.Equals (obj);
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new System.NotImplementedException();
            return base.GetHashCode();
        }"Berg")
        {

        }
    }*/
    /*{
        int idade;
        {
            idade = 15;
            Console.WriteLine("Voce desbloqueou uma area secreta!");
        }
    }
    static void MinhaFuncao()
    {
        
    }*/
    /*{
        Console.WriteLine("Digite o cheat code: ");
        string cheatCode = Console.ReadLine();
        if(cheatCode == "codigo ultra secreto")
        {
            Console.WriteLine("Voce desbloqueou uma area secreta!");
        }
    }*/
    /*{
        if (1 == 1) //só exibe a resposta se ela for verdadeira
        {
            Console.WriteLine("A condição era verdadeira");
        }
    }*/
    //Crie um programa que pergunte ao usuário se uma lampada está ligada (use uma variável bool). Se a lampada estiver ligada o 
    //programa deve desligar a lampada e exibir a mensagem “Lampada ligada”? False”. Se a lampada estiver desligada o programa 
    //deve ligar a lampada e exibir a mensagem “Lampada ligada? True”.
    /*{
        Console.WriteLine("A lampada esta ligada? ");
        bool estaLigada = bool.Parse(Console.ReadLine());
        estaLigada = !estaLigada;
        Console.WriteLine("A lampada esta ligada? " + estaLigada);
    }*/
    /*{
        bool estaChovendo = true;
        Console.WriteLine(!estaChovendo);
    }*/
    //Em um país fictício chamado Xurupita apenas podem concorrer à presidência da república pessoas que satisfaçam as 
    //seguintes condições: Deve ter igual ou superior a 30 anos e ter nacionalidade Xurupitense. Além disso, deve ser 
    //graduado em gestão de políticas públicas. Crie um programa que pergunte ao usuário sua idade, sua nacionalidade, 
    //se é graduado em economia e se é graduado em gestão de políticas públicas. Ao final seu programa deve ser capaz 
    //de dizer se essa pessoa pode se candidatar à presidência de Xurupita.
    /*{
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());
        Console.WriteLine("A sua nascionalidade eh xurupintense ");
        bool nacionalidadeXurupitense = bool.Parse(Console.ReadLine());
        Console.WriteLine("Voce possui graduacao em gestao de politicas publicas? ");
        bool graduadoEmGestao = bool.Parse(Console.ReadLine());        
        Console.WriteLine("Voce possui graduacao em economia? ");
        bool graduadoEmEconomia = bool.Parse(Console.ReadLine());        
        bool podeSeCandidatar = (idade >= 30 || nacionalidadeXurupitense) && (graduadoEmEconomia || graduadoEmGestao);
        Console.WriteLine("A pessoa pode se candidatar a presidência?" + podeSeCandidatar);
    }*/
    /*{
        Console.WriteLine("Voce possui o convite? ");
        bool possuiConvite = bool.Parse(Console.ReadLine());
        Console.Write("Digite sua idade ");
        int idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Voce esta acompanhado(a) de um maior de idade?");
        bool estaAcompanhado = bool.Parse(Console.ReadLine());
        bool podeEntrarNaFesta = possuiConvite && (idade >= 18 || estaAcompanhado);
        Console.WriteLine("A pessoa pode entrar na festa?" + podeEntrarNaFesta);
    }*/
    /*{
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine(); 
        bool daAulaNoModuloDois = nome == "Davi" || nome == "Davi";
        Console.WriteLine("O professor: " + nome + " Da aula no módulo 2? " + daAulaNoModuloDois);
    }*/
    /*{
        Console.WriteLine("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite seu sexo: ");
        string sexo = Console.ReadLine();
        bool festaDeDebutante = (sexo == "feminino") && (++idade == 15);
        Console.WriteLine(idade);
        Console.WriteLine("Festa de debutante? " + festaDeDebutante);
    }*/
    //Crie um programa que Receba o sexo e a idade de uma pessoa. Se o sexo for igual a “feminino” e a idade igual a 15, o programa deve 
    //exibir a mensagem “Festa de debutante: True”. Caso contrário deve exibir a mensagem “Festa de debutante: False”.
    {
        Console.WriteLine("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite seu sexo: ");
        string sexo = Console.ReadLine();
        bool festaDeDebutante = (idade == 15) && (sexo == "feminino");
        Console.WriteLine("O resultado Eh?" + festaDeDebutante);
    }
    /*{
        int numero = int.Parse(Console.ReadLine());
        bool ehParEMaiorQueCem = (numero % 2 == 0) && (numero > 100);
        Console.WriteLine("O resultado Eh?" + ehParEMaiorQueCem);
    }*/
    /*{
        int numero = int.Parse(Console.ReadLine());
        bool ehPar = (numero % 2 == 0);
        Console.WriteLine("Eh par?" + ehPar);
    }*/
    /*{
        bool ehPar = (327 % 2 == 0);
    }*/
    /*{
        bool resultado = 1 > 2;
        bool resultado2 = "Mateus" != "Miguel";
    }*/
    /*{
        const double precoDaDuzia = 14.99;
        int quantidadeLaranjas = int.Parse(Console.ReadLine());
        double duzias = quantidadeLaranjas / 12;
        double resto = quantidadeLaranjas % 12;
        double precoFinal = (precoDaDuzia * duzias) + ((resto / 12) * precoDaDuzia);
        Console.WriteLine("O preco final eh: " +precoFinal);
    }*/
}