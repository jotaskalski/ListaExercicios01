namespace Exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1 - Exercício 24");

            int numerosImpares = 0;

            for (int i = 1; i <= 500; i += 2)
            {
                if (i % 3 == 0)
                {
                    numerosImpares += i;
                    Console.WriteLine($"{numerosImpares}");
                }
            }
        }
    }
}