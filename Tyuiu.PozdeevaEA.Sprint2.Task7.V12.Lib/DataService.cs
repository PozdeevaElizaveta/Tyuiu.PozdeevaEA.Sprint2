using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PozdeevaEA.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;

            if (y <= Math.Pow(x,2) && (y <= 2 - x) && (y>=0) && (x>=0))
            {
                res = true;
            }
            else
            {
                if (y <= Math.Pow(x,2) && (y >= 2 - x) && (x<0))
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
            }
            return res;
        }
    }
}
