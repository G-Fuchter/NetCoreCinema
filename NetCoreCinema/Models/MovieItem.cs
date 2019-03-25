using System;
using System.ComponentModel.DataAnnotations;

namespace NetCoreCinema.Models
{

    /*This class defines what the database will need to store for each to-do item: 
    an ID, a title or name, whether the item has subtitles, Price, Discount, 
    and the date of the screening is. 
    Each line defines a property of the class */

    public class MovieItem
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        public bool HasSubtitles { get; set; }

        public float Price {get; set;}

        public  int? Discount {get; set;}

        public DateTime ScreenAt { get; set; }
    }
}