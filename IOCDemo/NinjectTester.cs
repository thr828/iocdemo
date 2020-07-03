using System;
using System.Collections.Generic;
using System.Text;

namespace IOCDemo
{
    class NinjectTester : ITester
    {
        public string _Message { set; get; }
        private ILogger _logger;
        public NinjectTester(ILogger logger)
        {
            _logger = logger;
        }
        public void Test()
        {
            _logger.Write("Hello!");
        }
    }
}
