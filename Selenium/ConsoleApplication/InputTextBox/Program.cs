using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

internal class Program
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement? textBox;

    private static void Main(string[] args)
    {
        string url = "https://testing.todorvachev.com/special-elements/text-input-field/";
        
        driver.Navigate().GoToUrl(url);

        textBox = driver.FindElement(By.Name("username"));

        textBox.SendKeys("Test text");

        Thread.Sleep(3000);

        Console.WriteLine(textBox.GetAttribute("maxlenght"));

        Thread.Sleep(3000);

        driver.Quit();
    }

}