using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCEntityExample.Models.Sample
{
    public class MusicStoreDBContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        public DbSet<Artist> Artists { get; set; }
    }
}