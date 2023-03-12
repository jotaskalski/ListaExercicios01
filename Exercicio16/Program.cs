namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1 - Exercício 16");

            Console.WriteLine("Informe o seu salário ");
            double salario = double.Parse(Console.ReadLine());

            double salarioAumento = salario + (salario * 0.15);
            double salarioImposto = salarioAumento - (salarioAumento * 0.08);


            Console.WriteLine($"Salário Inicial: {salario}, salário com aumento: {salarioAumento}, salario com Imposto: {salarioImposto}");
        }
    }
}