using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationProject_02.Handler;

namespace AutomationProject_02.PageObject
{
    // Clase para representar la pagina del SignUp
    public class SignupPage : BasePage
    {
        // Selenium driver : heredado de la clase BasePage

        // Localizadores. Elementos de la pagina
        // Enter Account Information
        protected string accountInformationTitleXPath = "//div[@class='login-form']/h2";
        protected string radioMrXPath = "//input[@id='id_gender1']";
        protected string radioMrsXPath = "//input[@id='id_gender2']";
        protected string inputNameXPath = "//input[@id='name']";
        protected string inputEmailXPath = "//input[@id='email']";
        protected string inputPasswordXPath = "//input[@id='password']";
        protected string selectDaysXPath = "//select[@id='days']";
        protected string selectMonthsXPath = "//select[@id='months']";
        protected string selectYearsXPath = "//select[@id='years']";
        protected string inputNewsletterXPath = "//input[@id='newsletter']";
        protected string inputOptionXPath = "//input[@id='optin']";
        // Address Information
        protected string inputFirstNameXPath = "//input[@id='first_name']";
        protected string inputLastNameXPath = "//input[@id='last_name']";
        protected string inputCompanyXPath = "//input[@id='company']";
        protected string inputAddressXPath = "//input[@id='address1']";
        protected string inputAddress2XPath = "//input[@id='address2']";
        protected string selectCountryXPath = "//select[@id='country']";
        protected string inputStateXPath = "//input[@id='state']";
        protected string inputCityXPath = "//input[@id='city']";
        protected string inputZipCodePath = "//input[@id='zipcode']";
        protected string inputMobileNumberXPath = "//input[@id='mobile_number']";
        protected string buttonCreateXPath = "//button[@data-qa='create-account']";

        // Constructor. Validación de la pagina, lanza excepción si no es el titulo de la pagina de SignUp
        public SignupPage(IWebDriver driver) 
        {
            Driver = driver;
            if (!Driver.Title.Equals("Automation Exercise - Signup"))
                throw new Exception("Esta no es la pagina de SignUp");
        }

        // Metodo para verificar si el formulario Enter Account Information esta cargado
        // Retorna True si el elemento del formulario esta presente, sino retorna False
        public bool FormIsPresent()
        {
            return WaitHandler.ElementIsPresent(Driver, accountInformationTitleXPath);
        }
    }
}
