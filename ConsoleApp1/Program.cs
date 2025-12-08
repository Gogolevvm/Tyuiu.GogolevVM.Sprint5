using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        double x = 0;
        // Читаем весь текст из файла
        string data = File.ReadAllText(@"C:\Users\Home\source\repos\Tyuiu.GogolevVM.Sprint5\ConsoleApp1\bin\Debug\net8.0\InPutDataFileTAsk4V0.txt");
        // "Превращаем текст в число"
        x = double.Parse(data);
        double result = 4 * Math.Pow(x, 3) - 3 * Math.Pow(x,2) + 2*x-1;
        Console.WriteLine(result);



    }
}