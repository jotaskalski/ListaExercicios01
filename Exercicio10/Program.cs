namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1 - Exercício 10");

            Console.Write("Digite a primeira nota:  ");
            decimal primeiraNota = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a segunda nota:  ");
            decimal segundaNota = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o peso da primeira nota:  ");
            decimal primeiroPeso = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o peso da segunda nota:  ");
            decimal segundoPeso = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = ((primeiraNota * primeiroPeso) + (segundaNota * segundoPeso)) / (primeiroPeso + segundoPeso);

            Console.WriteLine($"A média ponderada do aluno é: {resultado}");
        }
    }
}