using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        string content = File.ReadAllText(@"C:\DataSprint5\InPutDataFileTask4V0.txt");
        content = content.Replace('h','#');
        Console.WriteLine(String.Join("\n",content));


    }
}