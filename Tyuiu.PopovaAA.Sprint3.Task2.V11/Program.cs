using Tyuiu.PopovaAA.Sprint3.Task2.V11.Lib;
namespace Tyuiu.PopovaAA.Sprint3.Task2.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                 *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                             *");
            Console.WriteLine("* Задание #2                                                                *");
            Console.WriteLine("* Вариант #11                                                               *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу используя цикл do-while, которая вычисляет сумму ряда  *");
            Console.WriteLine("* по формуле, при x=0,5                                                     *");
            Console.WriteLine("*     15           i                                                        *");
            Console.WriteLine("* S =  E  (1/3+x^i)                                                         *");
            Console.WriteLine("*     i=1                                                                   *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            double value = 0.5;
            int startValue = 1;
            int stopValue = 15;

            Console.WriteLine("Переменная x = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
