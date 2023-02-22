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
        protected string selectCountryXPath = "*//select[@id='country']";
        protected string inputStateXPath = "//input[@id='state']";
        protected string inputCityXPath = "//input[@id='city']";
        protected string inputZipCodeXPath = "//input[@id='zipcode']";
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
        public bool FormIsPresentSignup()
        {
            return WaitHandler.ElementIsPresent(Driver, accountInformationTitleXPath);
        }

        // Metodo para seleccionar title Mr o Mrs
        public void ClickRadioTitleSignup(string title)
        {
            switch(title)
            {
                case "Mr.":
                    Driver.FindElement(By.XPath(radioMrXPath)).Click();
                    break;
                case "Mrs.":
                    Driver.FindElement(By.XPath(radioMrsXPath)).Click();
                    break;
            }         
        }

        // Metodo para ingresar password
        public void TypePasswordSignup(string password)
        {
            Driver.FindElement(By.XPath(inputPasswordXPath)).SendKeys(password);
        }

        // Metodo para seleccionar el dia de nacimiento
        public void SelectBirthDaySignup(string day) //*select[@id="days"]/option[@value='2']
        {
            Driver.FindElement(By.XPath(selectDaysXPath + "/option[@value='" + day + "']")).Click();
        }

        // Metodo para seleccionar el mes de nacimiento
        public void SelectBirthMonthSignup(string month)
        {
            switch(month)
            {
                case "January":
                    Driver.FindElement(By.XPath(selectMonthsXPath + "/option[2]")).Click();
                    break;
                case "February":
                    Driver.FindElement(By.XPath(selectMonthsXPath + "/option[3]")).Click();
                    break;
                case "March":
                    Driver.FindElement(By.XPath(selectMonthsXPath + "/option[4]")).Click();
                    break;
                case "April":
                    Driver.FindElement(By.XPath(selectMonthsXPath + "/option[5]")).Click();
                    break;
                case "May":
                    Driver.FindElement(By.XPath(selectMonthsXPath + "/option[6]")).Click();
                    break;
                case "June":
                    Driver.FindElement(By.XPath(selectMonthsXPath + "/option[7]")).Click();
                    break;
                case "July":
                    Driver.FindElement(By.XPath(selectMonthsXPath + "/option[8]")).Click();
                    break;
                case "August":
                    Driver.FindElement(By.XPath(selectMonthsXPath + "/option[9]")).Click();
                    break;
                case "September":
                    Driver.FindElement(By.XPath(selectMonthsXPath + "/option[10]")).Click();
                    break;
                case "October":
                    Driver.FindElement(By.XPath(selectMonthsXPath + "/option[11]")).Click();
                    break;
                case "November":
                    Driver.FindElement(By.XPath(selectMonthsXPath + "/option[12]")).Click();
                    break;
                case "December":
                    Driver.FindElement(By.XPath(selectMonthsXPath + "/option[13]")).Click();
                    break;
            } 
                    
        }

        // Metodo para seleccionar el año de nacimiento
        public void SelectBirthYearSignup(string year)
        {
            Driver.FindElement(By.XPath(selectYearsXPath + "/option[@value='" + year + "']")).Click();
        }

        // Metodo para ingresar firstname
        public void TypeFirstNameSignup(string firstname)
        {
            Driver.FindElement(By.XPath(inputFirstNameXPath)).SendKeys(firstname);
        }

        // Metodo para ingresar lastname
        public void TypeLastNameSignup(string lastname)
        {
            Driver.FindElement(By.XPath(inputLastNameXPath)).SendKeys(lastname);
        }

        // Metodo para ingresar company
        public void TypeCompanySignup(string company)
        {
            Driver.FindElement(By.XPath(inputCompanyXPath)).SendKeys(company);
        }

        // Metodo para ingresar address
        public void TypeAddressSignup(string address)
        {
            Driver.FindElement(By.XPath(inputAddressXPath)).SendKeys(address);
        }

        // Metodo para ingresar address
        public void TypeAddress2Signup(string address2)
        {
            Driver.FindElement(By.XPath(inputAddress2XPath)).SendKeys(address2);
        }

        // Metodo para seleccionar el country
        public void SelectCountrySignup(string country)
        {
            Driver.FindElement(By.XPath(selectCountryXPath + "/option[@value='" + country + "']")).Click();
        }

        // Metodo para ingresar state
        public void TypeStateSignup(string state)
        {
            Driver.FindElement(By.XPath(inputStateXPath)).SendKeys(state);
        }

        // Metodo para ingresar City
        public void TypeCitySignup(string city)
        {
            Driver.FindElement(By.XPath(inputCityXPath)).SendKeys(city);
        }

        // Metodo para ingresar ZipCode
        public void TypeZipCodeSignup(string zipCode)
        {
            Driver.FindElement(By.XPath(inputZipCodeXPath)).SendKeys(zipCode);
        }

        // Metodo para ingresar Mobile Number
        public void TypeMobileNumberSignup(string mobileNumber)
        {
            Driver.FindElement(By.XPath(inputMobileNumberXPath)).SendKeys(mobileNumber);
        }

        // Metodo para ingresar Mobile Number
        public void ClickButtonCreateSignup()
        {
            Driver.FindElement(By.XPath(buttonCreateXPath)).Click();
        }

        // Metodo para crear una nueva cuenta. Retorna a la pagina cuenta creada
        public AccountCreatePage AccountCreateAs(string title, string password, string day, string month, string year, string firstname, string lastname, string company, string address, string address2, string country, string state, string city, string zipCode, string mobileNumber)
        {
            ClickRadioTitleSignup(title);
            TypePasswordSignup(password);
            SelectBirthDaySignup(day);
            SelectBirthMonthSignup(month);
            SelectBirthYearSignup(year);
            TypeFirstNameSignup(firstname);
            TypeLastNameSignup(lastname);
            TypeCompanySignup(company);
            TypeAddressSignup(address);
            TypeAddress2Signup(address2);
            SelectCountrySignup(country);
            TypeStateSignup(state);
            TypeCitySignup(city);
            TypeZipCodeSignup(zipCode);
            TypeMobileNumberSignup(mobileNumber);
            ClickButtonCreateSignup();
            return new AccountCreatePage(Driver);
        }

    }
}
