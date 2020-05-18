using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace halo.Items.equipables
{
	[AutoloadEquip(EquipType.Body)]
	public class MjolnirMarkVIRedChestplate : ModItem
	{
		public override void SetStaticDefaults() 
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Mjolnir Mark VI Chestplate in red");
			Tooltip.SetDefault("Made from a titanium alloy. with a red coat " +
                "\nequiped for high temparature engagements");
		}

		public override void SetDefaults() 
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 60;
		}
		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
		}

		public override void AddRecipes() 
		{
			//red dye
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1198, 40);
			recipe.AddIngredient(1006, 30);
			recipe.AddIngredient(1011, 15);
			recipe.AddTile(133);
			recipe.SetResult(this);
			recipe.AddRecipe();
			//red paint
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1198, 30);
			recipe.AddIngredient(1006, 12);
			recipe.AddIngredient(1073, 3);
			recipe.AddTile(133);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
