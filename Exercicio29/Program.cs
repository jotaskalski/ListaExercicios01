namespace Exercicio29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1 - Exercício 29");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int resultado = i * j;
                    (string formatoNum1, string formatoNum2, string resultadoMult) = FormatarNumeros(i, j, resultado);

                    Console.Write($" {formatoNum1} x {formatoNum2} = {resultadoMult} \t");
                }
            }
            Console.ReadLine();

        }
        public static (string, string, string) FormatarNumeros(int num1, int num2, int resultado)
        {
            string strNum1 = num1 < 10 ? $"0{num1}" : num1.ToString();
            string strNum2 = num2 < 10 ? $"0{num2}" : num2.ToString();
            string resultadoMult = resultado < 10 ? $"0{resultado}" : resultado.ToString();

            return (strNum1, strNum2, resultadoMult);
        }
    }
}