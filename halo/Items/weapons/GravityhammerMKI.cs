using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace halo.Items.weapons
{
	public class GravityhammerMKI : ModItem
	{
		public override void SetStaticDefaults()
		{
            Tooltip.SetDefault("'Usually wielded by Brute chieftains .'");
			DisplayName.SetDefault("Gravity Hammer");
		}

		public override void SetDefaults()
		{
			item.damage = 95;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 40;
			item.useAnimation = 15;
			item.axe = 20;          //How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5
			item.hammer = 60;      //How much hammer power the weapon has
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 17;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item17;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(3, 50);
			recipe.AddIngredient(182, 4);
			recipe.AddIngredient(mod,"TriniumBar", 20);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}