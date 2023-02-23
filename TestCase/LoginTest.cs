using AutomationProject_02.PageObject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject_02.TestCase
{
    // Clase que contiene los casos de prueba del login
    public class LoginTest : BaseTest
    {
        // Metodo que implementa el caso de prueba de registrarse. Resultado esperado que el usuario se redireccione al formulario de registro correctamente
        [Test]
        public void Test_001_SuccessfulLogin()
        {
            LoginPage principalPage = new LoginPage(Driver);
            PrincipalPage _principalPage = principalPage.LoginAs("testnel@mail.com", "123456");
            Assert.IsTrue(_principalPage.LoggedAsIsPresent());
        }
    }
}