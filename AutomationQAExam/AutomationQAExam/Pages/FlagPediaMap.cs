using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationQAExam.Pages
{
    public partial class FlagPediaPage
    {
        public IWebElement MapWrapper
        {
            get
            {
                return this.Driver.FindElement(By.Id("map-wrapper"));
            }
        }

        public IWebElement Capital
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"content\"]/table/tbody/tr[4]/td"));
            }
        }

        public IWebElement Code
        {
            get
            {
                return this.Driver.FindElement(By.XPath("/html/body/div[3]/main/table/tbody/tr[2]/td"));
            }
        } 
    }
}
