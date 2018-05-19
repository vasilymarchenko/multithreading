using System;
using System.Threading;

namespace ThreadPoolDemo
{
    public static class Worker
    {
        public static void DoWork(int load)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"ThreadID:{Thread.CurrentThread.ManagedThreadId}, value:i={i};");
                Thread.Sleep(load);
            }
        }
    }
}
