using System;
using System.Diagnostics;

namespace PropertiesVsFields
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadySetGo go = new ReadySetGo();

            go.Run();

            Console.ReadKey();
        }
    }


    class ReadySetGo
    {

        public void Run()
        {
            const int iterations = (int)1e7;

            var r = new Random();
            FieldClass[] f = new FieldClass[iterations];
            PropertyClass[] p = new PropertyClass[iterations];

            for (int i = 0; i < iterations; i++)
            {
                f[i] = new FieldClass() { Number = r.Next() };
                p[i] = new PropertyClass() { Number = r.Next() };
            }

            int sum1 = 0, sum2 = 0;

            var s = new Stopwatch();
            s.Start();

            for (int i = 0; i < iterations; i++)
            {
                sum1 += f[i].Number;
            }

            s.Stop();

            Console.WriteLine("Field operations took {0} ticks.", s.ElapsedTicks);

            s.Reset();
            s.Start();

            for (int i = 0; i < iterations; i++)
            {
                sum2 += p[i].Number;
            }

            s.Stop();

            Console.WriteLine("Property operations took {0} ticks.", s.ElapsedTicks);
        }
    }

    class FieldClass
    {
        public int Number;
    }

    class PropertyClass
    {
        public int Number { get; set; }
    }
}