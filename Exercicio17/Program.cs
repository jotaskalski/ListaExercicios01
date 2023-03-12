namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1 - Exercício 17");

            Console.WriteLine("Informe o valor de A");
            double primeiroValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de B");
            double segundoValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de C");
            double terceiroValor = double.Parse(Console.ReadLine());

            if (primeiroValor + segundoValor > terceiroValor)
            {
                Console.WriteLine("A e B são maiores que C");
            }
            else
            {
                Console.WriteLine("O valor de C é maior que o de A e B");
            }
        }
    }
}