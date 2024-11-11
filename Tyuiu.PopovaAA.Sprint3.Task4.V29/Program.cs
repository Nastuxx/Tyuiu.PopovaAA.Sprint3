using Tyuiu.PopovaAA.Sprint3.Task4.V29.Lib;
namespace Tyuiu.PopovaAA.Sprint3.Task4.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                 *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                  *");
            Console.WriteLine("* Задание #4                                                                *");
            Console.WriteLine("* Вариант #29                                                               *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение       *");
            Console.WriteLine("* функции y=cos(x)/x. При х = 0 пропустить значение. Полученные значения    *");
            Console.WriteLine("* суммировать.                                                              *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
