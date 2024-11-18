using Tyuiu.FrankoVA.Sprint5.Task1.V27.Lib;
namespace Tyuiu.FrankoVA.Sprint5.Task1.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5| Выполнила: Франко В.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнила: Франко В.А. | ИБКСб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение, вычислить его значение при x = 3, результат сохранить в *");
            Console.WriteLine("* текстовый файл OutPutFileTask0.txt и вывести на консоль.                *");
            Console.WriteLine("* Округлить до трёх знаков после запятой                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = -5;
            Console.WriteLine("startValue " + startValue);
            Console.WriteLine("stopValue " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл" + res);
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}
