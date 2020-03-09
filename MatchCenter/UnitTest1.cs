using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

using System.Threading;
using OpenQA.Selenium.Interactions;
using System.Linq;

namespace MatchCenter
{
    [TestClass]
    public class UnitTest1
    {
        
        

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

              string text=  driver.FindElement(By.XPath("//div[@data-sourceid='2'][" + i + "]/div/div/div/div")).Text;



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

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://cricket.yahoo.net/fixtures-results/commentary/sri-lanka-women-vs-bangladesh-women-match-17-2nd-march-2020-live-scores-slwbw03022020189680");

            Thread.Sleep(3000);

            string ballcount = driver.FindElement(By.XPath("/html/body/div[1]/div/myapp/section[2]/div/div/div/div[1]/div/section/div/div/div/div[1]/div[1]/div[2]/div[1]/span/em[3]/em/em[1]")).Text;

            string count1 = (ballcount.Substring(1, 2));

            int c1 = Convert.ToInt32(count1);

            string count2 = ballcount.Substring(4, 1);

            string overcount = count1+"."+count2;


            Console.WriteLine(overcount);

            int bcount = FunctionLibrary.ballCount(driver, "/html/body/div[1]/div/myapp/section[2]/div/div/div/div[1]/div/section/div/div/div/div[1]/div[1]/div[2]/div[1]/span/em[3]/em/em[1]");


            Console.WriteLine(bcount);

            FunctionLibrary.ScrollToBottomMC(driver);


            int count = driver.FindElements(By.XPath("//*[@class='si-overs']")).Count;

            Console.WriteLine(count);

            int bCt = Convert.ToInt32(bcount);

            int aCt = Convert.ToInt32(count);

            int extras = aCt - bCt;


            Console.WriteLine("Extras =" + extras);

            int pollcount = driver.FindElements(By.XPath("//*[@data-sourceid='11']")).Count;

            Console.WriteLine("poll count " + pollcount);


            try
            { 
            for (int i =0; i <=c1; i++)
            {
                for (int j = 1; j<=6; j++)
                {
                   String s=i+"."+j;

                    FunctionLibrary.waitForElement(driver, "//*[@class='si-overs'and text()='" + s + "']");


                string overs=FunctionLibrary.ElementText(driver, "//*[@class='si-overs'and text()='" + s + "']");

                    //    Console.WriteLine(overs);
                  

                        if (s.Equals(overs))
                        {

                            Console.WriteLine(s + " Ball passed");


                        }

                        if (s.Contains(overcount))
                        {

                            break;
                        }
                    }
                
                    }

              
            }

            catch
            {

                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

                ss.SaveAsFile(@"D:\ScreenShot");
            }




        }

        [TestMethod]
        public void match()
        {
         //   IWebDriver driver = new ChromeDriver();
          ChromeOptions options = new ChromeOptions();
           options.AddArguments("no-sandbox");


           ChromeDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(5));

           driver.Manage().Timeouts().PageLoad.Add(TimeSpan.FromMinutes(5));

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://cricket.yahoo.net/fixtures-results/commentary/south-africa-vs-australia-2nd-odi-4th-march-2020-live-scores-saau03042020190852");



            string ballcount = driver.FindElement(By.XPath("//*[@class='si-ove']")).Text;

           
            string count1 = (ballcount.Substring(1, 2));

            Console.WriteLine(count1);

            int c1 = Convert.ToInt32(count1);

            string count2 = ballcount.Substring(4, 1);

            string overcount = count1 + "." + count2;


            FunctionLibrary.ScrollToBottomMC(driver);

            Thread.Sleep(2000);


            try
            {
                for (int i = 0; i <= c1; i++)
                {
                    for (int j = 1; j <= 6; j++)
                    {
                        String s = i + "." + j;

                        FunctionLibrary.waitForElement(driver, "//*[@class='si-overs'and text()='" + s + "']");


                        string overs = FunctionLibrary.ElementText(driver, "//*[@class='si-overs'and text()='" + s + "']");

                        //    Console.WriteLine(overs);
              

                        if (s.Equals(overs))
                        {

                            FunctionLibrary.waitForElement(driver, "//*[@class='si-overs'and text()='" + s + "']");

                            FunctionLibrary.MouseOver(driver,"//*[@class='si-overs'and text()='" + s + "']");
                            Console.WriteLine(s + " Ball passed");


                        }

                        if (s.Contains(overcount))
                        {

                            break;
                        }
                    }

                }
               

            }

            catch
            {

                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

                ss.SaveAsFile(@"D:\ScreenShot\image.png");
            }
        }

        [TestMethod]


        public void match1()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("no-sandbox");


            ChromeDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(5));

            driver.Manage().Timeouts().PageLoad.Add(TimeSpan.FromMinutes(5));

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://cricket.yahoo.net/fixtures-results/commentary/south-africa-vs-australia-2nd-odi-4th-march-2020-live-scores-saau03042020190852");

            FunctionLibrary.waitForElement(driver, "//*[@class='si-data-wrap']/div[1]/span/em");

     
            string countrynameA = driver.FindElement(By.XPath("//*[@class='si-data-wrap']/div[1]/span/em")).Text;

           
            FunctionLibrary.waitForElement(driver, "//*[@class='si-data-wrap']/div[3]/span/em");
            string countrynameB = driver.FindElement(By.XPath("//*[@class='si-data-wrap']/div[3]/span/em")).Text;

            FunctionLibrary.waitForElement(driver, "//*[@class='si-data-wrap']/div[1]/span/em[3]/em/em");

            string oversA = driver.FindElement(By.XPath("//*[@class='si-data-wrap']/div[1]/span/em[3]/em/em")).Text;

            FunctionLibrary.waitForElement(driver, "//*[@class='si-data-wrap']/div[3]/span/em[3]/em/em");

            string oversB = driver.FindElement(By.XPath("//*[@class='si-data-wrap']/div[3]/span/em[3]/em/em")).Text;

            string CountryA = countrynameA.ToLower();

            string CountryB = countrynameB.ToLower();

            string OversA = oversA.ToLower();

            string OversB = oversB.ToLower();


            for(int i=1;i<=2;i++)
            {
            string commTeamname= driver.FindElement(By.XPath("//*[@class='si-tabwrp si-secondary-tabwrp']/span[" + i + "]/span")).Text;

                string teamName = commTeamname.ToLower();

                if(teamName.Contains(CountryA))
                {

                  


                    FunctionLibrary.waitForElement(driver, "//*[@class='si-data-wrap']/div[1]/span/em");

                    FunctionLibrary.MouseOver(driver, "//*[@class='si-data-wrap']/div[1]/span/em");

                //  FunctionLibrary.clickAction(driver, "//*[@class='si-data-wrap']/div[1]/span/em", "xpath");

                    Thread.Sleep(3000);

                    FunctionLibrary.ScrollToBottomMC(driver);


                    //  FunctionLibrary.clickAction(driver,"/html/body/div[1]/footer/section/footer/div[2]/span","xpath");
                }


                if (teamName.Contains(CountryB))
                {

                    FunctionLibrary.waitForElement(driver, "//*[@class='si-data-wrap']/div[1]/span/em");

                    FunctionLibrary.MouseOver(driver, "//*[@class='si-data-wrap']/div[1]/span/em");

                    FunctionLibrary.clickAction(driver, "//*[@class='si-data-wrap']/div[1]/span/em", "xpath");

                    Thread.Sleep(3000);

                    FunctionLibrary.ScrollToBottomMC(driver);


                    FunctionLibrary.clickAction(driver, "/html/body/div[1]/footer/section/footer/div[2]/span", "xpath");
                }
            }
        }


        [TestMethod]
        public void matchStatus()

        {

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("no-sandbox");


            ChromeDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(5));

            driver.Manage().Timeouts().PageLoad.Add(TimeSpan.FromMinutes(5));

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://cricket.yahoo.net/fixtures-results/commentary/south-africa-vs-australia-2nd-odi-4th-march-2020-live-scores-saau03042020190852");


            FunctionLibrary.waitForElement(driver, "//*[@class='si-status']");

            string status = FunctionLibrary.ElementText(driver, "//*[@class='si-status']");

            Console.WriteLine("Match status : " + status);


         //   FunctionLibrary.waitForElement(driver, "//*[@id='commentary']");

         //   FunctionLibrary.clickAction(driver, "//*[@id='commentary']", "xpath");


            string ballcount = driver.FindElement(By.XPath("//*[@class='si-ove']")).Text;


            string count1 = (ballcount.Substring(1, 2));

            Console.WriteLine(count1);

            int c1 = Convert.ToInt32(count1);

            string count2 = ballcount.Substring(4, 1);

            string overcount = count1 + "." + count2;

            FunctionLibrary.ScrollToBottomMC(driver);

            Thread.Sleep(2000);

            /*
                             try
                             {
                                 for (int i = 0; i <=c1; i++)
                                 {
                                     for (int j = 1; j <= 6; j++)
                                     {
                                         String s = i + "." + j;

                                         FunctionLibrary.waitForElement(driver, "//*[@class='si-overs'and text()='" + s + "']");


                                         string overs = FunctionLibrary.ElementText(driver, "//*[@class='si-overs'and text()='" + s + "']");

                                         //    Console.WriteLine(overs);





                                         if (s.Equals(overs))
                                         {

                                             FunctionLibrary.waitForElement(driver, "//*[@class='si-overs'and text()='" + s + "']");

                                             FunctionLibrary.MouseOver(driver, "//*[@class='si-overs'and text()='" + s + "']");
                                             Console.WriteLine(s + " Ball passed");




                                         }




                                         if (s.Contains(overcount))
                                         {

                                             break;
                                         }
                                     }

                                 }


                             }

                             catch
                             {

                                 Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

                                 ss.SaveAsFile(@"D:\ScreenShot\image.png");
                             }

                 */
            FunctionLibrary.clickAction(driver, "/html/body/div[1]/footer/section/footer/div[2]/span", "xpath");


            for (int k = 1; k <= 300; k++)
            {


                // FunctionLibrary.waitForElement(driver, "//*[@data-sourceid='2'][" + k + "]/div/div/div/div");

                //string txt = FunctionLibrary.ElementText(driver, "//*[@data-sourceid='2'][" + k + "]/div/div/div/div");

                //  Console.WriteLine(txt);


                FunctionLibrary.waitForElement(driver, "//*[@class='si-comm-wrp si-border']/div[" + k + "]/div/div/div/div");

                FunctionLibrary.MouseOver(driver, "//*[@class='si-comm-wrp si-border']/div[" + k + "]/div/div/div/div");
                string txt = driver.FindElement(By.XPath("//*[@class='si-comm-wrp si-border']/div["+ k + "]/div/div/div/div")).Text;
                Console.WriteLine(txt);

            }


        }

        [TestMethod]

        public void Temp2()
        {
            IWebDriver driver = new ChromeDriver();
            
           
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://cricket.yahoo.net/fixtures-results/commentary/south-africa-vs-australia-2nd-odi-4th-march-2020-live-scores-saau03042020190852");

            Thread.Sleep(2000);


            //FunctionLibrary.ScrollToBottomMC(driver);
          //  FunctionLibrary.clickAction(driver, "/html/body/div[1]/footer/section/footer/div[2]/span", "xpath");

            for (int i=1;i<=392;i++)
            {




                FunctionLibrary.MouseOver(driver, "/html/body/div[1]/div/myapp/section[2]/div/div/div/div[1]/div/section/div/div/div/div[2]/div[3]/div[3]/div[" + i + "]/div/div[1]/div[1]/div");

                string text1 = driver.FindElement(By.XPath("/html/body/div[1]/div/myapp/section[2]/div/div/div/div[1]/div/section/div/div/div/div[2]/div[3]/div[3]/div[" + i + "]/div/div[1]/div[1]/div")).Text;

                Console.WriteLine(text1);
            }

/*
            var extras = driver.FindElements(By.CssSelector(".si-score"));
           // int count = driver.FindElements(By.XPath("//*[@class='si-dv-col si-scr-data']"));
            foreach(var e in extras)   
            {

              var wicket = e.FindElement(By.CssSelector(".si-box")).Text;

                if (wicket.Equals("W"))
                {
                    Console.WriteLine(extras);
                }


                


            }
            */
        }

        [TestMethod]

        public void MatC()
        {
            IWebDriver driver = new ChromeDriver();


            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://cricket.yahoo.net/fixtures-results/commentary/south-africa-vs-australia-2nd-odi-4th-march-2020-live-scores-saau03042020190852");

            Thread.Sleep(2000);

            FunctionLibrary.ScrollToBottomMC(driver);


            int wides = driver.FindElements(By.XPath("//*[text()='wd']")).Count;

           // int lb = driver.FindElements(By.XPath("//*[@class='si-box' and text()='lb']")).Count;

            int wkts = driver.FindElements(By.XPath("//*[@class='si-box' and text()='W']")).Count;

            int nballs = driver.FindElements(By.XPath("//*[text()='nb']")).Count;

            Console.WriteLine("wickets "+wkts);

           // Console.WriteLine("leg byes"+lb);

            Console.WriteLine("wides " +wides);

            Console.WriteLine("No balls"+nballs);


            FunctionLibrary.clickAction(driver, "/html/body/div[1]/footer/section/footer/div[2]/span","xpath");

            FunctionLibrary.clickAction(driver, "/html/body/div[1]/footer/section/footer/div[2]/span", "xpath");
            var status = driver.FindElement(By.CssSelector(".si-status")).Text;

            if (status.Contains(status))
            {

                var teamactive = driver.FindElements(By.XPath("//*[@class='si-data si-teamB si-active']"));


                foreach (var t in teamactive)
                {
                    var teams = t.FindElement(By.CssSelector(".si-info")).Text;
                    Console.WriteLine(teams);
                }
                var teamInactive = driver.FindElement(By.CssSelector(".si-info")).Text;
                Console.WriteLine(teamInactive);

               // FunctionLibrary.waitForElement(driver, "//*[@id='scorecard']");

               // FunctionLibrary.MouseOver(driver, "//*[@id='scorecard']");

                driver.FindElement(By.XPath("//*[@id='scorecard']")).Click();



            }









            //    FunctionLibrary.clickAction(driver, "//*[@class='si-tabs si-active' and @id='scorecard']", "xpath");


            FunctionLibrary.waitForElement(driver, "//*[@class='si-dv-col si-rgt-cols']/span[3]/em");

            FunctionLibrary.MouseOver(driver, "//*[@class='si-dv-col si-rgt-cols']/span[3]/em");

            string NoBalls = driver.FindElement(By.XPath("//*[@class='si-dv-col si-rgt-cols']/span[3]/em")).Text;

            int noball = Convert.ToInt32(NoBalls);

            FunctionLibrary.waitForElement(driver, "//*[@class='si-dv-col si-rgt-cols']/span[4]/em");

            FunctionLibrary.MouseOver(driver, "//*[@class='si-dv-col si-rgt-cols']/span[4]/em");

            string widescount = driver.FindElement(By.XPath("//*[@class='si-dv-col si-rgt-cols']/span[4]/em")).Text;


            int widecount = Convert.ToInt32(widescount);


            if(widecount.Equals(wides))
            {

                Console.WriteLine("wides passed ");
            }

            if(noball.Equals(nballs))
            {

                Console.WriteLine(" No balls passed");
            }

        }


        [TestMethod]

        public void Matchcenter()
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("no-sandbox");


            ChromeDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(5));

            driver.Manage().Timeouts().PageLoad.Add(TimeSpan.FromMinutes(5));

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://cricket.yahoo.net/fixtures-results/commentary/south-africa-vs-australia-2nd-odi-4th-march-2020-live-scores-saau03042020190852");



            FunctionLibrary.waitForElement(driver, "//*[@class='si-ove']");

            string ballcount = driver.FindElement(By.XPath("//*[@class='si-ove']")).Text;


            string count1 = (ballcount.Substring(1, 2));

            Console.WriteLine(count1);

            int c1 = Convert.ToInt32(count1);
            string count2 = ballcount.Substring(4, 1);

            string overcount = count1 + "." + count2;



            string status = driver.FindElement(By.XPath("//span[@class='si-status']")).Text;

            string countrynameA = driver.FindElement(By.XPath("//*[@class='si-data-wrap']/div[1]/span/em")).Text;


            FunctionLibrary.waitForElement(driver, "//*[@class='si-data-wrap']/div[3]/span/em");
            string countrynameB = driver.FindElement(By.XPath("//*[@class='si-data-wrap']/div[3]/span/em")).Text;

            FunctionLibrary.waitForElement(driver, "//*[@class='si-data-wrap']/div[1]/span/em[3]/em/em");

            string oversA = driver.FindElement(By.XPath("//*[@class='si-data-wrap']/div[1]/span/em[3]/em/em")).Text;

            FunctionLibrary.waitForElement(driver, "//*[@class='si-data-wrap']/div[3]/span/em[3]/em/em");

            string oversB = driver.FindElement(By.XPath("//*[@class='si-data-wrap']/div[3]/span/em[3]/em/em")).Text;

            string CountryA = countrynameA.ToLower();

            string CountryB = countrynameB.ToLower();





           // if (status.Contains(CountryA))
           // {

           //     FunctionLibrary.clickAction(driver, "//*[@class='si-tabwrp si-secondary-tabwrp']/span/span[1]","xpath");

           // }

           // if(status.Contains(CountryB))
           //{


           //     FunctionLibrary.clickAction(driver, "//*[@class='si-tabwrp si-secondary-tabwrp']/span[2]/span[1]", "xpath");

           // }
            try
            {
                for (int i = 0; i <= c1; i++)
                {
                    for (int j = 1; j <= 6; j++)
                    {
                        String s = i + "." + j;

                        FunctionLibrary.waitForElement(driver, "//*[@class='si-overs'and text()='" + s + "']");


                        string overs = FunctionLibrary.ElementText(driver, "//*[@class='si-overs'and text()='" + s + "']");

                        //    Console.WriteLine(overs);


                        if (s.Equals(overs))
                        {

                            FunctionLibrary.waitForElement(driver, "//*[@class='si-overs'and text()='" + s + "']");

                            FunctionLibrary.MouseOver(driver, "//*[@class='si-overs'and text()='" + s + "']");
                            Console.WriteLine(s + " Ball passed");


                        }

                        if (s.Contains(overcount))
                        {

                            break;
                        }
                    }

                }


            }

            catch
            {

                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

                ss.SaveAsFile(@"D:\ScreenShot\image.png");
            }

            int wides = driver.FindElements(By.XPath("//*[text()='wd']")).Count;

            // int lb = driver.FindElements(By.XPath("//*[@class='si-box' and text()='lb']")).Count;

            int wkts = driver.FindElements(By.XPath("//*[@class='si-box' and text()='W']")).Count;

            int nballs = driver.FindElements(By.XPath("//*[text()='nb']")).Count;

            Console.WriteLine("wickets " + wkts);

            // Console.WriteLine("leg byes"+lb);

            Console.WriteLine("wides " + wides);

            Console.WriteLine("No balls" + nballs);


            FunctionLibrary.clickAction(driver, "/html/body/div[1]/footer/section/footer/div[2]/span", "xpath");

            FunctionLibrary.clickAction(driver, "/html/body/div[1]/footer/section/footer/div[2]/span", "xpath");
            var status1 = driver.FindElement(By.CssSelector(".si-status")).Text;

            if (status.Contains(status1))
            {

                var teamactive = driver.FindElements(By.XPath("//*[@class='si-data si-teamB si-active']"));
                foreach (var t in teamactive)
                {
                    var teams = t.FindElement(By.CssSelector(".si-info")).Text;
                    Console.WriteLine(teams);
                }
                var teamInactive = driver.FindElement(By.CssSelector(".si-info")).Text;
                Console.WriteLine(teamInactive);

                // FunctionLibrary.waitForElement(driver, "//*[@id='scorecard']");

                // FunctionLibrary.MouseOver(driver, "//*[@id='scorecard']");

                driver.FindElement(By.XPath("//*[@id='scorecard']")).Click();



            }









            //    FunctionLibrary.clickAction(driver, "//*[@class='si-tabs si-active' and @id='scorecard']", "xpath");


            FunctionLibrary.waitForElement(driver, "//*[@class='si-dv-col si-rgt-cols']/span[3]/em");

            FunctionLibrary.MouseOver(driver, "//*[@class='si-dv-col si-rgt-cols']/span[3]/em");

            string NoBalls = driver.FindElement(By.XPath("//*[@class='si-dv-col si-rgt-cols']/span[3]/em")).Text;

            int noball = Convert.ToInt32(NoBalls);

            FunctionLibrary.waitForElement(driver, "//*[@class='si-dv-col si-rgt-cols']/span[4]/em");

            FunctionLibrary.MouseOver(driver, "//*[@class='si-dv-col si-rgt-cols']/span[4]/em");

            string widescount = driver.FindElement(By.XPath("//*[@class='si-dv-col si-rgt-cols']/span[4]/em")).Text;


            int widecount = Convert.ToInt32(widescount);


            if (widecount.Equals(wides))
            {

                Console.WriteLine("wides passed ");
            }

            if (noball.Equals(nballs))
            {

                Console.WriteLine(" No balls passed");
            }

        }
    }
}
