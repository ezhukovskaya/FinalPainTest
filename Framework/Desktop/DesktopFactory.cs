using FinalPaintTest.Framework.Constants.Paths;
using FinalPaintTest.Framework.Utils;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace FinalPaintTest.Framework.Desktop
{
    class DesktopFactory
    {
        public static WindowsDriver<WindowsElement> GetSession()
        {
            string PcHost = XMLUtils.GetNodeValue("pcHost", PathConstants.TestConfigurationPath);
            string AppId = XMLUtils.GetNodeValue("appId", PathConstants.TestConfigurationPath);
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("app", AppId);
            return new WindowsDriver<WindowsElement>(new Uri(PcHost), options);
        }
    }
}
