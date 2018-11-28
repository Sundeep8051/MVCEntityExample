using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCEntityExample.Models.Sample
{
    public class MusicStoreDataContextInitializer : DropCreateDatabaseAlways<MusicStoreDBContext>
    {
        protected override void Seed(MusicStoreDBContext context)
        {
            var artist = new Artist { Name = "Artist 1"};
            var artist1 = new Artist { Name = "Artist 2" };

            context.Artists.Add(artist);
            context.Artists.Add(artist1);
            
            var album = new Album { Title = "Name 1",  Price = 20, Artist = artist };
            var album1 = new Album { Title = "Name 2", Price = 30, Artist = artist1 };
            context.Albums.Add(album);
            context.Albums.Add(album1);

            context.SaveChanges();

            
        }
    }
}