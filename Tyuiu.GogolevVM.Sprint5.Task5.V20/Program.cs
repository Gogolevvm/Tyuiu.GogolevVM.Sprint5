using Tyuiu.GogolevVM.Sprint5.Task5.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Гоголев В.М | АСОиУБ-25-1";
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* Спринт #5                                                                                *");
        Console.WriteLine("* Тема: Чтение набора данных из текстового файла                                           *");
        Console.WriteLine("* Задание #5                                                                               *");
        Console.WriteLine("* Вариант #20                                                                              *");
        Console.WriteLine("* Выполнил: Гоголев Вcеволод Михайлович | АСОиУБ-25-1                                      *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
        Console.WriteLine("* Создать папку в ручную С:\\DataSprint5\\ и скопировать в неё файл) в котором есть        *");
        Console.WriteLine("* набор значений. Найти среднее значение всех целых чисел в файле, которые находятся       *");
        Console.WriteLine("* Полученный результат вывести на консоль. У вещественных значений округлить до 3-x знаков *");



        
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");
        string path = @"C:\DataSprint5\InPutDataFileTask5V20.txt";
        Console.WriteLine("Данные находятся в файле: " + path);

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        double res = ds.LoadFromDataFile(path);
        Console.WriteLine("Сумма элементов файла = " + res);

    }
}