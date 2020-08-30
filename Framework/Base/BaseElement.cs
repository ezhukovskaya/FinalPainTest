using OpenQA.Selenium.Appium.Windows;

namespace FinalPaintTest.Framework.Base
{
    public abstract class BaseElement
    {
        protected string elementName;
        protected string elementLocation;

        protected BaseElement(string elementLocation, string elementName)
        {
            this.elementLocation = elementLocation;
            this.elementName = elementName;
        }

        public string GetElementName() => this.elementName;
        public string GetElementLocation() => this.elementLocation;

        protected WindowsElement GetElementByName()
        {
            return Desktop.Desktop.GetSession().FindElementByName(elementLocation);
        }

        public void Click()
        {
            GetElementByName().Click();
        }
    }
}
