using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Z4_TPL
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            var google = new Website("http://google.pl", "/");
            var ath = new Website("http://ath.bielsko.pl", "/");
            var wiki = new Website("https://wikipedia.pl", "/wiki/.Net_Core");
            var yt = new Website("https://youtube.com", "/");
            var ath2 = new Website("http://google.pl", "/graficzne-formy-przekazu-informacji/");


            var tasks = new List<Task>();


            stopwatch.Start();
            //Console.WriteLine(stopwatch.Elapsed + " " + "Task.WhenAll() done!");

            tasks.Add(google.Download());
            Console.WriteLine(stopwatch.Elapsed);
            tasks.Add(ath.Download());
            Console.WriteLine(stopwatch.Elapsed);
            tasks.Add(wiki.Download());
            Console.WriteLine(stopwatch.Elapsed);
            tasks.Add(yt.Download());
            Console.WriteLine(stopwatch.Elapsed);
            tasks.Add(ath2.Download());
            Console.WriteLine(stopwatch.Elapsed);

            Console.WriteLine("-----------------------------");


            await Task.WhenAny(tasks);
            Console.WriteLine(stopwatch.Elapsed);
            await Task.WhenAll(google.Download(), ath.Download(), wiki.Download(), yt.Download(), ath2.Download());
            Console.WriteLine(stopwatch.Elapsed);

            stopwatch.Stop();
            


            Console.ReadLine();
        }
    }
}
