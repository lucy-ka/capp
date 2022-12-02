using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

internal class Program
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement? radioButton;

    private static void Main(string[] args)
    {
        string url = "https://testing.todorvachev.com/special-elements/radio-button-test/";
        string[] option = { "1", "3", "5" };

        driver.Navigate().GoToUrl(url);
        for (int i = 0; i < option.Length; i++)
        {
            radioButton = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(" + option[i] + ")"));
            
            if (radioButton.GetAttribute("checked") == "true")
            {
                Console.WriteLine("The " + i + "radio button is checked");
            }
            else
            {
                Console.WriteLine("The " + i + "radio button is NOT checked");
            }
        }

        driver.Quit();
    }

}