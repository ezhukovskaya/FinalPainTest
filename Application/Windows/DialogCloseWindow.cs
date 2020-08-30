using FinalPaintTest.Framework.Base;
using FinalPaintTest.Framework.Elements;
using FinalPaintTest.Framework.Utils;
using OpenQA.Selenium;

namespace FinalPaintTest.Application.Windows
{
    class DialogCloseWindow: BaseWindow
    {
        private static readonly By ParentName = By.Name("Paint");
        private Button DoNotSaveButton = new Button(By.Name("Don't Save"), "Don't Save Button");
        private static Label DialogWindow = new Label(ParentName, "Open Dialog Window");

        public DialogCloseWindow() : base(DialogWindow) { }

        public void DoNotSaveClick()
        {
            Logger.Log.Info($"Trying to click {DoNotSaveButton.GetElementName()} button");
            DoNotSaveButton.GetElementByParent(ParentName).Click();
        }
    }
}
