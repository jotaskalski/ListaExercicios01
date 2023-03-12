namespace Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1 - Exercício 25");

            Console.WriteLine("Digite um número para a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"\n {i} x {numero} = {i * numero}");
            }
        }
    }
}