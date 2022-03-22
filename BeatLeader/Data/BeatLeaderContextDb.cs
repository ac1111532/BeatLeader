#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeatLeader.Models;

    public class BeatLeaderContextDb : DbContext
    {
        public BeatLeaderContextDb (DbContextOptions<BeatLeaderContextDb> options)
            : base(options)
        {
        }

        public DbSet<BeatLeader.Models.Beatmap> Beatmap { get; set; }

        public DbSet<BeatLeader.Models.Song> Song { get; set; }
    }
