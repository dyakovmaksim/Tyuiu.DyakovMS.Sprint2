using Tyuiu.DyakovMS.Sprint2.Task2.V12.Lib;
namespace Tyuiu.DyakovMS.Sprint2.Task2.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Оператор if – полная и короткая форма записи                            *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу на, которая запрашивает целые значения с клавиатуры и *");
            Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области*");
            Console.WriteLine("*и.                                                                       *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            var result = ds.CheckDotInShadedArea(x, y);

            if (result)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }

            Console.ReadKey();
        }
    }
}