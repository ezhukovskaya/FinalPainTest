using FinalPaintTest.Framework.Base;
using FinalPaintTest.Framework.Desktop;
using FinalPaintTest.Framework.Elements;
using FinalPaintTest.Framework.Utils;
using OpenQA.Selenium;

namespace FinalPaintTest.Application.Windows
{
    class DialogOpenWindow: BaseWindow
    {
        private readonly By ParentClassName = By.ClassName("#32770");
        private static TextBox FileTextBox = new TextBox(By.ClassName("Edit"), "Open File Dialog Window");

        public DialogOpenWindow() : base(FileTextBox) { }
        public void TypeFileAddressToOpen(string address)
        {
            Logger.Log.Info($"Trying to type {address} into {FileTextBox.GetElementName()} textbox");
            FileTextBox.GetElementByParent(ParentClassName).SendKeys(address);
        }

        public void EnterClick()
        {
            Logger.Log.Info("Clicks Enter");
            Desktop.SendKeys(Keys.Enter);
        }
    }
}