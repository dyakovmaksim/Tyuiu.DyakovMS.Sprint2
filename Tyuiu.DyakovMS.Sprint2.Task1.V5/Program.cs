using Tyuiu.DyakovMS.Sprint2.Task1.V5.Lib;
namespace Tyuiu.DyakovMS.Sprint2.Task1.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Логические операции                                                     *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #5                                                            *");
            Console.WriteLine("* Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=, последова*");
            Console.WriteLine("*ательность можно чередовать, но использовать один раз в выражении) и логи*");
            Console.WriteLine("*ических операций (|, &, ||, &&, !, ^, последовательность операций не долж*");
            Console.WriteLine("*жна нарушаться), а также арифметических выражений, которая вернет логичес*");
            Console.WriteLine("*скую последовательность(массив): (True, False, False, False, True, False)*");
            Console.WriteLine("*), при a = 154, b = 163, c = 134, d = 137.                               *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("a = 154, b = 163, c = 134, d = 137");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.GetLogicOperations(154, 163, 134, 137);
            Console.WriteLine(String.Join(", ", result));
            Console.ReadKey();
        }
    }
}