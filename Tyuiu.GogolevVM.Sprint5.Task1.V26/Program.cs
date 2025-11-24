using Tyuiu.GogolevVM.Sprint5.Task1.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();



        int startvalue = -5;
        int endvalue = 5;
        double[] valleyArray;
        int len = (endvalue - startvalue) + 1;
        valleyArray = new double[len];
        double y;
        int count = 0;

        for (int i = startvalue; i <= endvalue; i++)
        {
            if ((Math.Cos(i) + i) != 0)
            {
                y = Math.Round((((2 * i + 6) / (Math.Cos(i) + i)) - 3), 2);
            }
            else
            {
                y = 0;
            }
            valleyArray[count] = y;
            count++;
        }

        Console.Title = "Спринт #5 | Выполнил: Гоголев В.М | АСОиУБ-25-1";
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* Спринт #5                                                                                *");
        Console.WriteLine("* Тема:#5.1 Класс File. Запись набора данных в текстовый файл                              *");
        Console.WriteLine("* Задание #1                                                                               *");
        Console.WriteLine("* Вариант #26                                                                              *");
        Console.WriteLine("* Выполнил: Гоголев Вcеволод Михайлович | АСОиУБ-25-1                                      *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
        Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции (произвести табулирование)  *");
        Console.WriteLine("* F(x) = 2x + 6 / (cos(x) + x - 3)  на диапазоне [-5;5] с шагом 1                          *");
        Console.WriteLine("*                                                                                          *");

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        Console.WriteLine("Старт шага = " + startvalue);
        Console.WriteLine("Конец шага" + endvalue);

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");
        
        string result = ds.SaveToFileTextData(startvalue, endvalue);

        Console.WriteLine("+---------+-----------+");
        Console.WriteLine("|    X    |   f(X)    |");
        Console.WriteLine("+---------+-----------+");

        for (int i = 0; i < 11; i++)
        {
            Console.WriteLine("|{0,5:d}    |  {1,6:f2}   |", startvalue, valleyArray[i]);
            startvalue++;
        }

        Console.WriteLine("+---------+-----------+");



        Console.WriteLine("Файл " + result);
        Console.WriteLine("Создан");
    }


    }
