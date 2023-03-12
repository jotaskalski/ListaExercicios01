namespace ListaExercicios01.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1 - Exercício 1");
            
            Console.WriteLine("Digite a altura da caixa: ");
            decimal altura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o comprimento da caixa: ");
            decimal comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a largura da caixa: ");
            decimal largura = Convert.ToDecimal(Console.ReadLine());

            decimal volume = altura * comprimento * largura;

            Console.WriteLine($"O volume da caixa é {volume}");
            Console.Read();
        }
    }
}