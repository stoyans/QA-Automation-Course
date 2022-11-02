using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationQAExam.Pages
{
    public partial class IPRangesPageUpdate: BasePage
    {
        public IPRangesPageUpdate(IWebDriver driver)
            : base(driver)
        {
            
        }

        public void NavigateToIPRanges()
        {
            this.Driver.Url = "https://lite.ip2location.com/ip-address-ranges-by-country";
        }

        public void SaveCountryIPRangeList(List<String> CountriesNames)
        {
            string countryIPList = String.Empty;

            foreach (var countryName in CountriesNames)
            {

                if (CurrentCountry(countryName) != null)
                {
                    CurrentCountry(countryName).Click();
                    Thread.Sleep(2000);
                    countryIPList = CountryIPRangeList.Text;
                    File.WriteAllText(@"D:\MyDocs\Programming\Automation\AutomationQAExam\AutomationQAExam\CountryIPUpdate\" + countryName + ".txt", countryIPList);
                    NavigateToIPRanges();
                }
            }
        }
    }
}
