using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
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

        static async Task SavePage(string file, string linkUrl)
        {
            using (var stream = File.AppendText(file))
            {
                var html = await new WebClient().DownloadStringTaskAsync(linkUrl);
                stream.Write(html);
            }
        }
    }
}
