using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MovieStoreApp.Core.Entity;

namespace MovieStoreApp.Core.Models
{
    public class MovieCastModel
    {
        [Key]
        public int Id { get; set; }

        public int MovieId { get; set; }

        public int CastId { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "Varchar")]
        public string Character { get; set; }

        public virtual MovieResponseModel? Movie { get; set; }  //lazy loading
        public virtual CastModel? Cast { get; set; }  //virtual properties help in lazy loading
    }
}
