using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using WebDriverManager.DriverConfigs.Impl;

class Selenium
{
    public static void Main()
    {
        new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
        IWebDriver driver = new ChromeDriver();
        driver.Url = "https://demoqa.com/";
        driver.Manage().Window.Maximize();

        //1st page
        IWebElement ele1 = driver.FindElement(By.XPath("//*[text()='Forms']"));
        IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
        executor.ExecuteScript("arguments[0].scrollIntoView(true);", ele1);
        ele1.Click();

        //Using action class scroll did not worked 
        //Actions action = new Actions(driver);
        //action.ScrollToElement(ele);

        //2nd Page 
        IWebElement ele2 = driver.FindElement(By.XPath("//*[text()='Practice Form']"));
        ele2.Click();
        //validation for 2nd page 
        string title =driver.FindElement(By.XPath("//h1[text()='Practice Form']")).Text;
        if (title == "Practice Form")
        {
            Console.WriteLine("Navigated to correct page");
        }
        else
        {
            Console.WriteLine("Navigated to incorrect page");
        }   

        //Form submission
        driver.FindElement(By.Id("firstName")).SendKeys("Jenis");
        driver.FindElement(By.Id("lastName")).SendKeys("Lawrence");
        driver.FindElement(By.Id("userEmail")).SendKeys("Lawrencebishnoi@gmail.com");
       
        //By Java Script executor
        IWebElement radioMale = driver.FindElement(By.XPath("//input[@value='Male']"));
        executor.ExecuteScript("arguments[0].click()", radioMale);

        //By Actions Class
        Actions action = new Actions(driver);
        action.SendKeys(Keys.Tab).Build().Perform();
        action.Click(radioMale).Build().Perform();




    }
}