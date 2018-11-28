using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCEntityExample.Models.Sample
{
    public class Artist
    {
        public int ArtistID { get; set; }

        [Required()]
        [StringLength(30,MinimumLength = 2)]
        public string Name { get; set; }

        public List<Album> Albums { get; set; }
    }
}