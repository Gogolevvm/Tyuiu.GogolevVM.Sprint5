using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GogolevVM.Sprint5.Task1.V26.Lib
{
    public class DataService : ISprint5Task1V26
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = ((2 * x + 6 / (Math.Cos(x) + x)) - 3);
                if  (Math.Cos(x) + x == 0)
                {
                    y = 0;
                    strY = Convert.ToString(y);
                }
                else
                {
                    y = Math.Round(y,2);
                    strY = Convert.ToString(y);
                }
                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }

            }
            return path;
         
        }
    }
}
