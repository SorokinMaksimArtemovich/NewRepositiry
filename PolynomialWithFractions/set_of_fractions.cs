using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2
{
    class set_of_fractions
    {
        public rational_fraction min, max;
        public List<rational_fraction> fractions = new List<rational_fraction>();
        public int count = 0;

        public void add(rational_fraction fraction)
        {

            fractions.Add(fraction);
            if (fraction.value > max.value)
            {
                max = fraction;
            }
            if (fraction.value < min.value)
            {
                min = fraction;
            }
            count++;
        }

        public set_of_fractions(set_of_fractions old_fractions)
        {
            fractions.Add(old_fractions.fractions[0]);
            min = old_fractions.fractions[0];
            max = old_fractions.fractions[0];
            count = 1;
            for (int i = 1; i < old_fractions.count; i++)
            {
                this.add(old_fractions.fractions[i]);
            }
        }

        public set_of_fractions(rational_fraction fraction)
        {
            fractions.Add(fraction);
            min = fraction;
            max = fraction;
            count = 1;
        }
        public bool delete(rational_fraction fraction)
        {
            if (!fractions.Contains(fraction))
            {
                return false;
            }
            else
            {
                fractions.Remove(fraction);
                if (fraction == max)
                {
                    max = fractions[0];
                    foreach(var i in fractions)
                    {
                        if (max.value < i.value)
                        {
                            max = i;
                        }
                    }
                }
                if (fraction == min)
                {
                    min = fractions[0];
                    foreach (var i in fractions)
                    {
                        if (min.value > i.value)
                        {
                            min = i;
                        }
                    }
                }
                count--;
                return true;
            }
        }
        public uint more_then(double value) 
        {
            List<double> list_of_fractions = new List<double> ();
            uint count_of_more = 0;
            foreach (rational_fraction i in fractions)
            {
                if (i.value > value)
                {
                    count_of_more++;
                }
            }
            return count_of_more;
        }
        public uint less_then(double value)
        {
            List<double> list_of_fractions = new List<double>();
            uint count_of_less = 0;
            foreach (rational_fraction i in fractions)
            {
                if (i.value < value)
                {
                    count_of_less++;
                }
            }
            return count_of_less;
        }

        private void swap(set_of_fractions other)
        {
            set_of_fractions buffer = new set_of_fractions(this);
            this.fractions = other.fractions;
            this.count = other.count;
            this.max = other.max;
            this.min = other.min;
            other = buffer;
        }

        public void sum(set_of_fractions other)
        {
            if (this.count < other.count)
            {
                this.swap(other);
            }
            for (int i = this.count - other.count; i < this.count; i++)
            {
                this.fractions[i].sum(other.fractions[i + other.count - this.count]);
            }
        }
    }
}
