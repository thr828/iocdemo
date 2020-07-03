using System;
using System.Collections.Generic;
using System.Text;

namespace IOCDemo
{
    public class DBLogger : ILogger
    {
        public void Write(string message)
        {
            Console.WriteLine(String.Format("数据库记录日志:{0}", message));
        }
    }
}
