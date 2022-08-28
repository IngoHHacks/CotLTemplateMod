﻿using HarmonyLib;
using Lamb.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CotLTemplateMod.Patches
{
    [HarmonyPatch]
    internal class ExamplePatch
    {
        // This patch adds one Example Item to the inventory whenever the inventory menu is opened
        [HarmonyPatch(typeof(InventoryMenu), nameof(InventoryMenu.OnShowStarted))]
        [HarmonyPrefix]
        public static void InventoryMenu_OnShowStarted()
        {
            Inventory.AddItem(Plugin.ExampleItem, 1, true);
        }
    }
}
