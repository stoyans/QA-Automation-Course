using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationQAExam.Pages
{
    public partial class EUCountriesPage: BasePage
    {
        public EUCountriesPage(IWebDriver driver) : base(driver)
        {
            
        }

        public void NavigateToEUCountries()
        {
            Driver.Navigate().GoToUrl(@"https://www.countries-ofthe-world.com/");
            CountriesOfEurope.Click();
        }

        public List<String> ExtractNames()
        {
            var countriesNames = new List<String>();
            File.WriteAllText(@"D:\MyDocs\Programming\Automation\AutomationQAExam\AutomationQAExam\CountriesOfEurope.txt", String.Empty);

            foreach (var country in CountriesNames)
            {
                if (country.Text.Length > 1 && country.Text != "Kosovo")
                {
                    countriesNames.Add(country.Text);
                    File.AppendAllText(@"D:\MyDocs\Programming\Automation\AutomationQAExam\AutomationQAExam\CountriesOfEurope.txt", country.Text);
                    File.AppendAllText(@"D:\MyDocs\Programming\Automation\AutomationQAExam\AutomationQAExam\CountriesOfEurope.txt", "\n");
                }
            }

            return countriesNames;
        }

        
    }
}
