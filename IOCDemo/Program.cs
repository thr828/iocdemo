using System;
using Ninject;

namespace IOCDemo
{
    class Program
    {
        private static IKernel kernel = new StandardKernel(new MyModule());
        static void Main(string[] args)
        {
            ILogger logger = kernel.Get<ILogger>();//获取的是FileLogger
            logger.Write(" Hello !");
            Console.Read();
        }
    }
}