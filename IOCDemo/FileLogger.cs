using System;
using System.Collections.Generic;
using System.Text;

namespace IOCDemo
{
    public class FileLogger : ILogger
    {
        public void Write(string message)
        {
            Console.WriteLine(String.Format("文件记录日志:{0}", message));
        }
    }
}
