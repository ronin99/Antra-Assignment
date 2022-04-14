using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MovieStoreApp.Core.Entity
{
    public class UserRole
    {
        [Key]
        public int UserId { get; set; }
        public int RoleId { get; set; } 
    }
}
