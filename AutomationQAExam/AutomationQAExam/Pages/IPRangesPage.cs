using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationQAExam.Pages
{
    public partial class IPRangesPage: BasePage
    {
        public IPRangesPage(IWebDriver driver)
            : base(driver)
        {

        }

        public String CountryRange = String.Empty;

        public void NavigateToIPRanges()
        {
            Driver.Navigate().GoToUrl(@"http://services.ce3c.be/ciprg/");
        }


        public void ExtractRanges(List<String> Countries)
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                Search.Clear();
                if (Countries[i] == "Bosnia and Herzegovina")
                {
                    Search.SendKeys("BOSNIA AND HERZEGOWINA");
                }
                else if (Countries[i] == "Croatia")
                {
                    Search.SendKeys("CROATIA (LOCAL NAME: HRVATSKA)");
                }
                else if (Countries[i] == "Czechia")
                {
                    Search.SendKeys("CZECH REPUBLIC");
                }
                else if (Countries[i].Contains("Macedonia"))
                {
                    Search.SendKeys("Macedonia");
                }
                else if (Countries[i].Contains("Slovakia"))
                {
                    Search.SendKeys("SLOVAKIA (SLOVAK REPUBLIC)");
                }
                else if (Countries[i].Contains("United Kingdom"))
                {
                    Search.SendKeys("UNITED KINGDOM");
                }
                else if (Countries[i].Contains("Vatican City"))
                {
                    Search.SendKeys("HOLY SEE (VATICAN CITY STATE)");
                }
                else if (Countries[i].Contains("Moldova"))
                {
                    Search.SendKeys("MOLDOVA REPUBLIC OF");
                }
                else if (Countries[i].Contains("Russia"))
                {
                    Search.SendKeys("Russian Federation");
                }
                else
                {
                    Search.SendKeys(Countries[i]);
                }
                
                PeerGuardian.Click();
                Generate.Click();
                CountryRange = RangesContent.Text;
                File.WriteAllText(@"D:\MyDocs\Programming\Automation\AutomationQAExam\AutomationQAExam\CountryIP\" + Countries[i] + ".txt", CountryRange);
                NavigateToIPRanges();
                Thread.Sleep(1000);
            }
        }
    }
}
