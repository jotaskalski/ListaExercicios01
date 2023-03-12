namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1 - Exercício 13");

            double pao = 0.12;
            double broa = 1.50;
            double poupanca = 0.1;

            Console.WriteLine("Informe a quantidade de pães vendidados");
            double quantidadePao = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de broa vendidadas");
            double quantidadeBroa = int.Parse(Console.ReadLine());

            decimal quantidadeArrecadado = Convert.ToDecimal(quantidadePao * pao + quantidadeBroa * broa);

            double quantidadePoupanca = Convert.ToDouble(quantidadeArrecadado) * poupanca;

            Console.WriteLine($" O valor arrecadada nas vendas foram {quantidadeArrecadado} reais, e para poupança foi {quantidadePoupanca} reais");
        }
    }
}