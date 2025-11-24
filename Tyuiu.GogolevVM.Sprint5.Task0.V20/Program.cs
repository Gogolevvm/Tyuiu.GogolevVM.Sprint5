using Tyuiu.GogolevVM.Sprint5.Task0.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int x = 2;
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Гоголев В.М | АСОиУБ-25-1";
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* Спринт #5                                                                                *");
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                                         *");
        Console.WriteLine("* Задание #0                                                                               *");
        Console.WriteLine("* Вариант #20                                                                              *");
        Console.WriteLine("* Выполнил: Гоголев Вcеволод Михайлович | АСОиУБ-25-1                                      *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
        Console.WriteLine("* Дано выражение F(x) = 2.12x^3 + 1.05*x^2 + 4.1*x * 2, вычислить его значение             *");
        Console.WriteLine("* при x = 2, результат сохранить в текстовый файл OutPutFileTask0.txt и вывести на консоль.*");
        Console.WriteLine("*                                                                                          *");

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