using System;
using System.IO;
using OpenQA.Selenium;

public static class ScreenshotHelper
{
    public static void TakeScreenshot(IWebDriver driver, string fileName)
    {
        var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
        var path = Path.Combine(Directory.GetCurrentDirectory(), "Screenshots");

        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);

        var filePath = Path.Combine(path, fileName);
        screenshot.SaveAsFile(filePath);
        
    }
}
