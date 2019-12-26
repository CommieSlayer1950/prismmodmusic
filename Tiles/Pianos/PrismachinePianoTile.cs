using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace prismmodmusic.Tiles.Pianos
{
    public class PrismachinePianoTile : ModTile
    {
        public static bool playing=false;
        public override void SetDefaults()
        {
            Main.tileSolidTop[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = false;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
            TileObjectData.newTile.Height = 2;
            TileObjectData.newTile.Width = 3;
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16 };
            TileObjectData.addTile(Type);
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("PrismachinePiano");
            AddMapEntry(new Color(200, 200, 200), name);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("PrismachinePiano"));
        }

        public override bool NewRightClick(int i, int j)
        {
            for (int count = 0; count < Main.ActivePlayersCount; count++)
            {
                Player player = Main.player[count];
                player.GetModPlayer<PrismMusicPlayer>().prismachinePianoSong = !player.GetModPlayer<PrismMusicPlayer>().prismachinePianoSong;
            }
            return true;
        }
    }
}