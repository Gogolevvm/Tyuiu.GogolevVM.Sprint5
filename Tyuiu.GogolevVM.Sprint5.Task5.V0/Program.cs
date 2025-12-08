using Tyuiu.GogolevVM.Sprint5.Task5.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        string path = @"C:\Users\Home\source\repos\Tyuiu.GogolevVM.Sprint5\Tyuiu.GogolevVM.Sprint5.Task5.V0\bin\Debug\InPutFileTask5.txt";
        Console.WriteLine("Данные находятся в файле: " + path);

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        double res = ds.LoadFromDataFile(path);
        Console.WriteLine("Сумма элементов файла = " + res);

 
    }
}