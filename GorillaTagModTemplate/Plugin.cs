using BepInEx;

namespace GorillaTagModTemplate
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        public void Awake()
        {
            HarmonyLoader.ApplyPatches();
        }

        public void Start()
        {

        }

        public void OnDisable()
        {
            HarmonyLoader.RemovePatches();
        }
    }
}