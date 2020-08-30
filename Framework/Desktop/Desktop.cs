using FinalPaintTest.Framework.Constants.Paths;
using FinalPaintTest.Framework.Utils;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;

namespace FinalPaintTest.Framework.Desktop
{
    class Desktop
    {
        private static WindowsDriver<WindowsElement> session;
        private static readonly string ImplicitTimeout = XMLUtils.GetNodeValue("implicitWait",PathConstants.TestConfigurationPath);

        public static WindowsDriver<WindowsElement> GetSession()
        {
            return session ??= DesktopFactory.GetSession();
        }

        public static void Quit() => GetSession().Quit();

        public static bool IsOpen() => GetSession() != null;

        public static WindowsElement FindElementByName(string name)
        {
            return GetSession().FindElementByName(name);
        }

        public static WindowsElement GetModalWindowByClassName(string className)
        {
            return GetSession().FindElementsByClassName(className).FirstOrDefault(p => p.Displayed);
        }
        }
}
