using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationQAExam.Pages
{
    public partial class EUCountriesPage
    {
        public IWebElement CountriesOfEurope
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id='leftmenu-style']/ul[2]/li[1]"));
            }
        }

        public List<IWebElement> CountriesNames
        {
            get
            {
                List<IWebElement> cointriesList = this.Driver.FindElements(By.CssSelector("ul.column > li")).ToList();
                return cointriesList;
            }
        }
    }
}
