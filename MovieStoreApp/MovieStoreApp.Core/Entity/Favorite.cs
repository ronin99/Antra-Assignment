﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStoreApp.Core.Entity
{
    public class Favorite
    {
        [Key]
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }
    }
}
