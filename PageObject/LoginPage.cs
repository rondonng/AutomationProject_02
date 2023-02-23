using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject_02.PageObject
{
    // Clase para representar la pagina de Login
    public class LoginPage : BasePage
    {
        // Localizadores. Elementos de la pagina
        // Login to your account
        protected string loginTitleXPath = "//div[@class='login-form']/h2";
        protected string loginEmailXPath = "//input[@data-qa='login-email']";
        protected string loginPasswordXPath = "//input[@data-qa='login-password']";
        protected string loginButtonXPath = "//button[@data-qa='login-button']";
        // New User Signup!
        protected string signupTitleXPath = "//div[@class='signup-form']/h2";
        protected string signupNameXPath = "//input[@data-qa='signup-name']";
        protected string signupEmailXPath = "//input[@data-qa='signup-email']";
        protected string signupButtonXPath = "//button[@data-qa='signup-button']";

        // Constructor. Validación de la pagina, lanza excepción si no es el titulo de la pagina de login
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
            if (!Driver.Title.Equals("Automation Exercise - Signup / Login"))
                throw new Exception("No es la pagina de login");
        }

        // Metodo para ingresar el email en el login
        public void TypeEmailLogin(string email)
        {
            Driver.FindElement(By.XPath(loginEmailXPath)).SendKeys(email);
        }

        // Metodo para ingresar el password en el login
        public void TypePasswordLogin(string password)
        {
            Driver.FindElement(By.XPath(loginPasswordXPath)).SendKeys(password);
        }

        // Metodo para hacer click en el boton de login
        public void ClickButtonLogin()
        {
            Driver.FindElement(By.XPath(loginButtonXPath)).Click();
        }

        // Metodo para ingresar el nombre en el signup
        public void TypeNameSignup(string name)
        {
            Driver.FindElement(By.XPath(signupNameXPath)).SendKeys(name);
        }

        // Metodo para ingresar el email en el signup
        public void TypeEmailSignup(string email)
        {
            Driver.FindElement(By.XPath(signupEmailXPath)).SendKeys(email);
        }

        // Metodo para hacer click en el boton de signup
        public void ClickButtonSignup()
        {
            Driver.FindElement(By.XPath(signupButtonXPath)).Click();
        }

        // Metodo para ir a registrarse. Retorna la pagina SignUp
        public SignupPage SignupAs(string name, string email)
        {
            TypeNameSignup(name);
            TypeEmailSignup(email);
            ClickButtonSignup();
            return new SignupPage(Driver);
        }

        // Metodo para logearse con un usuario registrado. Retorna la pagina inicial
        public PrincipalPage LoginAs(string email, string password)
        {
            TypeEmailLogin(email);
            TypePasswordLogin(password);
            ClickButtonLogin();
            return new PrincipalPage(Driver);
        }
    }
}
