using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCEntityExample.Models.Sample
{
    public class Album
    {
        public int AlbumId { get; set; }

        [Required(ErrorMessage = "Title is required to add the album")]
        [StringLength(15,MinimumLength = 2)]
        public string Title { get; set; }

        public int Price { get; set; }
    }
}