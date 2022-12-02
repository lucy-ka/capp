using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

internal class Program
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement? dropDownMenu;
    static IWebElement? FromDropDown;

    private static void Main(string[] args)
    {
        string url = "https://testing.todorvachev.com/special-elements/drop-down-menu-test/";
        string DropDownElement = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";

        driver.Navigate().GoToUrl(url);

        dropDownMenu = driver.FindElement(By.Name("DropDownTest"));

        Console.WriteLine("The selector value is: " + dropDownMenu.GetAttribute("value"));

        FromDropDown = driver.FindElement(By.CssSelector(DropDownElement));

        Console.WriteLine("Third option is: " + FromDropDown.GetAttribute("value"));

        FromDropDown.Click();

        Console.WriteLine("Selected value is: " + dropDownMenu.GetAttribute("value"));

        Thread.Sleep(3000);

        for (int i = 1; i <= 4; i++) 
        {
            string DropDownElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(" + i + ")";
            FromDropDown = driver.FindElement(By.CssSelector(DropDownElements));
            Console.WriteLine("The " + i + " option is: " + FromDropDown.GetAttribute("value"));
        }

        Thread.Sleep(3000);

        driver.Quit();
    }

}