using System;
using System.Collections.Generic;
using System.Text;

namespace IOCDemo
{
    public class MyModule : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
             Bind<ILogger>().To<FileLogger>();
             Bind<ILogger>().To<DBLogger>();
        }
    }
}
