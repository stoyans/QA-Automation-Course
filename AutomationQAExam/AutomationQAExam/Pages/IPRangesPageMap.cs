using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationQAExam.Pages
{
    public partial class IPRangesPage: BasePage
    {
        public IWebElement Search
        {
            get
            {
                return this.Driver.FindElement(By.XPath("html/body/form/input[1]"));
            }
        }

        public IWebElement PeerGuardian
        {
            get
            {
                return this.Driver.FindElement(By.XPath("html/body/form/input[3]"));
            }
        }

        public IWebElement Generate
        {
            get
            {
                return this.Driver.FindElement(By.XPath("html/body/form/input[5]"));
            }
        }

        public IWebElement RangesContent
        {
            get
            {
                return this.Driver.FindElement(By.XPath("/html/body/pre"));
            }
        }
        
    }
}
