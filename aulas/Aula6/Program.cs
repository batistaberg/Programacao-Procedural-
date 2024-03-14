using System;

class Program
{
    static void Main(string[] args)
    {
        double somatorio = 0.0;
        string resposta = "s";
        while (resposta == "s")
        {
            System.Console.WriteLine("Digite o valor que deseja doar: ");
            double valorDigitado = double.Parse(Console.ReadLine());
            somatorio = somatorio + valorDigitado;
            System.Console.WriteLine("A vaquinha arrecadou " + somatorio + " até agora");
            System.Console.WriteLine("Deseja continuar?\n[s] - sim\n[n] - nao");
            resposta = Console.ReadLine(); 
        }
        System.Console.WriteLine("Fechamos a vaquinha e o valor arrecadado foi: " + somatorio);
    }
    /*{
        const int VALOR_MAXIMO = 10;
        System.Console.WriteLine("Digite uma tabuada que deseja consultar: ");
        int tabuadaDesejada = int.Parse(Console.ReadLine());
        int contador = 1;
        while (contador <= VALOR_MAXIMO)
        {
            System.Console.WriteLine(tabuadaDesejada + " X " + contador + " = " + (tabuadaDesejada * contador));
            contador++;
        }

    }*/
    /*{
        const int NUMERO_DIAS_EM_JANEIRO = 31;
        int contador = 1;
        while (contador <= NUMERO_DIAS_EM_JANEIRO)
        {
            Console.WriteLine(contador + "º dia de janeiro");
            contador++;
        }
    }*/
    /*{
        const int VALOR_MINIMO = 0;
        int numero = 100;
        while (numero >= VALOR_MINIMO)
        {
            Console.WriteLine(numero);
            numero--;
        }
	}*/   
    //Exercício: Imprimir todos os números de 0 até 100.
    /*{
        const int VALOR_MAXIMO = 100;
        int numero = 0;
        while (numero <= VALOR_MAXIMO)
        {
            Console.WriteLine(numero);
            numero++;
        }
	}*/
    /*{
		Console.WriteLine("digite um numero: ");
		int numero = int.Parse(Console.ReadLine());
		while (numero <= 10)
		{
			System.Console.WriteLine("O numero eh: " + numero);
			numero++;
		}	
		System.Console.WriteLine("Saiu do laço\n");	
	}*/
    /*  {
        Console.WriteLine("Informe sua idade: ");
        int idade = int.Parse(Console.ReadLine());
        //idade++;
        idade += 5;
    }*/
    //Exercício: Uma famosa ótica criou uma promoção baseada na idade de seus clientes. Ela verifica qual a idade da pessoa e desconta do preço do 
    //óculo o equivalente ao valor da idade (em reais). Crie um programa que receba o a idade de uma pessoa e o preço do óculos que ela deseja 
    //comprar. Ao final seu programa deve exibir o preço do óculos descontado do valor da idade.
    /*{
        Console.WriteLine("Informe sua idade: ");
        int idade = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Digite o preço do óculos: ");
        double precoOculos = double.Parse(Console.ReadLine());
        precoOculos = precoOculos - idade;
        System.Console.WriteLine("O preco final eh: "+ precoOculos);
    }*/
    /*{
        int numeroDeAlunos = 18;
        numeroDeAlunos = numeroDeAlunos * 2;
        System.Console.WriteLine(numeroDeAlunos);
    }*/
    /*{
        int numeroDeAlunos = 18;
        numeroDeAlunos = numeroDeAlunos - 5;
        //numeroDeAlunos += numeroDeAlunos 10;
        //numeroDeAlunos += 10;
        System.Console.WriteLine(numeroDeAlunos);
    }*/
    /*{
        int numeroDeAlunos = 18;
        numeroDeAlunos += 10;
        System.Console.WriteLine(numeroDeAlunos);
    }*/
    /*{
        int numeroDeAlunos = 18;
        numeroDeAlunos++;
        numeroDeAlunos++;
        System.Console.WriteLine(numeroDeAlunos);
    }*/
    /*{
        int numeroDeAlunos = 18;
        numeroDeAlunos++;
        System.Console.WriteLine(numeroDeAlunos);
    }*/
    /*{
        int numeroDeAlunos = 18;
        System.Console.WriteLine(numeroDeAlunos);
    }*/
    /*{
        if (false == false)
        {
            Console.WriteLine("O resultado é verdadeiro!");
        }
    }*/
    /*{
        if (1 == 1)
        {
            Console.WriteLine("O resultado é verdadeiro!");
        }
    }*/
}