using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;


namespace halo.Items.weapons
{
	public class BattleRifle : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("BR55 DMR, used by medium range unsc snipers, fires a three round burst");
			DisplayName.SetDefault("BR55 DMR");
		}

		public override void SetDefaults()
		{
			item.damage = 56;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 4;
			item.useAnimation = 12;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item41;
			item.autoReuse = false;
			item.shoot = 14; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 24f;
			item.useAmmo = AmmoID.Bullet;
			item.reuseDelay = 14;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod,"TitaniumA", 30);
			recipe.AddIngredient(mod,"TitaniumC", 18);
			recipe.AddIngredient(434);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


		// What if I wanted multiple projectiles in a even spread? (Vampire Knives) 
		// Even Arc style: Multiple Projectile, Even Spread 
		/*public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 3 + Main.rand.Next(3); // 3, 4, or 5 shots
			float rotation = MathHelper.ToRadians(45);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}*/

		// Help, my gun isn't being held at the handle! Adjust these 2 numbers until it looks right.
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-15, 0);
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

		// How can I get a "Clockwork Assault Rifle" effect?
		// 3 round burst, only consume 1 ammo for burst. Delay between bursts, use reuseDelay
		/*	The following changes to SetDefaults()
		 	item.useAnimation = 12;
			item.useTime = 4;
			item.reuseDelay = 14;
		public override bool ConsumeAmmo(Player player)
		{
			// Because of how the game works, player.itemAnimation will be 11, 7, and finally 3. (UseAmination - 1, then - useTime until less than 0.) 
			// We can get the Clockwork Assault Riffle Effect by not consuming ammo when itemAnimation is lower than the first shot.
			return !(player.itemAnimation < item.useAnimation - 2);
		}*/
	}
}