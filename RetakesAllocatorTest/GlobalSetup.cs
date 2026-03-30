using RetakesAllocatorCore;
using RetakesAllocatorCore.Config;
using RetakesAllocatorCore.Db;

namespace RetakesAllocatorTest;

[SetUpFixture]
public class GlobalSetup
{
    [OneTimeSetUp]
    public void Setup()
    {
        if (File.Exists("./config/config.json"))
        {
            File.Delete("./config/config.json");
        }
        Configs.Load(".", true);
        Queries.Migrate();
        Translator.Initialize(new JsonStringLocalizer("../../../../RetakesAllocator/lang"));
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        Queries.Disconnect();
    }
}

public abstract class BaseTestFixture
{
    [SetUp]
    public void GlobalSetup()
    {
        Configs.Load(".");
        Queries.Wipe();
    }
}
