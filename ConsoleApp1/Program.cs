using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        int[,] array = { { -5,7,-4 }, {10,-12,-4 }, {14,8,3} };
        int rowSum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum -= array[0,j];
        }

        File.WriteAllText("OutPutFileTask2.csv", rowSum.ToString());



    }
}