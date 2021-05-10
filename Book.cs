using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Week4_Class1;

namespace Week4_BookClassinWindows
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
        private string feedback = "";


        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Feedback
        {
            get
            {
                return feedback;
            }

            set
            {
                feedback = value;
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
                authorFirst = value;
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
                if (ValidationLibrary.IsValidEmail(value))
                {
                    email = value;
                }
                else
                {

                    Feedback = "ERROR: Invalid Email Format.";
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
                if (ValidationLibrary.IsAFutureDate(value) == false)
                {
                    datePublished = value;
                }
                else
                {
                    datePublished = DateTime.Parse("1/1/1900 12:00 am");
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
                if (ValidationLibrary.IsMinimumAmount(value, 1) == true)
                {
                    pages = value;
                }
                else
                {
                    pages = 0;
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
                if (ValidationLibrary.IsMinimumAmount(value, 1) == true)
                {
                    price = value;
                }
                else
                {
                    price = 0;
                }
            }
        }







    }
}
