namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1 - Exercício 7");

            Console.Write("Informe o salário base: ");
            decimal salario = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o total de vendas: ");
            int vendas = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o percentual da comissão do vendedor: ");
            decimal comissao = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"O salário total do vendedor é {salario + (vendas * comissao)} ");

        }
    }
}