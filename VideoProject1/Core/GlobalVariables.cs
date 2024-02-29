using OpenQA.Selenium;


namespace VideoProject.Core
{
    public class GlobalVariables
    {
        // Define 'driver' como trigger para os webElements
        public IWebDriver driver;

        // Define 'Fechar navegador ao final do teste' como padrão
        public bool driverQuit = true;

        //  Habilita | Desabilita modo Headless
        public bool headlessTest = true;
    }
}
