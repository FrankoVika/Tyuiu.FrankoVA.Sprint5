using System.Text;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FrankoVA.Sprint5.Task7.V20.Lib
{
    public class DataService : ISprint5Task7V20
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);
            string result = text.Replace("Сс", "с").Replace("сс", "с");
            string path2 = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V20.txt");
            File.WriteAllText(path2, result);
            return result;
        }

    }
}
}

