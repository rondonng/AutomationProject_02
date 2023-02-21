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
        /* 
         * Selenium Driver : heredado de la clase BaseTest
         * [SetUp] : heredado de la clase BaseTest 
        */

        // Metodo que implementa el caso de prueba de registrarse. Resultado esperado que el usuario se redireccione al formulario de registro correctamente
        [Test]
        public void SuccessfulSignupTest()
        {
            LoginPage signupPage = new LoginPage(Driver);
            SignupPage _signupPage = signupPage.SignupAs("nels", "nels@mail.com");

            Assert.IsTrue(_signupPage.FormIsPresent());
        }

        // [TaerDown] : heredado de la clase BaseTest
    }
}
