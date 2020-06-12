﻿using EZNEW.DataValidation;
using EZNEW.Web.Mvc.Display;
using System.IO;

namespace Site.Console.Config
{
    /// <summary>
    /// mvc config
    /// </summary>
    public static class MvcConfig
    {
        public static void Config()
        {
            var rootPath = Directory.GetCurrentDirectory();
            //数据验证
            ValidationManager.ConfigureByConfigFile(rootPath);
            //显示配置
            DisplayManager.ConfigureByConfigFile(rootPath);
        }
    }
}
