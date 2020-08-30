using FinalPaintTest.Framework.Base;

namespace FinalPaintTest.Framework.Elements
{
    public class TextBox: BaseElement
    {
        public TextBox(string location, string name) : base(location, name)
        {

        }

        public void SendKeys(string message)
        {
            this.SendKeys(message);
        }
    }
}
