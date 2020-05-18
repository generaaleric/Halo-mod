using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace halo.Items
{
    public class PrometheanSteel : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Promethean Steel as being used by the promethean `s");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 1;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
          ModRecipe recipe = new ModRecipe(mod);
           recipe.AddIngredient(mod.ItemType("TriniumBar"), 20);
           recipe.AddIngredient(ItemID.HallowedBar, 10);
           recipe.AddTile(TileID.MythrilAnvil);
           recipe.SetResult(this, 30);
           recipe.AddRecipe();
        }
    }
}
