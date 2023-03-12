namespace ListaExercicios01.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1 - Exercício 3");

            Console.WriteLine("Digite o raio do cilindro: ");
            decimal raio = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a altura do cilindro: ");
            decimal altura = Convert.ToDecimal(Console.ReadLine());

            decimal pi = 3.14m;
            decimal resultado = pi * (raio * raio) * altura;

            Console.WriteLine($"O volumo do cilindro é {resultado}");
        }
    }
}