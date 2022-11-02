using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationQAExam.Pages
{
    public partial class FlagPediaPage: BasePage
    {

        public FlagPediaPage(IWebDriver driver)
            : base(driver)
        {

        }

        public void GetCountryData(List<String> countriesNames)
        {
            for (int i = 0; i < countriesNames.Count; i++)
            {
                if (countriesNames[i].Contains("Bosnia") || countriesNames[i].Contains("Czech")
                    || countriesNames[i].Contains("Netherlands") || countriesNames[i].Contains("Marino")
                    || countriesNames[i].Contains("United") || countriesNames[i].Contains("Vatican") || countriesNames[i].Contains("Macedonia"))
                {
                    countriesNames[i] = CheckExpetionCountries(countriesNames[i]);
                }

                string url = "http://flagpedia.net/" + countriesNames[i];
                this.Driver.Url = url;
                MoveToMapWrapper();
                Thread.Sleep(5000);
                TakeScreenShot(countriesNames[i], Capital.Text, Code.Text.Substring(0, 2));
                Thread.Sleep(2000);
            }
        }

        public void MoveToMapWrapper()
        {
            Actions actions = new Actions(this.Driver);
            actions.MoveToElement(MapWrapper);
            actions.Perform();
        }

        public void TakeScreenShot(String countryName, String capital, String code)
        {
            string fileName = "{" + countryName + "}" + "-{" + capital + "}-" + "{" + code + "}.jpg";
            Screenshot screenshot = ((ITakesScreenshot)this.Driver).GetScreenshot();
            screenshot.SaveAsFile(@"D:\MyDocs\Programming\Automation\AutomationQAExam\AutomationQAExam\Screenshots\" + fileName, ScreenshotImageFormat.Jpeg);
        }

        public String CheckExpetionCountries(String exceptionCountry)
        {
            if (exceptionCountry.Contains("Bosnia"))
            {
                return "bosnia-and-herzegovina";
            }
            else if (exceptionCountry.Contains("Czech"))
            {
                return "the-czech-republic";
            }
            else if (exceptionCountry.Contains("Netherlands"))
            {
                return "the-netherlands";
            }
            else if (exceptionCountry.Contains("Marino"))
            {
                return "san-marino";
            }
            else if (exceptionCountry.Contains("United"))
            {
                return "the-united-kingdom";
            }
            else if (exceptionCountry.Contains("Vatican"))
            {
                return "the-vatican-city";
            }
            else if (exceptionCountry.Contains("Macedonia"))
            {
                return "macedonia";
            }

            return String.Empty;
        }
    }
}
