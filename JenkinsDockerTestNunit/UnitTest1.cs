using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace JenkinsDockerTestNunit
{
    public class Tests
    {
        WebDriver driver;

        [SetUp]
        public void Setup()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.PageLoadStrategy = PageLoadStrategy.Normal;
            //driver = new RemoteWebDriver(new Uri("http://localhost:4445/wd/hub"), chromeOptions);
            driver = new ChromeDriver(chromeOptions);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
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
    }
}