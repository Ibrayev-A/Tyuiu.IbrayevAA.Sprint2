using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.IbrayevAA.Sprint2.Task0.V14.Lib
{
    public class DataService : ISprint2Task0V14
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == x - y + y;
            res[1] = x != x - y + y;
            res[2] = y < x;
            res[3] = y > x;
            res[4] = y <= x;
            res[5] = y >= x;
            return res;
        }
    }
}
