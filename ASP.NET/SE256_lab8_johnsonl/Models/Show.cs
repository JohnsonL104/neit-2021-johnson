using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SE256_lab5_johnsonl.Models
{
    public class Show
    {
        public int ShowID { get; set; }

        //For some reason this is coming up as required even though I don't have a required annototion here and I can't figure out why.
        [Display(Name = "EndDate")]
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:MM/dd/yyy hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        [MyDate(ErrorMessage = "Please enter a past date")]
        public DateTime EndDate { get; set; }

        [Required]
        public String Title { get; set; }

        [Required, StringLength(255)]
        public String Description { get; set; }

        [Required]
        [Display(Name = "ReleaseDate")]
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:MM/dd/yyy hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        [MyDate(ErrorMessage = "Please enter a past date")]
        public DateTime ReleaseDate { get; set; }
        
         
        

        [Required]
        public int EpisodeCount { get; set; }

        public String Feedback { get; set; }
    }
}
