﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MovieStoreApp.Core.Entity
{
    public class MovieGenre
    {
        [Key]
        public int MovieId { get; set; }
        public int GenreId { get; set; }
    }
}
