using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace JenkinsDockerTestNunit
{
    public class Tests
    {
        RemoteWebDriver driver;

        [SetUp]
        public void Setup()
        {
            var chromeOptions = new ChromeOptions();
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), chromeOptions);
            //driver = new ChromeDriver(chromeOptions);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://index.hu/");
            
        }

        [Test] public void Test2()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
        }

        [Test]
        public void Test3()
        {

            driver.Navigate().GoToUrl("https://wccftech.com/");
        }
    }
}