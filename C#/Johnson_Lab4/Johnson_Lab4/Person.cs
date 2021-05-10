using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Johnson_Lab4
{
    class Person
    {
        private String fName;
        private String mName;
        private String lName;
        private String street1;
        private String street2;
        private String city;
        private String state;
        private String zip;
        private String phone;
        private String email;

        public String FirstName
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }
        public String MiddleName
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        public String LastName
        {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }
        }
        public String Street1
        {
            get
            {
                return street1;
            }
            set
            {
                street1 = value;
            }
        }
        public String Street2
        {
            get
            {
                return street2;
            }
            set
            {
                street2 = value;
            }
        }
        public String City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public String State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
        public String Zip
        {
            get
            {
                return zip;
            }
            set
            {
                zip = value;
            }
        }
        public String Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
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
    }
}
