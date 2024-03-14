using System;

class Program
{
  static void Main (string[] args)
  {
    Console.WriteLine("Digite sua idade: ");
    int idade = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite sua altura: ");
    double altura = double.Parse(Console.ReadLine());    
    Console.WriteLine("Sua idade é: " + idade + " e sua altura é:" + altura);

  }
}