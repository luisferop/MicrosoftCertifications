using System;
using System.Threading.Tasks;

namespace prjChap01
{
    class Program
    {
        #region Listing 1-1 = First example
        //public static void ThreadMethod()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("ThreadProc: {0}", i);
        //        //Thread.Sleep(1000);
        //        Thread.Sleep(0);
        //    }
        //}

        //public static void Main(string[] args)
        //{
        //    Thread t = new Thread(new ThreadStart(ThreadMethod));
        //    t.Start();

        //    for (int i = 0; i < 4; i++)
        //    {
        //        Console.WriteLine("Main thread: Do some work!");
        //        Thread.Sleep(0);
        //    }
        //    t.Join();

        //    Console.ReadLine();
        //}
        #endregion

        #region Listing 1-2 = Background example
        //public static void ThreadMethod()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("ThreadProc: {0}", i);
        //        Thread.Sleep(1000);

        //    }
        //}
        //public static void Main(string[] args)
        //{
        //    Thread t = new Thread(new ThreadStart(ThreadMethod));
        //    t.IsBackground = false;
        //    t.Start();
        //}

        #endregion

        #region Listing 1-3 = Parameterized Thread
        //public static void ThreadMethod(object obj)
        //{
        //    for (int i = 0; i < (int)obj; i++)
        //    {
        //        Console.WriteLine("ThreadProc: {0}", i);
        //        Thread.Sleep(0);

        //    }
        //}
        //public static void Main(string[] args)
        //{
        //    Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
        //    t.Start(5);

        //    for (int i = 0; i < 4; i++)
        //    {
        //        Console.WriteLine("Main thread: Do some work!");
        //        Thread.Sleep(0);
        //    }
        //    t.Join();
        //}
        #endregion

        #region Listing 1-4 = Shared Variable
        //public static void Main(string[] args)
        //{
        //    bool stopped = false;
        //    Thread t = new Thread(new ThreadStart(() => {
        //        while (!stopped)
        //        {
        //            Console.WriteLine("Running...!");
        //            Thread.Sleep(1000);
        //        }
        //    }));
        //    t.Start();

        //    Console.WriteLine("Press any key to exit!");
        //    Console.ReadKey();
        //    stopped = true;
        //    t.Join();
        //}
        #endregion

        #region Listing 1-5 = ThreadStatic
        //[ThreadStatic]
        //public static int _field;
        //public static void Main()
        //{
        //    new Thread(() => {
        //        for (int z = 0; z < 10; z++)
        //        {
        //            _field++;
        //            Console.WriteLine("Thread A: {0}", z);
        //        }
        //    }).Start();

        //    new Thread(() => {
        //        for (int z = 0; z < 10; z++)
        //        {
        //            _field++;
        //            Console.WriteLine("Thread B: {0}", z);
        //        }
        //    }).Start();
        //    Console.ReadKey();
        //}
        #endregion

        #region Listing 1-6 = ThreadLocal
        //public static ThreadLocal<int> _field =
        //new ThreadLocal<int>(() =>
        //{
        //    return Thread.CurrentThread.ManagedThreadId;
        //});
        //public static void Main()
        //{
        //    new Thread(() =>
        //    {
        //        for (int z = 0; z < _field.Value; z++)
        //        {

        //            Console.WriteLine("Thread A: {0}", z);
        //        }
        //    }).Start();

        //    new Thread(() =>
        //    {
        //        for (int z = 0; z < _field.Value; z++)
        //        {

        //            Console.WriteLine("Thread B: {0}", z);
        //        }
        //    }).Start();
        //    Console.ReadKey();
        //}

        #endregion

        #region Listing 1-7 = Thread Pools

        //public static void Main()
        //{
        //    ThreadPool.QueueUserWorkItem((s) => {
        //        Console.WriteLine("Working on a thread from threadpool!");
        //    });
        //    Console.ReadLine();
        //}
        #endregion

        #region Listing 1-8 = Tasks

        //public static void Main()
        //{
        //    Task t = Task.Run(() => {
        //        for (int i = 0; i < 100; i++)
        //        {
        //            Console.Write("*");
        //        }
        //    });
        //    t.Wait();
        //    Console.ReadKey();
        //}
        #endregion

        #region Listing 1-9 = Tasks that returns a value

        public static void Main()
        {
            Task<int> t = Task.Run(() => {
                Console.Write("Enter a number: ");
                string s = Console.ReadLine();

                return int.Parse(s);
            });
            Console.WriteLine("Number typed: {0}",t.Result);
            Console.ReadKey();
        }
        #endregion
    }
}
