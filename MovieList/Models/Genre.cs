using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieList.Models
{
    public class Genre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int GenreID { get; set; }
        [Required]
        [StringLength(50)]
        public string GenreName {  get; set; }

        public ICollection<GenrePicker> GenrePickers { get; set; }

    }
}
