using System;
using System.Collections.Generic;

namespace BeatLeader.Models
{
    public class Song
    {
        public int SongID { get; set; }
        public char SongName { get; set; }
        public int SongLength { get; set; }
        public int SongBPM { get; set; }
        public int Size { get; set; }
        public char Artist { get; set; }

        public ICollection<Beatmap> beatmap { get; set; }
        
    }
}