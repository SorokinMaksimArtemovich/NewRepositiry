using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2
{
    class polynomial
    {
        private set_of_fractions coefficients;
        public void get(set_of_fractions k)
        {
            coefficients = new set_of_fractions(k);
        }
        public string return_string()
        {
            string made_string = "";
            for (int i = 0; i < this.coefficients.count; i++)
            {
                if (coefficients.fractions[i].numerator != 0)
                {
                    made_string += this.coefficients.fractions[i].numerator.ToString();
                    made_string += '/';
                    made_string += this.coefficients.fractions[i].denumerator.ToString();

                    if (this.coefficients.count - i > 2)
                    {
                        made_string += " x^";
                        made_string += (this.coefficients.count - i - 1);
                        made_string += " + ";
                    }
                    else if (this.coefficients.count - i == 2)
                    {
                        made_string += " x + ";
                    }
                }
            }
            return made_string;
        }
        public void sum(polynomial polly)
        {
            this.coefficients.sum(polly.coefficients);
        }
    }
}
