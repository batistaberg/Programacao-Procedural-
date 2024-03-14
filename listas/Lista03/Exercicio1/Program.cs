using System;

class Program
{
    static void Main(string[] args)
    {
        const int NUMERO_HABITANTES = 20;
        double somatorioSalario = 0;
        double somatorioFilhos = 0;
        double maiorSalario = 0;
        for (int contador = 1; contador <= NUMERO_HABITANTES; contador++)
        {
            System.Console.WriteLine("Digite o salario do " + contador + "º habitante");
            double salarioHabitanteAtual = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a quantidade de filhos do " + contador + "º habitante");
            double filhosHabitanteAtual = double.Parse(Console.ReadLine());
            somatorioSalario = somatorioSalario + salarioHabitanteAtual;
            somatorioFilhos = somatorioFilhos + filhosHabitanteAtual;
            if (salarioHabitanteAtual > maiorSalario)
            {
                maiorSalario = salarioHabitanteAtual;
            }
        }
        double salarioMedioDaPopulacao = somatorioSalario / NUMERO_HABITANTES;
        double filhosMediaDaPopulacao = somatorioFilhos / NUMERO_HABITANTES;
        System.Console.WriteLine("A media de salario da populacao eh: R$" + Math.Round(salarioMedioDaPopulacao, 2));
        System.Console.WriteLine("A media de filhos por habitante eh: " + Math.Round(filhosMediaDaPopulacao, 2) + " filhos");
        System.Console.WriteLine("O maior salario da cidade eh: R$" + Math.Round(maiorSalario, 2));
    }
}