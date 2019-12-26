using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using prismmodmusic;

namespace prismmodmusic.Items.Pianos
{
    class PrismachinePiano : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Prismachine Piano");
            Tooltip.SetDefault("Plays a piano version of the Prismachine Theme");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 28;
            item.maxStack = 1;
            item.useStyle = 1;
            item.useAnimation = 15;
            item.useTime = 10;
            item.createTile = ModContent.TileType<Tiles.PrismachinePianoTile>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.WorkBenches);
            recipe.AddIngredient(TileID.Pianos, 1);
            Mod prismmod = ModLoader.GetMod("prismmod");
            recipe.AddIngredient(prismmod.GetItem("PrismaticChunk"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }


}