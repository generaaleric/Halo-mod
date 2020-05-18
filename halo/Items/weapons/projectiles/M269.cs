using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace halo.Items.weapons.projectiles
{
	public class M269 : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("M296 SC 8 Gauge Magnum shells.");
		}

		public override void SetDefaults() {
			item.damage = 30;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 10f;
			item.value = 10;
			item.rare = 2;
			item.shoot = mod.ProjectileType("M269Projectile");   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 16f;                  //The speed of the projectile
			item.ammo = mod.ItemType("M269");            //The ammo class this ammo belongs to.
		}
		

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MusketBall, 50);
			recipe.AddIngredient(ItemID.LeadBar, 2);
			recipe.AddTile(134);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}
