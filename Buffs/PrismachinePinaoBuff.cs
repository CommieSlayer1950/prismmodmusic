using Terraria;
using Terraria.ModLoader;

namespace prismmodmusic.Buffs
{
    public class PrismachinePianoBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Prismatic Piano's Song");
            Description.SetDefault("You hear the music of a vanquished foe");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type]=true;
        }
    }
}