using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject_02.TestCase
{
    public abstract class BaseTest
    {
        // Selenium Driver
        protected IWebDriver Driver;
        protected string url = "https://automationexercise.com/login";

        // Metodo para inicializar el navegador Chrome y abrir la url
        [SetUp]
        public void BeforeTest()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(url);
            Driver.Manage().Window.Maximize();
        }
        
        // Metodo para cerrar el navegador
        [TearDown] 
        public void AfterTest()
        {
            if(Driver != null) 
            {
               Driver.Quit();
            }
        }
    }
}
