using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTest;

public class Tests
{
    public readonly WebDriver Driver = new ChromeDriver();

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }

    [Test]
    public void Test1()
    {
        Driver.Navigate().GoToUrl("https://google.com");
        Driver.GetScreenshot().SaveAsFile("1.png");
        Assert.That(1.Equals(1));
    }

    public static void RunCommandline(string arguments)
    {
        var process = new System.Diagnostics.Process();
        var startInfo = new System.Diagnostics.ProcessStartInfo
        {
            WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
            FileName = "cmd.exe",
            Arguments = arguments
        };
        process.StartInfo = startInfo;
        process.Start();
    }
}