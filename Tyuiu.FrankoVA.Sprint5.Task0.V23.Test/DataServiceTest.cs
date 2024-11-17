using System.Diagnostics;
using Tyuiu.FrankoVA.Sprint5.Task0.V23.Lib;
using System.IO;
namespace Tyuiu.FrankoVA.Sprint5.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test()
        {
            string path = @"C:\Пользователи\1\source\repos\Tyuiu.FrankoVA.Sprint5\Tyuiu.FrankoVA.Sprint5\Tyuiu.FrankoVA.Sprint5.Task0.V23\bin\Debug\OutOutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileInfo.Exists);
        }
    }
}