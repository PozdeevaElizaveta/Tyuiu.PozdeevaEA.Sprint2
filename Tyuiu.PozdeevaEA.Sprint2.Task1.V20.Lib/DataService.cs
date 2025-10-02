using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PozdeevaEA.Sprint2.Task1.V20.Lib
{
    public class DataService : ISprint2Task1V20
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a < b) | (c < d);
            res[1] = (b < c) & (d > a);
            res[2] = (c < d) || (a < b);
            res[3] = (b < c) && (d < a);
            res[4] = !res[0];
            res[5] = (c < d) ^ (a > b);

            return res;
        }
    }
}
// Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
// последовательность можно чередовать, но использовать один раз в         *");
// выражении) и логических операций (|, &, ||, &&, !, ^,                   *");
// последовательность операций не должна нарушаться), а также              *");
// арифметических выражений, которая вернет логическую последовательность  *");
// (массив): (False, False, False, True, True, True),                      *");
// при a = 242, b = 155, c = 456, d = 17                                   *");