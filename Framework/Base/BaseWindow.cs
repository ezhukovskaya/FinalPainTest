using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaintTest.Framework.Base
{
    abstract class BaseWindow
    {
        private BaseElement Element;
        protected BaseWindow(BaseElement element) => this.Element = element;
        public bool IsDisplayed() => this.Element.isDisplayed();
    }
}
