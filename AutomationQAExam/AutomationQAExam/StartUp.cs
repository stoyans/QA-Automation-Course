using AutomationQAExam.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationQAExam
{
    [TestFixture]
    public class StartUp
    {
        public IWebDriver driver;
        List<String> countriesNames;

        [SetUp]
        public void Init()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            EUCountriesPage euCountries = new EUCountriesPage(driver);
            euCountries.NavigateToEUCountries();
            countriesNames = euCountries.ExtractNames();
        }

        [Test]
        public void TakeScreenShots()
        {
            FlagPediaPage flagpedia = new FlagPediaPage(driver);
            flagpedia.GetCountryData(countriesNames);   
        }

        [Obsolete]
        public void ExtractIPRanges()
        {
            IPRangesPage ipranges = new IPRangesPage(driver);
            ipranges.NavigateToIPRanges();
            ipranges.ExtractRanges(countriesNames);
        }

        [Test]
        public void ExtractIPRangesUpdate()
        {
            IPRangesPageUpdate ipranges = new IPRangesPageUpdate(driver);
            ipranges.NavigateToIPRanges();
            ipranges.SaveCountryIPRangeList(countriesNames);
        }

        [TearDown]
        public void CloseSession()
        {
            driver.Quit();
        }
    }
}
