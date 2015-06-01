using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using Selenium;
using Microsoft.ClearScript;
using Microsoft.ClearScript.Windows;

namespace UnitTestProject
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class SeleniumTests
    {
        IWebDriver driver = null;
        public SeleniumTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1(string URL)
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(URL);

            

           
        }


        [TestMethod]
        public void QuitDriver()
        {
            
            driver.Close();


        }


        Dictionary<string, Type> importedTypes = new Dictionary<string, Type>()
        {
            // OpenQA.Selenium:
            {"By", typeof(OpenQA.Selenium.By)},
            {"Keys", typeof(OpenQA.Selenium.Keys)},

            // OpenQA.Selenium.Interactions:
            {"Actions", typeof(OpenQA.Selenium.Interactions.Actions)},
            {"TouchActions", typeof(OpenQA.Selenium.Interactions.TouchActions)},
        };


        private void ImportTypes(JScriptEngine engine)
        {
            foreach (KeyValuePair<string, Type> pair in importedTypes)
            {
                engine.AddHostType(pair.Key, pair.Value);
            }
        }

       


        public string ExecuteScript(string code)
        {
            using (var engine = new JScriptEngine())
            {
                engine.AddHostObject("driver", driver);


                ImportTypes(engine);

                // var uiPageObject = Presenters.PageObjectDefinitionPresenter.GetWebElementDefinitionFromTree();


                //foreach (var element in uiPageObject.Items)
                //{
                //    IWebElement proxyElement = SwdBrowser.CreateWebElementProxy(element);
                //    string name = element.Name;
                //    engine.AddHostObject(name, proxyElement);
                //}

                var result =  engine.Evaluate(code);
                return result.ToString();
            }

        }




        [TestMethod]
        public string HighlightElement(string by, string locator)
        {

            try
            {
              
                //driver = new RemoteWebDriver(uri, DesiredCapabilities.Firefox());

                //Id
                //Name
                //CSSSelector
                //XPath
                //LinkText
                //PartialLinkText
                //TagName


                By bylocator = GetLocator(by, locator);


                var elementCollection = driver.FindElements(bylocator);

                int count = elementCollection.Count;
                IJavaScriptExecutor js = (IJavaScriptExecutor) driver;
                foreach (var webElement in elementCollection)
                {
                    js.ExecuteScript("arguments[0].style.border='3px solid red'", webElement);
                }

              
                return count.ToString();

            }
            catch(Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
                return ex.ToString();
            }

        }


        [TestMethod]
        public string RemoveHighlightElement(string by, string locator)
        {

            try
            {

                //driver = new RemoteWebDriver(uri, DesiredCapabilities.Firefox());

                //Id
                //Name
                //CSSSelector
                //XPath
                //LinkText
                //PartialLinkText
                //TagName


                By bylocator = GetLocator(by, locator);


                var elementCollection = driver.FindElements(bylocator);

                int count = elementCollection.Count;
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                foreach (var webElement in elementCollection)
                {
                    js.ExecuteScript("arguments[0].style.border='0px none'", webElement);
                }


                return count.ToString();

            }
            catch (Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
                return ex.ToString();
            }

        }







        [TestMethod]
        public string HighlightChildElement(string by, string locator,string index,string byChild,string locatorChild)
        {

            try
            {

                //driver = new RemoteWebDriver(uri, DesiredCapabilities.Firefox());

                //Id
                //Name
                //CSSSelector
                //XPath
                //LinkText
                //PartialLinkText
                //TagName


                By bylocator = GetLocator(by, locator); 
                By bylocatorChild = GetLocator(byChild, locatorChild);
                int indexlocation = int.Parse(index);

                var elementCollection = driver.FindElements(bylocator)[indexlocation].FindElements(bylocatorChild);

                int count = elementCollection.Count;
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                foreach (var webElement in elementCollection)
                {
                    js.ExecuteScript("arguments[0].style.border='3px solid red'", webElement);
                }

                return count.ToString();

            }
            catch (Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
                return ex.ToString();
            }

        }

        [TestMethod]
        public string Highlight(string by, string locator, string byChild, string locatorChild)
        {

            try
            {
                By bylocator = GetLocator(by, locator);
                By bylocatorChild = GetLocator(byChild, locatorChild);


                var elementCollection = driver.FindElement(bylocator).FindElements(bylocatorChild);

                int count = elementCollection.Count;
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                foreach (var webElement in elementCollection)
                {
                    js.ExecuteScript("arguments[0].style.border='3px solid red'", webElement);
                }

                return count.ToString();

            }
            catch (Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
                return ex.ToString();
            }

        }


        private static By GetLocator(string by, string locator)
        {
            By bylocator = null;
            switch (by)
            {
                case "Id":
                    bylocator = By.Id(locator);
                    break;

                case "Name":
                    bylocator = By.Name(locator);
                    break;

                case "CSSSelector":
                    bylocator = By.CssSelector(locator);
                    break;

                case "XPath":
                    bylocator = By.XPath(locator);
                    break;

                case "LinkText":
                    bylocator = By.LinkText(locator);
                    break;

                case "PartialLinkText":
                    bylocator = By.PartialLinkText(locator);
                    break;


                case "TagName":
                    bylocator = By.TagName(locator);
                    break;


                case "ClassName":
                    bylocator = By.ClassName(locator);
                    break;

                default:
                    break;

            }
            return bylocator;
        }


    }
}
