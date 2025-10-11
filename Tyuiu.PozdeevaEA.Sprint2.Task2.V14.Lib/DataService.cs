using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PozdeevaEA.Sprint2.Task2.V14.Lib
{
    public class DataService : ISprint2Task2V14
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            // x = 2     && y = 4-5
            // x = 3-5   && y = 3-7
            // x = 6-8   && y = 5-10
            // x = 3-12  && y = 11
            // x = 7-10  && y = 12
            // x = 13    && y = 9-13
            // x = 9-12  && y = 5
            // x = 10-12 && y = 2-4
            // x = 13    && y = 2-3

            bool res;
            if (((x >= 2) && (x < 3) && (y >= 4) && (y <= 5)) || 
                ((x >= 3) && (x <= 5) && (y >= 3) && (y <= 7)) || 
                ((x >= 6) && (x <= 8) && (y >= 5) && (y <= 10)) || 
                ((x >= 3) && (x <= 12) && (y >= 11) && (y < 12)) ||
                ((x >= 7) && (x <= 10) && (y >= 12) && (y < 13)) ||
                ((x >= 13) && (x < 14) && (y >= 9) && (y <= 13)) ||
                ((x >= 9) && (x <= 12) && (y >= 5) && (y < 6)) ||
                ((x >= 10) && (x <= 12) && (y >= 2) && (y <= 4)) ||
                ((x >= 13) && (x < 14) && (y >= 2) && (y <= 3))
                )
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
