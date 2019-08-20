using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using System.Configuration;
using IBLL;
using IDAL;
using DAL;

namespace IOC
{
    public class IocCreate
    {
        public static Iconfig_file_first_kindDAL Createconfig_file_first_kindModelDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iconfig_file_first_kindDAL, config_file_first_kindDAL>();
            return ioc.Resolve<Iconfig_file_first_kindDAL>();
        }
        private static UnityContainer GetBLLSeciton()
        {
            UnityContainer ioc = new UnityContainer();
            ExeConfigurationFileMap ecf = new ExeConfigurationFileMap();
            ecf.ExeConfigFilename = @"E:\HR管理系统\HR\UI\Untity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ecf, ConfigurationUserLevel.None);
            UnityConfigurationSection cfs = cf.GetSection("unity") as UnityConfigurationSection;
            ioc.LoadConfiguration(cfs, "containerOne");
            return ioc;
        }
        public static Iconfig_file_first_kindBLL Createconfig_file_first_kindBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Iconfig_file_first_kindBLL>("config_file_first_kindBLL");
        }
    }
}
