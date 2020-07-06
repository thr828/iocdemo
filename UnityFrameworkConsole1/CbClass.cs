using System;
using System.Collections.Generic;
using System.Text;

namespace UnityFrameworkConsole1
{
    public class CbClass : IClass
    {
        public string ClassName { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine("计科班：{0}", ClassName);
        }
    }
}
