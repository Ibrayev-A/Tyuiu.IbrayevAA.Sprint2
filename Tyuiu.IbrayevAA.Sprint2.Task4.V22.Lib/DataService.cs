using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.IbrayevAA.Sprint2.Task4.V22.Lib
{
    public class DataService : ISprint2Task4V22
    {
        public double Calculate(double x, double y)
        {
            double z = x - 3 > y * 2 - 21 ? (x * x + 12 * y - 2 / x) : ((x * x + Math.Pow(Math.Cos(y), 2) + 17) / (y * y - Math.Pow(Math.Sin(y), 2) + 3));
            return Math.Round(z, 3);
        }
    }
}
