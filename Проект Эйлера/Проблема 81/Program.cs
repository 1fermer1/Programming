using System;
using System.IO;
using System.Linq;

namespace Проблема_81
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[][] matrix = new int[80][];
            int iter = 0;
            StreamReader f = new StreamReader("C:\\matrix.txt");
            while (!f.EndOfStream)
            {
                string s = f.ReadLine();
                int[] temp = new int[80];
                string[] s_temp = s.Split(",");
                for (int i = 0; i < 80; i++)
                {
                    temp[i] = int.Parse(s_temp[i]);
                }
                matrix[iter] = temp;
                iter++;
            }
            f.Close();

            for (int i = 1; i < 80; i++)
            {
                matrix[0][i] += matrix[0][i - 1];
            }
            for (int i = 1; i < 80; i++)
            {
                matrix[i][0] += matrix[i - 1][0];
            }
            for (int i = 1; i < 80; i++)
            {
                for (int j = 1; j < 80; j++)
                {
                    matrix[i][j] += matrix[i - 1][j] < matrix[i][j - 1] ? matrix[i - 1][j] : matrix[i][j - 1];
                }
            }
            Console.WriteLine(matrix[79][79]);
        }
    }
}
