using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace JenkinsDockerTestNunit
{
    public class Tests
    {
        IWebDriver driver { get; set; }

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
            IWebElement barat = driver.FindElement(By.XPath("//img[contains(@alt, 'Barátság')]"));

            string indexvas = barat.GetAttribute("src");

            Assert.IsTrue(indexvas.Contains("indexvas"));
        }

        [Test] public void Test2()
        {
            bool x = true;

            Assert.IsTrue(x);
        }
    }
}