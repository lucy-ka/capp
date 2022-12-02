using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

internal class Program
{
    private static void Main(string[] args)
    {
        string url = "https://testing.todorvachev.com/selectors/css-path/";
        string cssPath = "#post-108 > div > fig img";
        string xPath = "//*[@id=\"post-108\"]/div/figure/img";

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

        try
        {
            IWebElement cssPathElement = driver.FindElement(By.CssSelector(cssPath));
            if (cssPathElement.Displayed)
            {
                GreenMessage("Yes! Element found by css path!");
            }     
        }
        catch (NoSuchElementException)
        {
            RedMessage("Something is wrong! Element not found by css path!");
        }

        if (xPathElement.Displayed)
        {
            GreenMessage("Yes! Element found by X Path!");
        }
        else
        {
            RedMessage("Something is wrong! Element not found by X ath!");
        }

        driver.Quit();
    }

    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}