using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2
{
    public class rational_fraction
    {
        public int numerator;
        public uint denumerator;
        public double value;
        public rational_fraction(int num, uint denum)
        {
            if (denum == 0)
            {
                numerator = 0;
                denumerator = 1;
                value = 0;
                return;
            }
            numerator = num; 
            denumerator = denum;
            value = (double)num / (double)denum;
        }
         private uint GSD(rational_fraction other)
        {
            uint first = this.denumerator, second = other.denumerator, buffer;
            while (second != 0)
            {
                if (first < second)
                {
                    buffer = first;
                    first = second;
                    second = buffer;
                }
                first -= second;
            }
            return first;
        }
        private uint LCM(rational_fraction other)
        {
            return this.denumerator / GSD(other) * other.denumerator;
        }
        public void sum(rational_fraction other)
        {
            this.numerator = (int)((other.denumerator / GSD(other) * this.numerator) + (this.denumerator / GSD(other) * other.numerator));
            this.denumerator = LCM(other);
        }
    }
}
