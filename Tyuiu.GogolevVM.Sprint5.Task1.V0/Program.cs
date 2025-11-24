using Tyuiu.GogolevVM.Sprint5.Task1.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int startValue = -5;
        int endValue = 5;

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        Console.WriteLine("startValue " + startValue);
        Console.WriteLine("endValue " + endValue);

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        string res = ds.SaveToFileTextData(startValue, endValue);

        Console.WriteLine("Файл " + res);
        Console.WriteLine("Создан");

    }
}