using System;

class Program
{
    public static void Main (string[] args)

    /*3.	Finalmente você chegou à última etapa do seu teste prático para a sua tão sonhada vaga 
    de estágio. Seu avaliador deseja que você crie um programa que receba um número inteiro que 
    representa uma quantidade de moedas de um centavo.
    Nas palavras dele:Seu programa deve converter os centavos em reais de forma que, ao final, ele 
    apresente a mensagem: 
    “O total em dinheiro eh: x real(is) e y centavo(s)”
    Exemplo de entrada:
        ●	1153
    Saída esperada:
        ●	O total em dinheiro eh: 11 real(is) e 53 centavo(s)
    Exemplo de entrada:
        ●	5932
    Saída esperada:
        ●	O total em dinheiro eh: 59 real(is) e 32 centavo(s)
    */
    {
        Console.WriteLine("Informe a base do triangulo: ");
        double alturaTriangulo = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Informe a altura do triangulo: ");
        double baseTriangulo = double.Parse(Console.ReadLine());
        
        double area = (alturaTriangulo * baseTriangulo) / 2.0;
        Console.WriteLine(area);
        bool areaTriangulo = area > 20;

        Console.WriteLine("A área do triangulo é maior que 20: " + areaTriangulo);
    }
}