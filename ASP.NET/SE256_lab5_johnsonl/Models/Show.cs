using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SE256_lab5_johnsonl.Models
{
    public class Show
    {
        public int ShowID { get; set; }

        public String Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int EpisodeCount { get; set; }
    }
}
