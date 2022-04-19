using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MovieStoreApp.Core.Models
{
    public class CastModel
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        [Column(TypeName = "Varchar")]
        [Required(ErrorMessage ="Cast Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Gender Name is Required")]
        public int Gender { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "Varchar")]
        [Required(ErrorMessage = "TmdbUrl Name is Required")]
        [DataType(DataType.Url)]
        public string TmdbUrl { get; set; }

        [MaxLength(130)]
        [Column(TypeName = "Varchar")]
        [Required(ErrorMessage = "Profilepath Name is Required")]
        [DataType(DataType.Url)]
        public string ProfilePath { get; set; }

    }
}
