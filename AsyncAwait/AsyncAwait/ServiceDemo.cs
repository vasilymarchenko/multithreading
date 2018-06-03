using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class ServiceDemo
    {
        static Task SavePage1(string file, string linkUrl)
        {
            var stream = File.AppendText(file);

            //return new WebClient().DownloadStringTaskAsync(a)
            //    .ContinueWith(delegate (Task<string> data)

            return new WebClient().DownloadStringTaskAsync(linkUrl)
                .ContinueWith((Task<string> data) =>
                {
                    try
                    {
                        stream.Write(data.Result);
                    }
                    finally
                    {
                        stream.Dispose();
                    }
                });
        }

        /// <summary>
        /// Маркер async может применяться к методу, который возвращает Task<T> или void.
        /// Применять маркер к методу нужно, когда в теле метода происходит 
        /// комбинация других асинхронных вызовов (используется оператор await) 
        /// или когда метод определяет асинхронную операцию
        /// </summary>
        /// <param name="file"></param>
        /// <param name="linkUrl"></param>
        /// <returns></returns>
        static async Task SavePage(string file, string linkUrl)
        {
            using (var stream = File.AppendText(file))
            {
                Task<string> t = new WebClient().DownloadStringTaskAsync(linkUrl);
                string h = t.Result;
                stream.Write(h);

                string html = await new WebClient().DownloadStringTaskAsync(linkUrl);
                stream.Write(html);
            }

            //метод DownloadStringTaskAsync создает задачу Task и сразу возвращает ее из функции
            //, в то время как в фоновом потоке начинает скачиваться страница с запрошенного url
        }



        public static void Starter()
        {
            Console.WriteLine("Starter started at {0}, ThreadId={1}", DateTime.Now, Thread.CurrentThread.ManagedThreadId);
            DoLongAsync();
            Console.WriteLine("Starter finished at {0}", DateTime.Now);
        }

        public static async void DoLongAsync()
        {
            Console.WriteLine("DoLongAsync started at {0}, ThreadId ={1}", DateTime.Now, Thread.CurrentThread.ManagedThreadId);

            string res = await DoLongWork();

            Console.WriteLine("DoLongAsync finished at {0}", DateTime.Now);
        }

        public static Task<string> DoLongWork()
        {
            return Task.Run<string>(() => {
                Console.WriteLine("Worker started at {0}, ThreadId={1}", DateTime.Now, Thread.CurrentThread.ManagedThreadId);
                for (int i = 0; i < 1000; i++)
                {
                    Thread.Sleep(2);
                }
                
                Console.WriteLine("Worker finished at {0}", DateTime.Now);
                return "done";
            });
   
        }

    }
}