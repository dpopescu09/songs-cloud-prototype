using Microsoft.EntityFrameworkCore;
using SongsCloudPrototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongsCloudPrototype.DAL
{
    public class SongsCloudContext : DbContext
    {
        public SongsCloudContext(DbContextOptions<SongsCloudContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<SongInvoice> SongInvoices { get; set; }
    }
}
