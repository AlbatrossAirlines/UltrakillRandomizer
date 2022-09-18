using BepInEx;

namespace UltrakillRandomizer;

[BepInPlugin("al.ultrakillrandomizer", "UltrakillRandomizer", "1.0.0")]
public class Plugin : BaseUnityPlugin
{
    private void Awake()
    {
        // Plugin startup logic
        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
    }
}
