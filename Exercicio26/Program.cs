namespace Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1 - Exercício 26");

            int resultado = 1; 

            Console.WriteLine("Informe um número para o cálculo fatorial");
            int numero = int.Parse(Console.ReadLine());

            for (int i = numero; i >= 1; i--)
            {
                Console.Write(i);
                resultado *= i;

                if (i > 1)
                {
                    Console.Write("x");
                }
            }

            Console.Write($" = {resultado}");
            Console.ReadLine();
        }
    }
}