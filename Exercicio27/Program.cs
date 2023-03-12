namespace Exercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1 - Exercício 27");

            Console.WriteLine("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());

            int a = 0, b = 1, auxiliar, numeroAnterior = 0;

            while (a <= numero)
            {
                Console.Write(a + " ");

                auxiliar = a + b;
                a = b;
                b = auxiliar;

                if (auxiliar > numero)
                {
                    break;
                }

                numeroAnterior = a;
            }

            if (numeroAnterior < numero)
            {
                Console.Write(a);
                Console.ReadLine();
            }


        }
    }
}