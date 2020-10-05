using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;

namespace Lesson_24_09_20_Garbage_Collector
{
    class Logger : IDisposable
    {
        private FileStream fs;
        private StreamWriter sw;
        public Logger(string fileName)
        {
            fs = new FileStream(fileName, FileMode.Create);
            sw = new StreamWriter(fs);
        }
        public void Log(string message)
        {
            sw.WriteLine($"Action happened: {message} on " + DateTime.Now);
        }
        private bool isClosed = false;
        public void Close()
        {
            if (!isClosed)
            {
                sw.Close();
                fs.Close();
                isClosed = true;
                GC.SuppressFinalize(this);
            }
        }
        public void Dispose()
        {
            Close();
        }

        ~Logger()
        {
            Close();
        }
    }
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Constructed");
        }
        ~MyClass() // Finalizer
        {
            Console.WriteLine("Finalized");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            unsafe
            {
                int* ptr = stackalloc int[100];
            }
            //using (var logger = new Logger("log.txt"))
            //{
            //    logger.Log("Info");
            //    Console.WriteLine("Logged");
            //    Thread.Sleep(1000);
            //    logger.Log("Error");
            //    Console.WriteLine("Logged");
            //    Thread.Sleep(1000); 
            //    logger.Log("Warning");
            //    Console.WriteLine("Logged");
            //}

            //Console.WriteLine("Begining of program");
            { var my = new MyClass(); }
            //Console.WriteLine("End of program");

            List<int[]> list = new List<int[]>();
            while (true)
            {
                int[] arr = new int[10000];
                list.Add(arr);
                Console.WriteLine(GC.GetTotalMemory(false));
            }

           // GC.Collect(0, GCCollectionMode.Forced);
        }
    }
}
