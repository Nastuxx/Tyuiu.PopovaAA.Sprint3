using Tyuiu.PopovaAA.Sprint3.Task3.V9.Lib;
namespace Tyuiu.PopovaAA.Sprint3.Task3.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                 *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                              *");
            Console.WriteLine("* Задание #3                                                                *");
            Console.WriteLine("* Вариант #9                                                                *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Используя цикл foreach заменить цифры на букву w в строке: 56hy vfe4r4    *");
            Console.WriteLine("* vf45b                                                                     *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            string str = "56hy vfe4r4 vf45b";
            char chr = 'c';

            Console.WriteLine("Исходная строка: " + str);

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Замененная строка: " + ds.ReplaceNumOnChar(str, chr));

            Console.ReadKey();
        }
    }
}
