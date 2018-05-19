using System;
using System.Threading;

namespace MuliThreading1.BusinessLogic
{
    public class SimpleCounter
    {
        public static AutoResetEvent waitHandle = new AutoResetEvent(false);

        private object locker = new object();

        public int Counter { get; private set; }

        public void ResetCounter()
        {
            Counter = 0;
        }

        public int GetCount()
        {
            ResetCounter();
            CountFromStartPoint(Counter);
            return Counter;
        }

        public void Count()
        {
            //lock (locker)
            //{
                ResetCounter();
                CountFromStartPoint(Counter);

                waitHandle.Set();
            //}
        }

        public void CountFromStartPoint(object startPoint)
        {
            int num = 0;
            int.TryParse(startPoint.ToString(), out num);
            Counter = num;

            for (int i = 0; i < 100; i++)
            {
                Counter++;
                Console.Write($"{Thread.CurrentThread.Name}:i={Counter};");
                Thread.Sleep(100);
            }
        }

        public void Worker(object param)
        {
            Count();
        }
    }
}
