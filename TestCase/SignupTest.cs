using AutomationProject_02.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject_02.TestCase
{
    // Clase que contiene los casos de prueba del SignUp
    [TestFixture]
    public class SignupTest : BaseTest
    {
        // Metodo que implementa el caso de prueba de registrarse. Resultado esperado que el usuario se redireccione al formulario de registro correctamente
        [Test]
        public void Test_002_SuccessfulSignup()
        {
            LoginPage signupPage = new LoginPage(Driver);
            SignupPage _signupPage = signupPage.SignupAs("nels", "nels@mail.com");

            Assert.IsTrue(_signupPage.FormIsPresentSignup());
        }

        // Metodo para crear una nueva cuenta, llenando el formulario de registro. Retorna la pagina cuenta creada
        [Test]
        public void Test_003_SuccessAccountCreat()
        {
            LoginPage signupPage = new LoginPage(Driver);
            SignupPage _signupPage = signupPage.SignupAs("nel", "nel@mail.com");

            Assert.IsTrue(_signupPage.FormIsPresentSignup());

            AccountCreatePage _accountCreate = _signupPage.AccountCreateAs("Mr.", "123456", "10", "June", "1986", "Nelson", "Vince", "Company", "Av. Cabildo", "Cabildo 1200", "India", "Estado de india", "Ciudad", "6500", "25412541");

            Assert.IsTrue(_accountCreate.AccountCreatIsPresent());
        }
    }
}
