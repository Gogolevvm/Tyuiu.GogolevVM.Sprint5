using Tyuiu.GogolevVM.Sprint5.Task0.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int x = -5;

        DataService ds = new DataService();
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        Console.WriteLine("x = " + x);


        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("Файл " + res);
        Console.WriteLine("Создан");

    }
}