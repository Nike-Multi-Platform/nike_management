using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.GHNService
{
    public class GHNServiceConfig
    {
        public static string Token { get; set; }
        public static int ShopId { get; set; }

        static GHNServiceConfig()
        {

            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap
            {
                ExeConfigFilename = "..\\..\\GHNService\\GHNServiceConfig.config"
            };
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

            Token = config.AppSettings.Settings["Token"].Value;
            ShopId = int.Parse(config.AppSettings.Settings["ShopID"].Value);
        }
    }
}
