namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1 - Exercício 9");

            List<double> notas = new List<double>();

            Console.Write("Informe o número de notas ");
            int numeroMaxNotas = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroMaxNotas; i++)
            {
                Console.Write("Digite uma nota: ");
                double nota = double.Parse(Console.ReadLine());
                notas.Add(nota);
            }

            double media = 0;

            for (int i = 0; i < numeroMaxNotas; i++)
            {
                media += (1 / notas[i]);
            }

            decimal mediaFinal = Convert.ToDecimal(numeroMaxNotas / media);

            Console.WriteLine($"A media harmônica do aluno é {mediaFinal}");
        }
    }
}