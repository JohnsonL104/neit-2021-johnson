using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4SampleCode
{
    class EBook : Book
    {
        private DateTime dateRentalExpires;
        private int bookmarkPage;

        public DateTime DateRentalExpires
        {
            get
            {
                return DateRentalExpires;
            }
            set
            {
                if (ValidationLibrary.IsAFutureDate(value))
                {
                    dateRentalExpires = value;
                }
                else
                {
                    feedback += "\nERROR: you must enter future dates";
                }
            }
        }

        public int BookmarkPage
        {
            get
            {
                return bookmarkPage;
            }
            set
            {
                if(ValidationLibrary.IsMinimumAmount(value, 1) && value <= Pages)
                {
                    bookmarkPage = value;
                }
                else
                {
                    feedback += "\nERROR: Sorry you entered an invalid page number";
                }
            }
        }
        
        public EBook(): base()
        {
            bookmarkPage = 1;
            dateRentalExpires = DateTime.Now.AddDays(14);
        }
    }
}
