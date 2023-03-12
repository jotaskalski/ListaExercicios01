namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1 - Exercício 11");

            Console.WriteLine("Informe o valor");
            int numero = int.Parse(Console.ReadLine());

            bool resultado = verificarPrimo(numero);
            if (resultado)
                Console.WriteLine(numero + " é primo");
            else
                Console.WriteLine(numero + " não é primo");
        }
        public static bool verificarPrimo(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}