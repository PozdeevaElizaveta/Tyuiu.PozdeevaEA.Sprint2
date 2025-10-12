using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PozdeevaEA.Sprint2.Task6.V2.Lib
{
    public class DataService : ISprint2Task6V2
    {
        public string FindMonthSeason(int value)
        {
            switch (value)
            {
                case 1: return "зима";
                case 2: return "зима";
                case 3: return "весна";
                case 4: return "весна";
                case 5: return "весна";
                case 6: return "лето";
                case 7: return "лето";
                case 8: return "лето";
                case 9: return "осень";
                case 10: return "осень";
                case 11: return "осень";
                case 12: return "зима";
                default: throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {value}");
            }
        }
    }
}
