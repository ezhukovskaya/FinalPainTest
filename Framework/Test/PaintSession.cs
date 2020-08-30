using FinalPaintTest.Framework.Desktop;
using FinalPaintTest.Framework.Elements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace FinalPaintTest
{
    [TestClass]
    public class PaintSession
    {
        private static TraceSource log = new TraceSource("PaintSession");
        public Button file = new Button("Меню приложения", "Файл");
        public Button open = new Button("Открыть", "Открыть");
        public TextBox enterFileName = new TextBox("Имя файла:", "Имя файла");
        public const string imagePath = @"D:\Desktop Projects\FinalPaintTest\img.jpg";

        [TestInitialize]
        public void Init()
        {
            log.TraceInformation("App Session starts");
            Desktop.GetSession();
        }

        [TestMethod]
        public void TestMethod1()
        {
            log.TraceInformation("Check if app is open");
            Assert.IsTrue(Desktop.IsOpen(), $"{Desktop.GetSession().Title} is not open succesfully");

            log.TraceInformation($"Try to click element {file.GetElementName()}");
            file.Click();

            log.TraceInformation($"Try to click element {open.GetElementName()}");
            open.Click();

            log.TraceInformation($"Try to send {imagePath} to {enterFileName.GetElementName()}");
            var openModalWindow = Desktop.GetModalWindowByClassName("#32770");
            if(openModalWindow != null)
            {
                var enterFileName = openModalWindow.FindElementByClassName("Edit");
                enterFileName.SendKeys(imagePath);
                var openFile = openModalWindow.FindElementByName("Открыть");
                openFile.Click();
            }
        }

        [TestCleanup]
        public void QuitApp()
        {
            Desktop.Quit();
        }
    }
}
