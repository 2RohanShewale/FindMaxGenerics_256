using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxGenerics
{
    public class FindMaxGeneric<T> where T : IComparable
    {
        public T[] values;
        public FindMaxGeneric(params T[] values)
        {
            this.values = values;
        }

        private T FindMaximum(params T[] values)
        {
            T max = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i].CompareTo(max) > 0)
                {
                    max = values[i];
                }
            }
            return max;
        }
        public T FindMax()
        {
            return FindMaximum(values);
        }
   
    }
}
