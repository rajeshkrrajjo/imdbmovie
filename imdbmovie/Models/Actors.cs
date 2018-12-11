using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace imdbmovie.Models
{

    public class Actors
    {
        public enum Sex { Male, Female };
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Sex WhichSex { get; set; }
        public DateTime DateOfBirth { get; set; }

        public virtual Movies Movies { get; set;}
    }
}