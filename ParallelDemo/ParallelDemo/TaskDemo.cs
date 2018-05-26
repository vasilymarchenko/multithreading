using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelDemo
{
    /// <summary>
    /// тип Task<T> — рабочая лошадка Task Parallel Library (TPL),
    /// — представляющий концепцию «некоей работы, которая в будущем даст результат типа T». 
    /// Концепция «работы, которая завершится в будущем, но не вернет никаких результатов» 
    /// представлена необобщенным типом Task.
    /// </summary>
    public class TaskDemo
    {
        public string GetSite()
        {
            Task<string> task = Task.Factory.StartNew<string>(() =>    // Начало задачи
            {
                using (var wc = new System.Net.WebClient())
                    return wc.DownloadString("http://www.linqpad.net");
            });

            RunSomeOtherMethod();         // Мы можем выполнять другую работу параллельно...

            return task.Result;  // Ожидаем выполнения задачи для получения результатов.
        }

        public void StateDemo()
        {
            var task = Task.Factory.StartNew(state => Greet("Hello"), "Greeting");
            Console.WriteLine(task.AsyncState);   // Greeting
            task.Wait();
        }

        public void ContinueTasks()
        {
            Task.Factory.StartNew<int>(() => 8)
              .ContinueWith(ant => ant.Result * 2)
              .ContinueWith(ant => Math.Sqrt(ant.Result))
              .ContinueWith(ant => Console.WriteLine(ant.Result));   // 4
        }

        private void Greet(string message)
        {
            Thread.Sleep(2000);
            Console.Write(message);
        }

        private void RunSomeOtherMethod()
        {
            Console.WriteLine("Doing something ...");

        }
    }
}
