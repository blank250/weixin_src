using System;
using System.Collections.Generic;
using System.Text;

namespace blank.Tools
{
    /// <summary>
    /// 配置辅助类
    /// </summary>
    public class ConfigHelper
    {
        /// <summary>
        /// 获取配置文件属性
        /// </summary>
        /// <param name="varTypeString"></param>
        /// <returns></returns>
        public static string GetConfigFileName(string varTypeString)
        {
            string tmpConfigFileKey = "";
            string tmpFileName = "";

            tmpConfigFileKey = varTypeString;

            if (tmpConfigFileKey != "")
            {
                tmpFileName = System.Configuration.ConfigurationManager.AppSettings[tmpConfigFileKey];
            }

            return tmpFileName;
        }

        /// <summary>
        /// 获取应用程序配置内容
        /// </summary>
        /// <param name="varType"></param>
        /// <returns></returns>
        //public static string GetApplicationConfig(WebConfigType varType)
        //{
        //    string tmpValue = "";

        //    tmpValue = GetApplicationConfig(varType.ToString(), true);

        //    return tmpValue;
        //}

        /// <summary>
        /// 获取应用程序配置内容
        /// </summary>
        /// <param name="varTypeString"></param>
        /// <param name="varHasKey"></param>
        /// <returns></returns>
        //public static string GetApplicationConfig(string varTypeString, bool varHasKey)
        //{
        //    string tmpKey = "";
        //    string tmpValue = "";

        //    if (varHasKey)
        //    {
        //        tmpKey = System.Configuration.ConfigurationManager.AppSettings[varTypeString + "Key"];
        //    }
        //    else
        //    {
        //        tmpKey = varTypeString;
        //    }
        //    if (!String.IsNullOrEmpty(tmpKey))
        //    {
        //        tmpValue = System.Configuration.ConfigurationManager.AppSettings[tmpKey];
        //    }

        //    return tmpValue;
        //}

        /// <summary>
        /// 获取配置的权限组合类型
        /// </summary>
        /// <returns></returns>
        //public static PowerMethod GetPowerMethod()
        //{
        //    string tmpStr = "";
        //    PowerMethod tmpValue = PowerMethod.U;

        //    tmpStr = GetApplicationConfig(WebConfigType.MESMainPowerMethod);
        //    if (!String.IsNullOrEmpty(tmpStr))
        //    {
        //        if (tmpStr == PowerMethod.UA.ToString())
        //        {
        //            tmpValue = PowerMethod.UA;
        //        }
        //    }

        //    return tmpValue;
        //}
    }
}