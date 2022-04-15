using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MovieStoreApp.Core.Entity
{
    public class MovieCast
    {
        [Key]
        public int Id { get; set; }

        public int MovieId { get; set; }
   
        public int CastId { get; set; }

        [MaxLength(20)]
        [Column(TypeName ="Varchar")]
        public string Character { get; set; }

        public virtual Movie Movie { get; set; }  //lazy loading
        public virtual Cast Cast { get; set; }  //virtual properties help in lazy loading
    }
}
