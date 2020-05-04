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

        public override void Close()
        {
            var slots = new int[] {
                GetSoundSlot(SoundType.Music, "Sounds/Music/PrismachineTheme"),
                GetSoundSlot(SoundType.Music, "Sounds/Music/Biome/WaterTown")
            };

            foreach (var slot in slots)
            {
                if (Main.music.IndexInRange(slot) && Main.music[slot]?.IsPlaying == true)
                {
                    Main.music[slot].Stop(Microsoft.Xna.Framework.Audio.AudioStopOptions.Immediate);
                }
            }

            base.Close();
        }
    }
}