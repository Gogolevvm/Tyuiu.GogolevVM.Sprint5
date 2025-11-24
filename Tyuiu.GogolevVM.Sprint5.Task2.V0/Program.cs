using Tyuiu.GogolevVM.Sprint5.Task2.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int[,] mtrx = new int[3, 3] { { 0, 1, 0 }, { 10, 10, 1 }, { 0, 1, 1 } };
        int rows = mtrx.GetUpperBound(0) + 1;
        int columns = mtrx.Length / rows;

        DataService ds = new DataService();

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        Console.WriteLine("Массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mtrx[i,j]} \t");
            }

            Console.WriteLine();
        }
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");
        string res = ds.SaveToFileTextData(mtrx);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан");
        
    }
}