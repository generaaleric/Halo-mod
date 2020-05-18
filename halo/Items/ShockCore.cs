using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace halo.Items
{
    public class ShockCore : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shock Core");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 1;
        }

    }
}
