using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStoreApp.Core.Entity
{
    public class Role
    {
        public int Id { get; set; }

        [MaxLength(20)]
        [Column(TypeName ="Varchar")]
        public string Name { get; set; }
    }
}
