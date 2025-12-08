using Tyuiu.GogolevVM.Sprint5.Task3.V18.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнил: Гоголев В.М | АСОиУБ-25-1";
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* Спринт #5                                                                                *");
        Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                                              *");
        Console.WriteLine("* Задание #3                                                                               *");
        Console.WriteLine("* Вариант #18                                                                              *");
        Console.WriteLine("* Выполнил: Гоголев Вcеволод Михайлович | АСОиУБ-25-1                                      *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
        Console.WriteLine("* Дано выражение, вычислить его значение при x = 2, результат сохранить в бинарный файл   *");
        Console.WriteLine("*  OutPutFileTask3.bin и вывести на консоль. Округлить до 3 знаков после запятой           *");
        Console.WriteLine("*                                                                                          *");

        int x = 2;

        DataService ds = new DataService();
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        Console.WriteLine("x = " + x);




        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        string res = ds.SaveToFileTextData(x);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
    }
}