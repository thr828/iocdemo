using System.Configuration;
using Microsoft.Practices.Unity.Configuration;
using Unity;

namespace UnityFrameworkConsole
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();//获取指定名称的配置节   
            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");    
            container.LoadConfiguration(section, "FirstClass");//获取特定配置节下已命名的配置节<container name="FirstClass">下的配置信息
            IClass classInfo = container.Resolve<IClass>("ec"); 
            classInfo.ShowInfo();
        }
    }
}