using System;
using System.Collections.Generic;
using System.Text;

namespace UnityConsole
{
    /// <summary>
    /// 电商班
    /// </summary>
    public class EcClass : IClass
    {
        public string ClassName { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine("电商班：{0}", ClassName);
        }
    }
}
