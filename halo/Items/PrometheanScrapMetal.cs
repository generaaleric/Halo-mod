using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace halo.Items
{
    public class PrometheanScrapMetal : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Promethean Scrap Metal");
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
		   recipe.AddIngredient(ItemID.CopperOre, 10);
		   recipe.AddIngredient(mod,"PrometheanSteel", 10);
		   recipe.AddTile(17);
		   recipe.SetResult(this, 10);
           recipe.AddRecipe();
        }
    }
}
