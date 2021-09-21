using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Activity5.Models
{
    public class TroubleTicketModel
    {
        [Required]
        public int TicketID { get; set; }

        [Required, StringLength(255)]
        public String TicketTitle { get; set; }

        [Required]
        public String TicketDesc { get; set; }

        [Required]
        [StringOptionsValidate(Allowed = new String[] {"Monitor", "Computer", "Printer", "Software Install", "Software Upgrade", "Configuration", "Internet"}, ErrorMessage ="Sorry the Category is invalid. Categories include: Monitor, Computer, Printer, Software Install, Software Upgrade, Configuration, Internet")]
        public String Category { get; set; }

        [Required, EmailAddress]
        public String ReportingEmail { get; set; }

        [Required]
        [Display(Name = "Original date of the problem.")]
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString ="{0:MM/dd/yyy hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        [MyDate(ErrorMessage = "Future date entry not allowed")]
        public DateTime OrigDate { get; set; }

        [Required]
        [Display(Name = "Date of solutions/closure.")]
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:MM/dd/yyy hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        [MyDate(ErrorMessage = "Future date entry not allowed")]
        public DateTime CloseDate { get; set; }

        public String ResponderNotes { get; set; }
        
        [EmailAddress]
        public String ResponderEmail { get; set; }

        [Required]
        public bool Active { get; set; }

        public String Feedback { get; set; }
    }
}
