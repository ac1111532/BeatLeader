using System;
using System.Collections.Generic;

namespace BeatLeader.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        public char PlayerName { get; set; }
        public int AccountAge { get; set; }
        public char PlayerHMD { get; set; }
        public char PlayerPlatform { get; set; }
        public int Modcount { get; set; }
        public int LevelsBeaten { get; set; }
    }
}