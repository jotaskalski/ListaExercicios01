namespace ListaExercicio01.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1 - Exercício 4");

            Console.WriteLine("Digite a quilometragem inicial: ");
            int kmInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quilometragem no fim do percurso: ");
            int kmFinal = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o consumo de combustível por quilômetro:");
            decimal consumo = Convert.ToDecimal(Console.ReadLine());

            int distancia = kmFinal - kmInicial;
            decimal gasto = distancia / consumo;
            Console.WriteLine($"O consumo de combustível por quilômetro foi: {gasto} litros/km");
            Console.ReadLine();
        }
    }
}