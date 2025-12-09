using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GogolevVM.Sprint5.Task5.V20.Lib
{
    public class DataService : ISprint5Task5V20
    {
        public double LoadFromDataFile(string path)
        {
            // Проверка существования файла
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}", path);
            }

            try
            {
                // Читаем все содержимое файла
                string fileContent = File.ReadAllText(path);

                // Удаляем возможные лишние пробелы и разбиваем на элементы
                string[] numberStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' },
                    StringSplitOptions.RemoveEmptyEntries);

                double sum = 0;
                int count = 0;

                foreach (string numStr in numberStrings)
                {
                    // Пытаемся преобразовать строку в число
                    if (double.TryParse(numStr, out double number))
                    {
                        // Проверяем, является ли число целым и находится в диапазоне [-10, 10]
                        if (IsInteger(number) && number >= -10 && number <= 10)
                        {
                            sum += number;
                            count++;
                        }
                    }
                }

                // Если подходящих чисел не найдено
                if (count == 0)
                {
                    return 0;
                }

                // Вычисляем среднее значение
                double average = sum / count;

                // Округляем до 3 знаков после запятой
                return Math.Round(average, 3);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при чтении файла: {ex.Message}", ex);
            }
        }

        // Метод для проверки, является ли число целым
        private bool IsInteger(double number)
        {
            // Проверяем, что разница между числом и его целой частью практически равна 0
            // Используем небольшую погрешность для учета ошибок округления
            return Math.Abs(number - Math.Round(number)) < 0.0000001;
        }
    }
}