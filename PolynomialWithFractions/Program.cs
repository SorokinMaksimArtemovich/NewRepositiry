using System;
using System.IO;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            rational_fraction fraction;
            set_of_fractions set = null;
            int num, denum, first_lenth, second_lenth;
            bool is_number = Int32.TryParse(args[0], out first_lenth);
            if (is_number)
            {
                for (int i = 1; i < first_lenth * 2 + 1; i += 2)
                {
                    is_number = Int32.TryParse(args[i], out num);
                    is_number &= Int32.TryParse(args[i + 1], out denum);
                    if (is_number && (denum > 0))
                    {
                        fraction = new rational_fraction(num, (uint)denum);
                        if (set == null)
                        {
                            set = new set_of_fractions(fraction);
                            Console.Write("\n");
                            Console.Write(fraction.value);
                        }
                        else
                        {
                            set.add(fraction);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Fraction {0} is invalid", i);
                    }
                }
            }
            if (set != null)
            {
                Console.Write("\n");
                Console.Write(set.min.value);

                Console.Write("\n");
                double doub;
                is_number = Double.TryParse(args[first_lenth * 2 + 1], out doub);
                Console.Write(set.more_then(doub));
                polynomial polly = new polynomial();
                polly.get(set);
                Console.Write("\n");
                Console.Write(polly.return_string());
                set = null;
                is_number = Int32.TryParse(args[first_lenth * 2 + 2], out second_lenth);
                if (is_number)
                {
                    for (int i = first_lenth * 2 + 3; i < first_lenth * 2 + 3 + second_lenth * 2; i += 2)
                    {
                        is_number = Int32.TryParse(args[i], out num);
                        is_number &= Int32.TryParse(args[i + 1], out denum);
                        if (is_number && (denum > 0))
                        {
                             fraction = new rational_fraction(num, (uint)denum);
                            if (set == null)
                            {
                                set = new set_of_fractions(fraction);
                            }
                            else
                            {
                                set.add(fraction);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Fraction {0} is invalid", i);
                        }
                    }
                    polynomial polly_2 = new polynomial();
                    polly_2.get(set);
                    polly.sum(polly_2);
                    Console.Write("\n");
                    Console.Write(polly.return_string());
                }
            }
            Console.ReadKey();
        }
    }
}
