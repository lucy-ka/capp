using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

internal class Program
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement? checkBox;

    private static void Main(string[] args)
    {
        string url = "https://testing.todorvachev.com/special-elements/check-button-test-3/";
        string option = "1";

        driver.Navigate().GoToUrl(url);

        checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(" + option + ")"));

        checkBox.Click();

        if (checkBox.GetAttribute("checked") == "true")
        {
            Console.WriteLine("The checkbox is checked!");
        }
        else
        {
            Console.WriteLine("The checkbox is not checked!");
        }

        driver.Quit();
    }

}