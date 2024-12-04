using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieList.Models
{
    public class Genre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GenreID { get; set; }
        public string GenreName {  get; set; }

        public ICollection<GenrePicker> GenrePickers { get; set; }

    }
}
