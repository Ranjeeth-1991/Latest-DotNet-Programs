using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SauseDemoProject.Drivers;


namespace SauseDemoProject.Hooks
{
    [Binding]
    public class TestHooks
    {

        [BeforeScenario]
        public void BeforeScenario()
        {
            DriverFactory.InitDriver();
        }

        [AfterStep]
        public void AfterEachStep()
        {
            var random = new Random();
            var number = random.Next(0, 10000);
            //if (ScenarioContext.Current.TestError != null)
            //{
            string fileName = $"{ScenarioContext.Current.ScenarioInfo.Title}_{number}.png";
            ScreenshotHelper.TakeScreenshot(DriverFactory.GetDriver(), fileName);
            //}
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var step = ScenarioContext.Current.StepContext;
            if (ScenarioContext.Current.TestError == null)
            {
                ScreenshotHelper.TakeScreenshot(DriverFactory.GetDriver(), $"{ScenarioContext.Current.ScenarioInfo.Title}_Error.png");
                DriverFactory.QuitDriver();
            }

        }
    }
}
