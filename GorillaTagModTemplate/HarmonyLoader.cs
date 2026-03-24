using HarmonyLib;

namespace GorillaTagModTemplate
{
    public class HarmonyLoader
    {
        static bool init = false;
        static Harmony harmony;

        public static void ApplyPatches()
        {
            if (!init)
            {
                harmony = new Harmony(PluginInfo.GUID);
                harmony.PatchAll(System.Reflection.Assembly.GetExecutingAssembly());
                init = true;
            }
        }

        public static void RemovePatches()
        {
            if (init)
            {
                harmony.UnpatchSelf();
                init = false;
            }
        }
    }
}