using SwiftlyS2.Shared;
using SwiftlyS2.Shared.Plugins;
using RetakesAllocatorCore;
using RetakesAllocatorCore.Config;

namespace RetakesAllocator;

[PluginMetadata(Id = "sw2.retakesallocator", Version = PluginInfo.Version, MinimumAPIVersion = "1.1.6")]
public class RetakesAllocatorPlugin : BasePlugin
{
    public RetakesAllocatorPlugin(ISwiftlyCore core) : base(core)
    {
    }

    public override void Load(bool hotReload)
    {
        var modulePath = AppContext.BaseDirectory;
        Configs.Load(modulePath, true);
        if (!Translator.IsInitialized)
        {
            Translator.Initialize(new JsonStringLocalizer(Path.Combine(modulePath, "lang")));
        }

        if (Configs.GetConfigData().MigrateOnStartup)
        {
            Db.Queries.Migrate();
        }

        Core.Logger.LogInformation("{Prefix}Loaded (SwiftlyS2 destructive migration mode)", PluginInfo.LogPrefix);
    }

    public override void Unload()
    {
        Db.Queries.Disconnect();
        Core.Logger.LogInformation("{Prefix}Unloaded", PluginInfo.LogPrefix);
    }
}
