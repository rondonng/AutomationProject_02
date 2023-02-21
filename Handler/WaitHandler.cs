using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject_02.Handler
{
    // Clase para manejar las esperas explicitas
    public class WaitHandler
    {
        // Metodo para esperar por un elemento en la pagina web
        // Retorna True si encuentra el elemento, maximo 20 segundos sino retorna False
        public static bool ElementIsPresent(IWebDriver driver, string element)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                wait.Until(drv => drv.FindElement(By.XPath(element)));
                return true;
            }
            catch { }  
            return false;
        }
    }
}
