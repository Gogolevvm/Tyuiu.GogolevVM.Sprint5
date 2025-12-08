using Tyuiu.GogolevVM.Sprint5.Task3.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int a = -5;
        int b = 7;
        int c = 11;

        DataService ds = new DataService();
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);


        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        string res = ds.SaveToFileBinaryData(a, b, c);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        
    }
}