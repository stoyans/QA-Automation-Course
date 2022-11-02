using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationQAExam.Pages
{
    public abstract class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        public IWebDriver Driver;

        public WebDriverWait Wait
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(20));
                return wait;
            }
        }
    }
}
