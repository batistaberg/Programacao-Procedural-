using System;

{
}

class Program
{

      //crie um programa que receba o nome e o sobrenome de uma pessoa e ao final a cumprimente dizendo "Olá, " nome + sobrenome

  static void Main (string[] args)
  {
    Console.WriteLine ("Digit seu nome de usuário: ");
    string nomeDeUsuario = Console.ReadLine();
    Console.WriteLine("Olá, " + nomeDeUsuario);
  }
}