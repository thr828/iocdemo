
using System;
using System.IO;
using Autofac;
using Autofac.Configuration;
using Microsoft.Extensions.Configuration;

namespace autofacdemo
{
    /// <summary>
    /// 最后要真正完成依赖注入就得AtuoFac登场了
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region 基础的autofac

            // var builder = new ContainerBuilder(); 
            // builder.RegisterType<DBManager>(); 
            // builder.RegisterType<OracleDAL>().As<IDAL>(); 
            // using (var container = builder.Build()) 
            // { 
            //     //1.
            //     // var manager = container.Resolve<DBManager>(); 
            //     // manager.Add("INSERT INTO Persons VALUES ('Man', '25', 'WangW', 'Shanghai')"); 
            //     //2.
            //     DBManager manager1 = container.Resolve<DBManager>(new NamedParameter("name", "SQL"));
            //     manager1.Add("");
            // }
            
          // ContainerBuilder builder = new ContainerBuilder();
          // builder.RegisterType<SqlDAL>().As<IDAL>();
          // IContainer container = builder.Build();
          // SqlDAL sqlDAL = (SqlDAL)container.Resolve<IDAL>();
          // sqlDAL.Insert("");
          
          //builder.RegisterType<Object>().Named<Iobject>(string name)：
          //为一个接口注册不同的实例。有时候难免会碰到多个类映射同一个接口，
          //比如SqlDAL和OracleDAL都实现了IDAL接口，为了准确获取想要的类型，就必须在注册时起名字
          // ContainerBuilder builder1 = new ContainerBuilder();
          // builder1.RegisterType<SqlDAL>().Named<IDAL>("sql");
          // builder1.RegisterType<OracleDAL>().Named<IDAL>("oracle");
          // IContainer container1 = builder1.Build();
          // SqlDAL sqlDAL1 = (SqlDAL)container1.ResolveNamed<IDAL>("sql");
          // OracleDAL oracleDAL1 = (OracleDAL)container1.ResolveNamed<IDAL>("oracle");
          //
          //
          //以枚举的方式为一个接口注册不同的实例。有时候我们会将某一个接口的不同实现用枚举来区分，而不是字符串
          // builder.RegisterType<SqlDAL>().Keyed<IDAL>(DBType.Sql);
          // builder.RegisterType<OracleDAL>().Keyed<IDAL>(DBType.Oracle);
          // IContainer container = builder.Build();
          // SqlDAL sqlDAL = (SqlDAL)container.ResolveKeyed<IDAL>(DBType.Sql);
          // OracleDAL oracleDAL = (OracleDAL)container.ResolveKeyed<IDAL>(DBType.Oracle);
          
          
          #endregion

          #region  配置文件

          

         
          //读取配置实现依赖注入（注意引入Autofac.Configuration.dll）
          ContainerBuilder builder2 = new ContainerBuilder();
          builder2.RegisterType<DBManager>();
          //builder2.RegisterModule(new ConfigurationSettingsReader("autofac"));
          //core中读取配置方法
          //添加 json 文件路径
          var config = new ConfigurationBuilder();
          config.AddJsonFile("autofac.json");
          var module=new ConfigurationModule(config.Build());
          builder2.RegisterModule(module);
          
         
          using (IContainer container = builder2.Build())
          {
              DBManager manager = container.Resolve<DBManager>();
              manager.Add("INSERT INTO Persons VALUES ('Man', '25', 'WangW', 'Shanghai')"); 
          }
          
          #endregion
        
        }
    }
}
