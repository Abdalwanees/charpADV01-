using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_ADV01.Genaric
{
    public class Range<T> where T : IComparable<T>
    {
        public T Minimum { get; private set; }
        public T Maximum { get; private set; }

        public Range(T minimum, T maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0;
        }

        public T Length()
        {
            dynamic min = Minimum;
            dynamic max = Maximum;
            return max - min;
        }
    }
}
