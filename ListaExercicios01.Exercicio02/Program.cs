namespace ListaExercicios01.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1 - Exercício 2");

            Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            decimal fahrenheit = Convert.ToDecimal(Console.ReadLine());

            decimal conversao = (fahrenheit - 32) * 5 / 9 ;

            Console.WriteLine($"A temperatura em Celsius é: {conversao}");
            Console.ReadLine();
        }
    }
}