namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1 - Exercício 14");

            Console.Write("Digite sua idade ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o seu nome ");
            string nome = Console.ReadLine();

            Console.WriteLine($"{nome}, VOCÊ JÁ VIVEU {idade * 365} dias");
        }
    }
}