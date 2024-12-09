namespace MovieList.Models
{
    public class GenrePicker
    {

        public int Id { get; set; }
        public int MovieID { get; set; }
        public int GenreID { get; set; }

        public Movie Movie { get; set; }
        public Genre Genre { get; set; }
    }
}
