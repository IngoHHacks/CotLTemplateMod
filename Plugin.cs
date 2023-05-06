using System.IO;
using COTL_API.CustomInventory;
using COTL_API.CustomFollowerCommand;
using CotLTemplateMod.Items;
using CotLTemplateMod.CustomFollowerCommands;
using static InventoryItem;
    
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

        internal static ITEM_TYPE ExampleItem;

        internal static FollowerCommands FollowerCommand;

        private void Awake()
        {
            Log = Logger;
            PluginPath = Path.GetDirectoryName(Info.Location);

            ExampleItem = CustomItemManager.Add(new ExampleItem());
            FollowerCommand = CustomFollowerCommandManager.Add(new ExampleFollowerCommand());
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