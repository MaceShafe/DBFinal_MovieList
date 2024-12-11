using System.ComponentModel.DataAnnotations;

namespace MovieList.Models
{
    public class GenrePicker
    {
        [Key]
        public int Id { get; set; }
        public int MovieID { get; set; }
        public int GenreID { get; set; }

        public Movie Movie { get; set; } = null!;
        public Genre Genre { get; set; } = null!;
    }
}
