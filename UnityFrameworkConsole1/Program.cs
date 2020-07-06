using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity.Configuration;
using Unity;

namespace UnityFrameworkConsole1
{
    /// <summary>
    /// 使用unity，unity.configuration
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

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
