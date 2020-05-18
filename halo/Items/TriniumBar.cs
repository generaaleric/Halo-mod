using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace halo.Items
{
    public class TriniumBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This is a modded item.");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 1;

        }

        public override void AddRecipes()
        {
		   ModRecipe recipe = new ModRecipe(mod);
		   recipe.AddIngredient(ItemID.HallowedBar, 20);
		   recipe.AddIngredient(1006, 20);
           recipe.AddTile(TileID.MythrilAnvil);
           recipe.SetResult(this, 40);
           recipe.AddRecipe();
        }
    }
}
