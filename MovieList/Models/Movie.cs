using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace MovieList.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }

        public string MovieName { get; set; }
        public DateTime? ReleaseDate { get; set; }

        public ICollection<GenrePicker> GenrePicker { get; set; }

    }
}
