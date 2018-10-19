using TechTalk.SpecFlow;

namespace Next.Browsers
{
    [Binding]
    public sealed class BrowserStack
    {
        private BrowserStackDriver bsDriver;
        private string[] tags;

        [BeforeScenario]
        [Scope(Tag = "BrowserStack")]
        public void BeforeScenario()
        {
            bsDriver = new BrowserStackDriver(ScenarioContext.Current);
            ScenarioContext.Current["bsDriver"] = bsDriver;
        }

        [AfterScenario]
        [Scope(Tag = "BrowserStack")]
        public void AfterScenario()
        {
            bsDriver.Cleanup();
        }
    }
}
