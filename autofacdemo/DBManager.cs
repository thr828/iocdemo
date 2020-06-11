using System;
using System.Collections.Generic;
using System.Text;

namespace autofacdemo
{
    /// <summary>
    /// 注入实现构造函数注入
    /// </summary>
    public class DBManager
    {
        IDAL _dal;
        private string _name;
        
        public DBManager(IDAL dal)
        {
            _dal = dal;
        }
        
        public DBManager (string name,IDAL  dal)
        {
            _name = name;
            _dal= dal;
        }
        public void Add(string commandText)
        {
            _dal.Insert(commandText);
        }
    }
}
