using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationQAExam.Pages
{
    public partial class IPRangesPageUpdate: BasePage
    {
        public IWebElement SearchField
        {
            get
            {
                return this.Driver.FindElement(By.Id("keyword"));
            }
        }

        public IWebElement CountryIPRangeList
        {
            get
            {
                return this.Driver.FindElement(By.Id("ip-address"));
                //return this.Driver.FindElement(By.XPath("/html/body/div/div[2]/div/div/table/tbody"));
            }
        }

        public IWebElement CurrentCountry(String country)
        {
            if (country.Contains("UK"))
            {
                return this.Driver.FindElement(By.PartialLinkText("United Kingdom"));
            }
            else if (country.Contains("Vatican"))
            {
                return null;
            }
            else
            {
                return this.Driver.FindElement(By.PartialLinkText(country));
            }
        }
    }
}
