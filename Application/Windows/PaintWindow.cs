using FinalPaintTest.Framework.Base;
using FinalPaintTest.Framework.Elements;
using OpenQA.Selenium;

namespace FinalPaintTest.Application.Windows
{
    class PaintWindow: BaseWindow
    {
        private static Button FileButton = new Button(By.Name("File tab"), "File");
        private Button OpenButton = new Button(By.Name("Open"), "Open");
        private Button SelectButton = new Button(By.XPath("/Window/Pane[1]/Pane/Pane/Pane/Pane/Pane/Custom/Custom/ToolBar[2]/Group/SplitButton[2]"), "Select");
        private Button SelectAllButton = new Button(By.Name("Select all"), "Select All");
        private Button CutButton = new Button(By.Name("Cut"), "Cut");
        private Label CanvasSelected = new Label(By.Name("Using Select tool on Canvas"), "Selection");
        private Button CloseButton = new Button(By.Name("Close"), "Close");

        public PaintWindow() : base(FileButton) { }
        public void OpenFileScenarioClick()
        {
            FileButton.Click();
            OpenButton.Click();
        }

        public DialogOpenWindow GetDialogOpenWindow()
        {
            return new DialogOpenWindow();
        }

        public DialogCloseWindow GetDialogCloseWindow()
        {
            return new DialogCloseWindow();
        }

        public void SelectAll()
        {
            SelectButton.Click();
            SelectAllButton.Click();
        }

        public void Cut() => CutButton.Click();

        public void Close() => CloseButton.Click();

        public bool IsAllSelected() => CanvasSelected.isDisplayed();
    }
}
