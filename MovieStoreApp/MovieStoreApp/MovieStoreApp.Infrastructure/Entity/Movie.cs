using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Infrastructure.Entity
{
    public class Movie
    {
        public int Id { get; set; }
        public string Titile { get; set; }
        public string OVerview { get; set; }
        public string Tagline { get; set; }
        public decimal Bugget { get; set; }
        public decimal Revenue { get; set; }
        public string ImdbUrl { get; set; }
        public string TmdbUrl { get; set; }
        public string PosterUrl { get; set; }
        public string BackdropUrl { get; set; }
        public string OriginalLanguage { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Runtime { get; set; }
        public decimal Price { get; set; }

  

    }
}
