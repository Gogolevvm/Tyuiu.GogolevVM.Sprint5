using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GogolevVM.Sprint5.Task7.V27.Lib
{
    public class DataService : ISprint5Task7V27
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask7.txt");
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string resultLine = "";
                    bool inSpaceSequence = false;

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == ' ')
                        {

                            if (!inSpaceSequence)
                            {
                                inSpaceSequence = true;
                            }

                        }
                        else
                        {

                            resultLine += line[i];
                            inSpaceSequence = false;
                        }
                    }

                    File.AppendAllText(pathSaveFile, resultLine + Environment.NewLine);
                }
            }

            return pathSaveFile;
        }
    }
}
