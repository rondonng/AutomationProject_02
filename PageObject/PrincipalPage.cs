using AutomationProject_02.Handler;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject_02.PageObject
{
    public class PrincipalPage : BasePage
    {
        // Localizadores. Elementos de la pagina
        protected string loggedInAsXPath = "//i[@class='fa fa-user']";

        // Constructor. Validación de la pagina, lanza excepción si no esta en la pagina principal
        public PrincipalPage(IWebDriver driver)
        {
            Driver = driver;
            if (!Driver.Title.Equals("Automation Exercise"))
                throw new Exception("No es la pagina de login");
        }

        // Metodo para verificar si esta cargada la pagina de inicio de sesion
        // Retorna True si el elemento "logged as" esta presente, sino retorna False
        public bool LoggedAsIsPresent()
        {
            return WaitHandler.ElementIsPresent(Driver, loggedInAsXPath);
        }
    }
}
