using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V129.Page;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
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
        IWebElement form = driver.FindElement(By.XPath("//*[text()='Forms']"));
        IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
        executor.ExecuteScript("arguments[0].scrollIntoView(true);", form);
        form.Click();

        ////Using action class scroll did not worked 
        ////Actions action = new Actions(driver);
        ////action.ScrollToElement(ele);

        ////2nd Page 
        //IWebElement practiceForm = driver.FindElement(By.XPath("//*[text()='Practice Form']"));
        //practiceForm.Click();

        ////validation for 2nd page 
        //string pageTitle = driver.FindElement(By.XPath("//h1[text()='Practice Form']")).Text;
        //if (pageTitle == "Practice Form")
        //{
        //    Console.WriteLine("Navigated to correct page");
        //}
        //else
        //{
        //    Console.WriteLine("Navigated to incorrect page");
        //}

        ////Form submission
        ////Fields
        //driver.FindElement(By.Id("firstName")).SendKeys("Jenis");
        //driver.FindElement(By.Id("lastName")).SendKeys("Lawrence");
        //driver.FindElement(By.Id("userEmail")).SendKeys("Lawrencebishnoi@gmail.com");

        ////Radio Button 
        ////By Java Script executor
        //IWebElement radioMale = driver.FindElement(By.XPath("//input[@value='Male']"));
        //executor.ExecuteScript("arguments[0].click()", radioMale);
        ////By Actions Class
        //Actions action = new Actions(driver);
        ////action.SendKeys(Keys.Tab).Build().Perform();
        ////action.Click(radioMale).Build().Perform();

        //// Mobile No 
        //driver.FindElement(By.Id("userNumber")).SendKeys("9989765412");

        ////DOUBT FOR DOB
        ////driver.FindElement(By.Id("dateOfBirthInput")).SendKeys("01-01-1999");

        ////SUBJECT
        //IWebElement subject = driver.FindElement(By.XPath("//div[@id='subjectsContainer']/div/div"));
        //executor.ExecuteScript("arguments[0].scrollIntoView(true)", subject);
        //action.Click(subject).Perform();
        //action.SendKeys("H").Perform();
        //action.SendKeys(Keys.Tab).Build().Perform();

        ////Wait
        //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        //wait.Until(driver => subject.Displayed);


        ////Check Box
        //IWebElement checBox = driver.FindElement(By.XPath("//label[text()='Sports']//parent::div/input"));
        ////executor.ExecuteScript("arguments[0].scrollIntoView(true)", checBox);
        //executor.ExecuteScript("arguments[0].click()", checBox);


        ////DropDown

        //driver.FindElement(By.Id("state")).Click();
        //List<IWebElement> state = driver.FindElements(By.XPath("//div[contains(@class,'option')]")).ToList();
        ////int attempts = 0;
        //foreach (IWebElement selectState in state)
        //{

        //    {
        //        if (selectState.Text.Equals("Haryana"))
        //        {

        //            //selectState.Click();
        //            action.Click(selectState).Perform();

        //            //executor.ExecuteScript("arguments[0].click()", selectState);
        //        }
        //    }
        //    //driver.FindElement(By.Id("state")).Click();
        //    //driver.FindElement(By.XPath("//div[contains(@class,'menu')]/div/div[text()='NCR']")).Click();

        //    //Alert
        //    driver.FindElement(By.XPath("//div[text()='Alerts, Frame & Windows']")).Click();
        //    driver.FindElement(By.XPath("//span[text()='Alerts']")).Click();

        //    IWebElement btnClick = driver.FindElement(By.XPath("//button[@id='alertButton' and text()='Click me']"));
        //    btnClick.Click();
        //    //executor.ExecuteScript("arguments[0].click()", clickalert);
        //    IAlert a = driver.SwitchTo().Alert();
        //    a.Accept();


        // Frame 
        IWebElement f= driver.FindElement(By.XPath("//div[text()='Alerts, Frame & Windows']"));
        f.Click();
        executor.ExecuteScript("arguments[0].scrollIntoView(true);", f);
        driver.FindElement(By.XPath("//span[text()='Frames']")).Click();
        driver.SwitchTo().Frame(driver.FindElement(By.Id("frame1")));
        IWebElement Ftext = driver.FindElement(By.Id("sampleHeading"));
        Console.WriteLine( Ftext.Text );
        driver.SwitchTo().ParentFrame();

        //Window Handel 





        }





    }

