using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GogolevVM.Sprint5.Task4.V20.Lib
{
    public class DataService : ISprint5Task4V20
    {
        public double LoadFromDataFile(string path)
        {
            double x = 0;
            string strX = File.ReadAllText(path);
            x = double.Parse(strX);

            double res = Math.Pow(((x * x) / Math.Sin(x)), 3);
            res = Math.Round(res,3);
            return res;

        }
    }
}
