using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CommonClass
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
        protected String feedback = "";
        public String FirstName
        {
            get
            {
                return fName;
            }
            set
            {
                if (Validation.ValidateFilled(value)){
                    fName = value;
                }else
                {
                    feedback += "ERROR: First name is not filled in\n";
                }
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
                if (Validation.ValidateFilled(value))
                {
                    lName = value;
                }
                else
                {
                    feedback += "ERROR: Last name is not filled in\n";
                }
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
                if (Validation.ValidateFilled(value))
                {
                    street1 = value;
                }
                else
                {
                    feedback += "ERROR: Street 1 is not filled in\n";
                }
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
                if (Validation.ValidateFilled(value))
                {
                    city = value;
                }
                else
                {
                    feedback += "ERROR: City is not filled in\n";
                }
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
                if (Validation.ValidateState(value))
                {
                    state = value;
                }
                else
                {
                    feedback += "ERROR: Invalid State\n";
                }
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
                if (Validation.ValidateLength(value, 5))
                {
                    zip = value;
                }
                else
                {
                    feedback += "ERROR: zip is not filled in properly EX. \"72716\"\n";
                }
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
                if (Validation.ValidatePhone(value))
                {
                    phone = value;
                }
                else
                {
                    feedback += "ERROR: Invalid Phone Number\n";
                }
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
                if (Validation.ValidateEmail(value))
                {
                    email = value;
                }
                else
                {
                    feedback += "ERROR: Email is not filled in properly EX. \"email@email.com\"\n";
                }
            }
        }

        public String Feedback
        {
            get
            {
                return feedback;
            }
        }
    }
}
