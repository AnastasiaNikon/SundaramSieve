using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SundaramSieve
{
    public class Sundaram
    {
        private uint limit; // верхняя граница диапазона просеивания
        private int size;  // размер массива
        private bool[] primes; // массив результатов просеивания
        private int counter;

        public Sundaram(uint limit)
        {
            this.limit = limit;
            if (this.limit % 2 == 0)
            {
                this.limit -= 1;
            }

            size = (int)(this.limit / 2);
            primes = new bool[size];

            Sieve(); // просеивание
            counter = -1;
        }

        public uint NextPrime
        {
            get
            {
                while (counter < size - 1)
                {
                    counter++;
                    if (!primes[counter])
                    {
                        return (uint)(2 * counter + 3);
                    }
                }
                return 0;
            }
        }

        private void Sieve()
        {
            int imax = ((int)Math.Sqrt(limit) - 1) / 2;
            for (int i = 1; i <= imax; i++)
            {
                int jmax = (size - i) / (2 * i + 1);
                for (int j = i; j <= jmax; j++)
                {
                    primes[2 * i * j + i + j - 1] = true;
                }
            }
        }
    }
}
