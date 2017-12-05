using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test.OtherStuff
{
    public static class Quiz
    {
        public static void Quiz1()
        {
            var producer = Task.Run(() =>
            {
                Thread.Sleep(1000);
                return 1;
            });

            var sum = 0;
            var consumers = Enumerable.Range(1, 1000)
                .Select(_ => Task.Run(async () =>
                {
                    var count = await producer;
                    var oldSum = sum;
                    Thread.Sleep(_ % 15);
                    sum = oldSum + count;
                }))
                    .ToArray();

            Task.WaitAll(consumers);
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        static void MainThreads(string[] args)
        {
            Thread Start(ThreadStart a)
            {
                var th = new Thread(a);
                th.Start();
                return th;
            }
            var producerResult = 0;
            var producer = new Thread(() =>
            {
                Thread.Sleep(1000);
                producerResult = 1;
            });

            producer.Start();
            var sum = 0;
            var consumers = Enumerable.Range(1, 1000)
                .Select(i => Start(() =>
                {
                    producer.Join();
                    var count = producerResult;
                    var oldSum = sum;
                    Thread.Sleep(i % 15);
                    sum = oldSum + count;
                }))
                .ToList();

            consumers.ForEach(_ => _.Join());
            Console.WriteLine(sum);

        }
    }
}
