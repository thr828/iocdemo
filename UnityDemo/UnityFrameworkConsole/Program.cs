using System.Configuration;
using Microsoft.Practices.Unity.Configuration;
using Microsoft.Practices.Unity;

namespace UnityFrameworkConsole
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //IUnityContainer container = new UnityContainer();//获取指定名称的配置节   
            //UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");    
            //container.LoadConfiguration(section, "FirstClass");//获取特定配置节下已命名的配置节<container name="FirstClass">下的配置信息
            //IClass classInfo = container.Resolve<IClass>("ec"); 
            //classInfo.ShowInfo();

            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
            fileMap.ExeConfigFilename = "Unity.config";
            
            Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            UnityConfigurationSection section = (UnityConfigurationSection)configuration.GetSection("unity");
            
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.LoadConfiguration(section, "FirstClass");
            //section.Configure(unityContainer, "FirstClass");
            IClass classInfo1 = unityContainer.Resolve<IClass>("ec");
            IClass classInfo = unityContainer.Resolve<IClass>();
            classInfo1.ShowInfo();
            classInfo.ShowInfo();
        }
    }
}