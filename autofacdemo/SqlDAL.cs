using System;
using System.Collections.Generic;
using System.Text;

namespace autofacdemo
{
    public class SqlDAL : IDAL
    {
        public void Insert(string commandText)
        {
            Console.WriteLine("使用sqlDAL添加相关信息");
        }
    }
}
