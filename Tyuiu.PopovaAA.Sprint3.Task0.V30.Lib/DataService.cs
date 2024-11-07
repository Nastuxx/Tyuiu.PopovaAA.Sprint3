using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PopovaAA.Sprint3.Task0.V30.Lib
{
    public class DataService : ISprint3Task0V30
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double MultiSeries = 1.0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                MultiSeries = MultiSeries * (i/(Math.Pow((Math.Sin(1)), -10)));
            }
            return Math.Round(MultiSeries, 3);
        }
    }
}
