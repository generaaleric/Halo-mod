using Terraria;
using Terraria.ModLoader;

namespace halo.Items.equipables
{
	[AutoloadEquip(EquipType.Legs)]
	public class MjolnirMarkVIBlueBoots : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Mjolnir MarkVI Boots blue");
			Tooltip.SetDefault("The armor increases reaction speed, but you really see it when they run. turns you to a blue blur");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 35;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 1.6f;
	   	}

		public override void AddRecipes() 
		{
			//red dye
			ModRecipe recipe = new ModRecipe(mod);
	 	    recipe.AddIngredient(1198, 30);
			recipe.AddIngredient(1006, 12);
			recipe.AddIngredient(1015, 3);
			recipe.AddTile(133);
			recipe.SetResult(this);
			recipe.AddRecipe();
			//red paint
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1198, 30);
			recipe.AddIngredient(1006, 12);
			recipe.AddIngredient(1081, 1);
			recipe.AddTile(133);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
