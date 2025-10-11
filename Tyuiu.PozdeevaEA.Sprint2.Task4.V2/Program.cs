using Tyuiu.PozdeevaEA.Sprint2.Task4.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Поздеева Е. А. | ПКТб-25-1";
      
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Тернарный оператор                                                *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил: Поздеева Елизавета Александровна | ПКТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение                *");
        Console.WriteLine("* с использованием тернарного оператора, где пользователь вводит          *");
        Console.WriteLine("* значение переменных х,у с клавиатуры, если x > y + 3 ,                  *");
        Console.WriteLine("* то  z = x + (x + 1)/y иначе ((y + 5)/(y + 2))                           *");
        Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение переменной X: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной Y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        double res = ds.Calculate(x,y); 

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Значение функции = " + res);
        Console.ReadKey();
    }
}