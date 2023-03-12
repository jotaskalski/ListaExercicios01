namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1 - Exercício 12");

            Console.WriteLine("Digite a largura do terreno: ");
            decimal largura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a comprimento do terreno: ");
            decimal comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"A dimensão do terrno é {largura * comprimento} m²");
        }
    }
}