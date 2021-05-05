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
                cellPhone = value;
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
                instagramURL = value;
            }
        }
    }
}
