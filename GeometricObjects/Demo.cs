using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    class Demo
    {
        public int GetMaxValue(int[] arr)
        {
            int maxValue = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxValue) { maxValue = arr[i]; }
            }
            return maxValue;
        }
        /*
        public long Add(int value1, int value2, params int[] list)
        {
            long sum = value1 + value2;
            foreach(int z in list)
            {
                sum += z;
            }
            return sum;
        }
*/
        public long Add(params int[] list)
        {
            long sum=0;
            foreach (int z in list)
            {
                sum += z;
            }
            return sum;
        }
    }
}
