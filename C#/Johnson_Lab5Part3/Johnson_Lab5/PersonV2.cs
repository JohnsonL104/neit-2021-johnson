using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClass
{
    class PersonV2:Person
    {
        private String cellPhone;
        private String instagramURL;
        
        public String CellPhone
        {
            get
            {
                return cellPhone;
            }
            set
            {
                if (Validation.ValidatePhone(value))
                {

                    cellPhone = value;
                }
                else
                {
                    feedback += "ERROR: Invalid Cellphone\n";
                }
            }
        }
        public String InstagramURL
        {
            get
            {
                return instagramURL;
            }
            set
            {
                if (Validation.ValidateInstagramURL(value))
                {
                    instagramURL = value;
                }
                else
                {
                    feedback += "ERROR: Invalid Instagram URL\n";
                }
            }
        }
    }
}
