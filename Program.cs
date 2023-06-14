using System.Globalization;

namespace LinhasEColunas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Digite quantidade de linhas e colunas");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os numeros a ser inseridos");
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine(" Numeros diagonal:");
            for (int i = 0;i < n; i++)
            {
                Console.WriteLine(mat[i,i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Numeros negativos:" + count);
        }
    }
}