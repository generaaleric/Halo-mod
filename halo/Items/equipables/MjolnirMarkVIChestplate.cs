using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace halo.Items.equipables
{
	[AutoloadEquip(EquipType.Body)]
	public class MjolnirMarkVIChestplate : ModItem
	{
		public override void SetStaticDefaults() 
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Mjolnir MarkVI Chestplate");
			Tooltip.SetDefault("Made from a titanium alloy.");
		}

		public override void SetDefaults() 
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 60;
		}
		public override void AddRecipes() 
		{
			//green dye
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1198, 40);
			recipe.AddIngredient(1006, 30);
			recipe.AddIngredient(1011, 15);
			recipe.AddTile(133);
			recipe.SetResult(this);
			recipe.AddRecipe();
            //green paint
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1198, 40);
			recipe.AddIngredient(1006, 30);
			recipe.AddIngredient(1077, 3);
			recipe.AddTile(133);
			recipe.SetResult(this);
			recipe.AddRecipe();	
		}
	}
}
