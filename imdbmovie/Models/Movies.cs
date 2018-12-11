using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace imdbmovie.Models
{
    public class Movies
    {
        public string MovieName { get; set; }
        public DateTime YearOfRel { get; set; }
        public string plot { get; set; }
        public byte[] poster { get; set; }
        
        public virtual Actors Actors { get; set; }
        public virtual Producers Producers { get; set; }
    }
}