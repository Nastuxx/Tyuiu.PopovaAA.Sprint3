using Tyuiu.PopovaAA.Sprint3.Task6.V4.Lib;
namespace Tyuiu.PopovaAA.Sprint3.Task6.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                 *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                  *");
            Console.WriteLine("* Задание #6                                                                *");
            Console.WriteLine("* Вариант #4                                                                *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих         *");
            Console.WriteLine("* числовому отрезку [14, 20] количество всех делителей больше 9             *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            int startValue = 14;
            int stopValue = 20;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + stopValue);

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Количество делителей = " + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
