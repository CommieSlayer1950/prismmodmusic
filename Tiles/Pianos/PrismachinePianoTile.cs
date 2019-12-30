/*using Microsoft.Xna.Framework;
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

        public override void PlaceInWorld(int i, int j, Item item)
        {
            Main.tile[i, j].frameY = 0;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("PrismachinePiano"));
            if (Main.tile[i, j].frameY == 1)
            { 
                
            }
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (Main.tile[i, j].frameY == 1)
            {
                Main.LocalPlayer.GetModPlayer<PrismMusicPlayer>().prismachinePianoSong = true;
            }
            else 
            {
                Main.LocalPlayer.GetModPlayer<PrismMusicPlayer>().prismachinePianoSong = false;
            }
        }

        public override bool NewRightClick(int i, int j)
        {
            if (Main.tile[i, j].frameY == 1)
            {
                Main.tile[i, j].frameY = 0;
            }
            else
            {
                Main.tile[i, j].frameY = 1;
            }
            
            return true;
        }
    }
}*/