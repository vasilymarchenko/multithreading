using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelDemo
{
    public class PLINQdemo1
    {
        public IEnumerable<int> GetPrimeNumbers()
        {
            // Находим простые числа с помощью простого (неоптимизированного) алгоритма.

            IEnumerable<int> numbers = Enumerable.Range(3, 100000 - 3);

            var parallelQuery =
              from n in numbers.AsParallel()
              where Enumerable.Range(2, (int)Math.Sqrt(n)).All(i => n % i > 0)
              select n;

            int[] primes = parallelQuery.ToArray();
            return primes;
        }
    }
}
