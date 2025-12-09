using Tyuiu.GogolevVM.Sprint5.Task7.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Гоголев В.М | АСОиУБ-25-1";
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* Спринт #5                                                                                *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                  *");
        Console.WriteLine("* Задание #7                                                                               *");
        Console.WriteLine("* Вариант #27                                                                              *");
        Console.WriteLine("* Выполнил: Гоголев Вcеволод Михайлович | АСОиУБ-25-1                                      *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
        Console.WriteLine("*  Создать папку в ручную, в котором есть набор символьных данных.                         *");
        Console.WriteLine("* Удалить все пробелы, идущие подряд больше одного.                                        *");
        Console.WriteLine("********************************************************************************************");

        string path c= @"C:\DataSprint5\InPutDataFileTask7V27.txt";
        string pathSaveFile = ds.LoadDataAndSave(path);
        Console.WriteLine("Данные находятся в файле:" + path);
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("Находятся в файле:");
        pathSaveFile = ds.LoadDataAndSave(path);
        Console.WriteLine(pathSaveFile);
        Console.WriteLine();


    }
}