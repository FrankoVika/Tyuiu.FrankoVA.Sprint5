using System.Text;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FrankoVA.Sprint5.Task7.V20.Lib
{
    public class DataService : ISprint5Task7V20
    {
        public string LoadDataAndSave(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            string paths = Path.Combine(Path.GetTempPath(), "DataSprint5", "OutPutDataFileTask7V20.txt");



            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    line = line.Replace("Сс", "С").Replace("сс", "с");



                    File.WriteAllText(paths, line);
                }
            }

            return path;
        }
    }
}

