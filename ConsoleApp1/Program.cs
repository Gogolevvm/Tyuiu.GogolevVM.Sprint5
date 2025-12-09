using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        string content = File.ReadAllText(@"C:\DataSprint5\InPutDataFileTask4V0.txt");
        string newcontent = "";
        foreach (char c in content)
        {
            if (!char.IsUpper(c))
            {
                newcontent += c;
            }
        }
        File.WriteAllText(@"C:\DataSprint5\InPutDataFileTask4V0.txt", newcontent);
        Console.WriteLine(String.Join("\n", newcontent));


    }
}