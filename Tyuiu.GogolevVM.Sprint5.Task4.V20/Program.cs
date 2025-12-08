using Tyuiu.GogolevVM.Sprint5.Task4.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask4V0.txt";
        Console.WriteLine("Данные находятся в файле: " + path);

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");
        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);



    }
}