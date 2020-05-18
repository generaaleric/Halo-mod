using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace halo.Items.equipables
{
	[AutoloadEquip(EquipType.Body)]
	public class MjolnirMarkVIBlueChestplate : ModItem
	{
		public override void SetStaticDefaults() 
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Mjolnir Mark VI Chestplate in blue");
			Tooltip.SetDefault("Made from a titanium alloy. with a blue coat, " +
                "\nthis armor is equiped for deep sea exploration");
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
			//red dye
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1198, 40);
			recipe.AddIngredient(1006, 30);
			recipe.AddIngredient(1015, 15);
			recipe.AddTile(133);
			recipe.SetResult(this);
			recipe.AddRecipe();
			//red paint
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1198, 30);
			recipe.AddIngredient(1006, 12);
			recipe.AddIngredient(1081, 3);
			recipe.AddTile(133);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
