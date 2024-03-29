using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;

namespace VideoProject.Core
{
    public class Begin : DSL
    {
        private void AbreNavegador()
        {
            #region C�digo do Abre Navegador
            var headlessMode = new ChromeOptions();
            headlessMode.AddArgument("window-size=1366x768");
            headlessMode.AddArgument("disk-cache-size=0");
            headlessMode.AddArgument("headless");

            var devMode = new ChromeOptions();
            devMode.AddArgument("disk-cache-size=0");
            devMode.AddArgument("start-maximized");

            if (headlessTest) { driver = new ChromeDriver(headlessMode); }
            else { driver = new ChromeDriver(devMode); driverQuit = false; }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        #endregion
        
        #region Setup
        [SetUp]
        public void InicioTeste()
        {
            AbreNavegador();
            driver.Navigate().GoToUrl("https://buscacepinter.correios.com.br");
        }
        #endregion


        #region TearDown
        [TearDown]
        public void FimDoTeste()
        {
            if (driverQuit) driver.Quit();
        }
        #endregion
    }
}