using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xoponky.Core
{
    public class Dummy
    {
        public int Sum(int value1, int value2, params int[] values)
        {
            var sum = value1 + value2;
            if (values != null)
                sum += values.Sum();
            return sum;
        }
    }
}
