using Tyuiu.PozdeevaEA.Sprint2.Task1.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int a = 242;
        int b = 155;
        int c = 456;
        int d = 17;

        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);

        Console.Title = "Спринт #2 | Выполнил: Поздеева Е. А. | ПКТб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #20                                                             *");
        Console.WriteLine("* Выполнил: Поздеева Елизавета Александровна | ПКТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
        Console.WriteLine("* последовательность можно чередовать, но использовать один раз в         *");
        Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^,                   *");
        Console.WriteLine("* последовательность операций не должна нарушаться), а также              *");
        Console.WriteLine("* арифметических выражений, которая вернет логическую последовательность  *");
        Console.WriteLine("* (массив): (False, False, False, True, True, True),                      *");
        Console.WriteLine("* при a = 242, b = 155, c = 456, d = 17                                   *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("A = " + a);
        Console.WriteLine("B = " + b);
        Console.WriteLine("C = " + c);
        Console.WriteLine("D = " + d);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");



        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);

        }
        Console.ReadKey();
    }
}