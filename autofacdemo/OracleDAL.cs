using System;
using System.Collections.Generic;
using System.Text;

namespace autofacdemo
{
    public class OracleDAL : IDAL
    {
        public void Insert(string commandText)
        {
            Console.WriteLine("使用OracleDAL添加相关信息");
        }
    }
}
