using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClass
{
    class Book
    {
        private string title;
        private string authorFirst;
        private string authorLast;
        private string email;
        private DateTime datePublished;
        private int pages;
        private double price;

        protected string feedback;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (!Validation.GotBadWords(value))
                {
                    title = value;
                }
                else
                {
                    feedback += "\nERROR: Title has a bad word in it.";
                }
            }
        }

        public string AuthorFirst
        {
            get
            {
                return authorFirst;
            }
            set
            {
                if (!Validation.GotBadWords(value))
                {
                    authorFirst = value;
                }
                else
                {
                    feedback += "\nERROR: Author's first name has a bad word in it.";
                }
            }
        }

        public string AuthorLast
        {
            get
            {
                return authorLast;
            }
            set
            {
                
                authorLast = value;
                
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (Validation.ValidateEmail(value))
                {
                    email = value;
                }
                else
                {
                    feedback += "\nERROR: Invalid Email";
                }
            }
        }
        public DateTime DatePublished
        {
            get
            {
                return datePublished;
            }
            set
            {
                if (!Validation.IsFutureDate(value))
                {
                    datePublished = value;
                }
                else
                {
                    feedback += "\nERROR: You cannot enter future dates";
                }
            }
        }
        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {

                if (value > 0)
                {                    
                    pages = value;
                    
                }
                else
                {
                    feedback += "\nERROR: Sorry you entered an invalid number of pages";
                }
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    feedback += "\nERROR: price is not sufficient";
                }
            }
        }

        public string Feedback
        {
            set { feedback = value; }
            get { return feedback; }
        }


        public Book()
        {
            title = "";
            authorFirst = "";
            authorLast = "";
            pages = 0;
            datePublished = DateTime.Parse("1/1/1500");
            price = 0.0;
            feedback = "";
        }
    }
}
