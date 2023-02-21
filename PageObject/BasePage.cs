using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject_02.PageObject
{
    // Case base para todas las page object
    public abstract class BasePage
    {
        // Selenium Driver
        protected IWebDriver Driver;
    }
}
