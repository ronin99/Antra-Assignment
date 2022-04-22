using MovieStoreApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Core.Models
{
    public class GenreModel
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(30)]
        [Column(TypeName = "Varchar")]
        public string Name { get; set; }

       // public virtual ICollection<MovieGenreModel> MovieGenres { get; set; }
    }
}
