namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1 - Exercício 5");

            Console.WriteLine("Digite o raio da esfera: ");
            decimal raio = Convert.ToDecimal(Console.ReadLine());

            decimal pi = 3.14m;
            decimal resultado = Convert.ToDecimal((4.0 / 3.0)) * pi * (raio * raio * raio);
            Console.WriteLine($"O volume da  esfera é {resultado.ToString("F2")}");
        }
    }
}