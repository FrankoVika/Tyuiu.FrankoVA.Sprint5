using System.IO;
using Tyuiu.FrankoVA.Sprint5.Task2.V28.Lib;
namespace Tyuiu.FrankoVA.Sprint5.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Пользователи\1\source\repos\Tyuiu.FrankoVA.Sprint5\Tyuiu.FrankoVA.Sprint5\Tyuiu.FrankoVA.Sprint5.Task1.V27\bin\Debug\OutOutFileTask1.txt";
            string tempPath = Path.GetTempPath();


            string fileName = "OutOutFileTask0.txt";
            string p = Path.Combine(tempPath, fileName);

            FileInfo fileInfo = new FileInfo(path);


            bool fileExists = fileInfo.Exists;


            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}