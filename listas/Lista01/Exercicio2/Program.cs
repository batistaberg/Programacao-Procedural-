using System;

class Program
{
    
    public static void Main (string[] args)
    /*2.	Na segunda etapa de seu teste prático para a vaga de estágio, seu avaliador pediu para que você 
    criasse um programa capaz de calcular a área de um triângulo e validar quando ela é maior que 20.
    Nas palavras dele:  
    Você deve criar um programa na linguagem C# que receba a base e a altura de um triângulo e calcule sua área. Ao final, seu programa deve ser capaz de imprimir a mensagem:  
    “A área do triângulo é maior que 20? False/True” 
    OBS: lembrando que os valores “False” e “True” são do tipo bool e serão obtidos ao comparar a área do triângulo com o valor 20; 
    Fórmula da área do Triângulo: 
        area = (baseTriangulo * alturaTriangulo) / 2 
    Exemplo de entrada: 
        ●	7.2  
        ●	6.3    
    Saída esperada: 
        ●	“A area do triangulo eh maior que 20? True”
    Exemplo de entrada:  
        ●	5.6   
        ●	4.7   
    Saída esperada:
        ●	“A area do triangulo eh maior que 20? False”
        */
    {
        Console.WriteLine("Informe a base do triangulo: ");
        double alturaTriangulo = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Informe a altura do triangulo: ");
        double baseTriangulo = double.Parse(Console.ReadLine());
        
        double area = (alturaTriangulo * baseTriangulo) / 2.0;
        Console.WriteLine(area);
        bool areaTriangulo = area > 20;

        Console.WriteLine("A área do triangulo é maior que 20? " + areaTriangulo);
    }
}