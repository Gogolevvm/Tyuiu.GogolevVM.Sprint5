using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        string outputFile = "OutPutFileTask0.txt";
        double x1 = 3;
        double result = 4 * Math.Pow(x1, 2) - 3 * x1 + 2;  
        File.AppendAllText(outputFile, result.ToString());

    }
}