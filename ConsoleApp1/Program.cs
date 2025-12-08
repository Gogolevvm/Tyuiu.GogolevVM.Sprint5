using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        // Читает весь файл
        string text = File.ReadAllText(@"C:\DataSprint5\InPutDataFileTask4V0.txt");
    //Разделение строки на массив подстрок по символу запятой.

    // Пример: если text = "1, 2, 3, 4", то strings = ["1", " 2", " 3", " 4"]
        string[] strings = text.Split(',');
        // Создание пустого списка строк для хранения результатов.
        List<string> oddNumbers = new List<string>();
        // Цикл перебора каждого элемента массива strings. Переменная str последовательно принимает каждое значение из массива.
        foreach (string str in strings)
        {
            // Условное выражение с двумя проверками: удаляет пробелы в начале и в конце строки, если преобразование успешно, результат сохраняется в переменную number, TryParse возвращает true при успехе, false при неудаче (без исключения)


            if (int.TryParse(str.Trim(), out int number) && number % 3 == 0)
            {
                // Добавление исходной строки
                oddNumbers.Add(str);
            }

        }
        // Запись всех элементов списка в файл, каждый элемент на новой строке.
        File.WriteAllLines(@"C:\DataSprint5\InPutDataFileTask4V0.txt", oddNumbers);
        // создает одну строку, где элементы разделены \n
        Console.WriteLine(String.Join("\n", oddNumbers));

    }
}