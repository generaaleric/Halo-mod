using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace halo.Items.weapons
{
	public class Magnum : ModItem
	{
		public override void SetStaticDefaults()
		 {
			Tooltip.SetDefault("'maby a little to overpowerd :D'");
			DisplayName.SetDefault("M6G");
		 }

		public override void SetDefaults() {
			item.damage = 1170;
			item.ranged = true;
			item.width = 42;
			item.height = 20;
			item.useTime = 45;
			item.useAnimation = 45;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 20;
			item.UseSound = SoundID.Item11;
			item.autoReuse = false;
			item.shootSpeed = 40;
			item.shoot = 284;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod,"TitaniumA", 20);
			recipe.AddIngredient(mod,"TitaniumB", 15);
			recipe.AddIngredient(98);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


		// Help, my gun isn't being held at the handle! Adjust these 2 numbers until it looks right.
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-3, 0);
		}

		// How can I make the shots appear out of the muzzle exactly?
		// Also, when I do this, how do I prevent shooting through tiles?
		/*public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 25f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			return true;
		}*/

	
	
	}
}
