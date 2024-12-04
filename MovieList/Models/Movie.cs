using System.Collections.Generic;
using System;

namespace MovieList.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string MovieName { get; set; }
        public DateTime ReleaseDate { get; set; }

        public ICollection<GenrePicker> GenrePicker { get; set; }

    }
}
