using System;

class Program
{
    //crie un programa que peça para uma pessoa digitar seu nome e seu salário,
    //armazene em variáveis e ao final imprima a mensagem "Seu nome é " + nome +
    //"Seu salário é: " + salario.
  static void Main (string[] args)
  {
    Console.WriteLine("Digite seu nome: ");
    string nome = string.Parse(Console.ReadLine());
    Console.WriteLine("Digite seu salário: ");
    double salario = double.Parse(Console.ReadLine());    
    Console.WriteLine("Seu nome é: " + nome + " e seu salário é:" + salario);

  }
}