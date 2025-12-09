using Tyuiu.GogolevVM.Sprint5.Task7.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask7.txt";
        string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7.txt";

        Console.WriteLine("Данные находятся в файле: " + path);

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("Находится в файле: ");
        pathSaveFile = ds.LoadDataAndSave(path);
        Console.WriteLine(pathSaveFile);
    }
}