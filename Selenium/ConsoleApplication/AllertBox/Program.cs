using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

internal class Program
{
    static IWebDriver driver = new ChromeDriver();
    static IAlert? alert;
    static IWebElement? image;

    private static void Main(string[] args)
    {
        string url = "https://testing.todorvachev.com/special-elements/alert-box/";

        driver.Navigate().GoToUrl(url);

        alert = driver.SwitchTo().Alert();

        Console.WriteLine(alert.Text);

        alert.Accept();

        image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));

        try
        {
            if (image.Displayed)
            {
                Console.WriteLine("Allert accepted! I see image!");
            }
        }
        catch(NoSuchElementException) 
        {
            Console.WriteLine("Something is wrong!");
        }

        Thread.Sleep(3000);
        
        driver.Quit();
    }

}