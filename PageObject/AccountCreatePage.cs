using AutomationProject_02.Handler;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject_02.PageObject
{
    public class AccountCreatePage : BasePage
    {
        // Localizadores. Elementos de la pagina
        protected string AccountCreateXPath = "//h2[@data-qa='account-created']/b ";

        // Constructor. Validación de la pagina, lanza excepción si no es el titulo de la pagina de SignUp
        public AccountCreatePage(IWebDriver driver)
        {
            Driver = driver;
            if (!Driver.Title.Equals("Automation Exercise - Account Created"))
                throw new Exception("Esta no es la pagina de Account Create");
        }

        // Metodo para verificar si se creo la cuenta nueva
        // Retorna True si el elemento de exito esta presente, sino retorna False
        public bool AccountCreatIsPresent()
        {
            return WaitHandler.ElementIsPresent(Driver, AccountCreateXPath);
        }
    }
}
