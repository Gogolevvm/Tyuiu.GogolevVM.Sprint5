using Tyuiu.GogolevVM.Sprint5.Task6.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds  = new DataService();

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask6.txt";
        Console.WriteLine("Данные находятся в файле: " + path);


        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);
    }
}