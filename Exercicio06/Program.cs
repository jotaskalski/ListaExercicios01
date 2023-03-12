namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1 - Exercício 6");

            Console.WriteLine("Informe a temperatura em Celcius: ");
            decimal celcius = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = Convert.ToDecimal(celcius * 1.8m + 32);

            Console.WriteLine($"A temperatura em Fahrenheit é: {resultado}");
            Console.ReadLine();
        }
    }
}