using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace halo.Items.equipables
{
	[AutoloadEquip(EquipType.Head)]
	public class MjolnirMarkVIBlueHelm : ModItem
	{
		public override void SetStaticDefaults() {
		    DisplayName.SetDefault("Mjolnir MarkVI helmet blue");
			Tooltip.SetDefault("'Optic Quality was a great worry to scientists when creating this armor. now in blue'");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 38;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("MjolnirMarkVIBlueChestplate") && legs.type == mod.ItemType("MjolnirMarkVIBlueBoots");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "MjolnirMarkVIBlueHelm.jpg";
			player.moveSpeed += 1.6f;
			player.AddBuff(4, 2);
		}
	
		public override void AddRecipes()
		 {
			//blue dye
			ModRecipe recipe = new ModRecipe(mod);
	 		recipe.AddIngredient(1198, 15);
			recipe.AddIngredient(1006, 18);
			recipe.AddIngredient(1015, 3);
			recipe.AddTile(133);
			recipe.SetResult(this);
			recipe.AddRecipe();
			//blue paint
			recipe = new ModRecipe(mod);
	 		recipe.AddIngredient(1198, 15);
			recipe.AddIngredient(1006, 18);
			recipe.AddIngredient(1081, 1);
			recipe.AddTile(133);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
