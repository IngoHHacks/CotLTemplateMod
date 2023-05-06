namespace CotLTemplateMod
{
    [BepInPlugin(PluginGuid, PluginName, PluginVer)]
    [BepInDependency("io.github.xhayper.COTL_API")]
    [HarmonyPatch]
    public class Plugin : BaseUnityPlugin
    {
        public const string PluginGuid = "IngoH.cotl.CotLTemplateMod";
        public const string PluginName = "CotLTemplateMod";
        public const string PluginVer = "1.0.0";

        internal static ManualLogSource Log;
        internal readonly static Harmony Harmony = new(PluginGuid);

        internal static string PluginPath;
        internal static FollowerCommands FollowerCommand;

        private void Awake()
        {
            Log = Logger;
        }

        private void OnEnable()
        {
            Harmony.PatchAll();
            LogInfo($"Loaded {PluginName}!");
        }

        private void OnDisable()
        {
            Harmony.UnpatchSelf();
            LogInfo($"Unloaded {PluginName}!");
        }
    }
}