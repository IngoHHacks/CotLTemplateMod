using COTL_API.CustomInventory;
using System.IO;

namespace CotLTemplateMod.Items
{
    internal class ExampleItem : CustomInventoryItem
    {
        public override string InternalName => "Example_Item";
        public override string LocalizedName() { return "Example Item"; }
        public override string LocalizedDescription() { return "This is an example item"; }

        public override Sprite InventoryIcon => TextureHelper.CreateSpriteFromPath(Path.Combine(Plugin.PluginPath, "Assets", "example_item.png"));
    }
}
