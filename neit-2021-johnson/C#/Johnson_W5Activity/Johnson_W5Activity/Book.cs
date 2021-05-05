using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Johnson_W5Activity
{
    class Book
    {
        private String title;
        private String authFirst;
        private String authLast;
        private String email;
        private DateTime datePublished;
        private int pages;
        private double price;
        private string feedback = "";
        
        public String Title
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

        public String AuthorFirst
        {
            get
            {
                return authFirst;
            }
            set
            {
                authFirst = value;
            }
        }

        public String AuthorLast
        {
            get
            {
                return authLast;
            }
            set
            {
                authLast = value;
            }
        }

        public String Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
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
                datePublished = value;
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
                pages = value;
            }
        }
        public Double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public String Feedback
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


    }
}
