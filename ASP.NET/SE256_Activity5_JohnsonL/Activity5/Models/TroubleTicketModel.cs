using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity5.Models
{
    public class TroubleTicketModel
    {
        public int TicketID { get; set; }

        public String TicketTitle { get; set; }

        public String TicketDesc { get; set; }

        public String Category { get; set; }

        public String ReportingEmail { get; set; }

        public DateTime OrigDate { get; set; }

        public DateTime CloseDate { get; set; }

        public String ResponderNotes { get; set; }

        public String ResponderEmail { get; set; }

        public bool Active { get; set; }
    }
}
