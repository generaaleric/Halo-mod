using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace halo.Items
{
    public class TitaniumA : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Titanium A plating.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 3;
            
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
	 	    recipe.AddIngredient(1198);
	 	    recipe.AddTile(133);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
