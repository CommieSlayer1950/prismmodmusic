using Terraria.ModLoader;
using Terraria;
using prismmodmusic.Buffs;

namespace prismmodmusic
{
	public class prismmodmusic : Mod
	{
        public override void UpdateMusic(ref int music, ref MusicPriority priority)
        {
            if (Main.myPlayer == -1 || Main.gameMenu || !Main.LocalPlayer.active)
            {
                return;
            }

            /*if (Main.LocalPlayer.GetModPlayer<PrismMusicPlayer>().prismachinePianoSong)
            {
                priority = MusicPriority.BossHigh;
                music = this.GetSoundSlot(SoundType.Music, "Sounds/Music/PrismachinePiano");
            }
            else
            {
                return;
            }*/
        }
    }
}