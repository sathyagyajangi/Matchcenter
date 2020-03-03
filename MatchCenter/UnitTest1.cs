using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace MatchCenter
{
    [TestClass]
    public class UnitTest1
    {
        private int oCount;
        private bool k;

        [TestMethod]
        public void TestMethod1()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("no-sandbox");


            ChromeDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(5));

            driver.Manage().Timeouts().PageLoad.Add(TimeSpan.FromMinutes(5));


            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://cricket.yahoo.net/fixtures-results/commentary/bahrain-vs-qatar-match-11-25th-february-2020-live-scores-bhrqt02252020194316");


            FunctionLibrary.waitForElement(driver, "//*[@class='si-data si-teamA si-active']/span/em[3]/em/em");
            string overs = driver.FindElement(By.XPath("//*[@class='si-data si-teamA si-active']/span/em[3]/em/em")).Text;



            Console.WriteLine(overs);
        

            string ove1 = (overs.Substring(1, 2));

            Console.WriteLine(ove1);

            string ove2 = overs.Substring(4, 1);

            Console.WriteLine(ove2);

            int over1 = Convert.ToInt32(ove1);

            int over2 = Convert.ToInt32(ove2);


                int oCount = over1 * 6 + over2;
            Console.WriteLine(over1 * 6 + over2);

            
   

            FunctionLibrary.ScrollToBottomMC(driver);

            int overcount1 = driver.FindElements(By.XPath("//*[@data-sourceid='2']")).Count;

            int CC = Convert.ToInt32(overcount1);

            Console.WriteLine(overcount1);

            int wides = CC - oCount;

            Console.WriteLine(wides);

             
            
      

        }

        [TestMethod]
        public void commentary()
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("no-sandbox");


            ChromeDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(5));

            driver.Manage().Timeouts().PageLoad.Add(TimeSpan.FromMinutes(5));


            // driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromMinutes(10));
            //IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://cricket.yahoo.net/fixtures-results/commentary/sri-lanka-vs-west-indies-2nd-odi-26th-february-2020-live-scores-slwi02262020194161");


          int bcount=  FunctionLibrary.ballCount(driver, "//*[@class='si-data si-teamA si-active']/span/em[3]/em/em");


            FunctionLibrary.ScrollToBottomMC(driver);

            int overcount1 = driver.FindElements(By.XPath("//*[@data-sourceid='2']")).Count;

            int tcount = Convert.ToInt32(overcount1);

            Console.WriteLine(tcount - bcount);

            for(int i=tcount;i<=tcount;i--)
            {

                //*[text()='wd']

              string text=  driver.FindElement(By.XPath("//div[@data-sourceid='2'][" + i + "]/div/div/div[2]")).Text;



                Console.WriteLine(text);
              
               /* if (text.Contains("WD"))
                {

                   for(int j=1;j<=tcount;j++)
                    {

                        Console.WriteLine(j);
                    }




                }
               
               
              */

            }


         
        }


        [TestMethod]

        public void extras()

        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("no-sandbox");

           
            ChromeDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(5));

            driver.Manage().Timeouts().PageLoad.Add(TimeSpan.FromMinutes(5));


            // driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromMinutes(10));
            //IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://cricket.yahoo.net/fixtures-results/commentary/sri-lanka-women-vs-bangladesh-women-match-17-2nd-march-2020-live-scores-slwbw03022020189680");

            Thread.Sleep(3000);

          int bcount=  FunctionLibrary.ballCount(driver, "/html/body/div[1]/div/myapp/section[2]/div/div/div/div[1]/div/section/div/div/div/div[1]/div[1]/div[2]/div[1]/span/em[3]/em/em[1]");


            Console.WriteLine(bcount);

            FunctionLibrary.ScrollToBottomMC(driver);


          int count=  driver.FindElements(By.XPath("//*[@class='si-overs']")).Count;

            Console.WriteLine(count);

         int bCt=   Convert.ToInt32(bcount);

            int aCt = Convert.ToInt32(count);

            int extras = aCt - bCt;


            Console.WriteLine("Extras =" + extras);

        int pollcount= driver.FindElements(By.XPath("//*[@data-sourceid='11']")).Count;

            Console.WriteLine("poll count " + pollcount);


          FunctionLibrary.clickAction(driver, "/html/body/div[1]/footer/section/footer/div[2]/span", "xpath");

            Thread.Sleep(2000);

            for (int i=1; i<=500;i++)
            {

             // if(driver.FindElement(By.XPath("//*[text()='Fan Shout']")))
  
              //  FunctionLibrary.waitForElement(driver, "//*[text()='0.1']");

               

             //   IWebElement element = driver.FindElement(By.XPath("//*[text()='0.1']"));

              string id=  driver.FindElement(By.XPath("//*[@class='si-comm-wrp si-border']/div[" + i + "]")).GetAttribute("data-sourceid");

                if(id.Contains("2"))

                {

                    FunctionLibrary.MouseOver(driver, "//*[@class='si-comm-wrp si-border']/div[" + i + "]");

                string  txt=  FunctionLibrary.ElementText(driver, "//*[@class='si-comm-wrp si-border']/div[" + i + "]");

                    Console.WriteLine(txt);

                    if(txt.Contains("0.1"))
                    {

                        break;
                    }
                }
      /*
               if (element.Displayed)

                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,-500)");


                    FunctionLibrary.waitForElement(driver, "/html/body/div[1]/div/myapp/section[2]/div/div/div/div[1]/div/section/div/div/div/div[2]/div[3]/div[3]/div[" + i + "]/div/div[1]/div[1]/div");

                    FunctionLibrary.MouseOver(driver, "/html/body/div[1]/div/myapp/section[2]/div/div/div/div[1]/div/section/div/div/div/div[2]/div[3]/div[3]/div[" + i + "]/div/div[1]/div[1]/div");

                    string wides = driver.FindElement(By.XPath("/html/body/div[1]/div/myapp/section[2]/div/div/div/div[1]/div/section/div/div/div/div[2]/div[3]/div[3]/div[" + i + "]/div/div[1]/div[1]/div")).Text;

                    Console.WriteLine(wides);
                }

              else
                {


                    FunctionLibrary.waitForElement(driver, "//*[@data-sourceid='11']");

                        FunctionLibrary.MouseOver(driver, "//*[@data-sourceid='11']");

                        bool flag = driver.FindElement(By.XPath("//*[@data-sourceid='11']")).Displayed;

                        Console.WriteLine(flag);

                    if (flag.Equals("True"))
                        {



                        ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,-500)");

                    }
                }
                */
            }
            
        }


       [TestMethod]

       public void temp()
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("no-sandbox");


            ChromeDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(5));

            driver.Manage().Timeouts().PageLoad.Add(TimeSpan.FromMinutes(5));



            FunctionLibrary.ScrollToBottomMC(driver);




        }
    }
}
