using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClass
{
    class Customer:PersonV2
    {
        private DateTime customerSince;
        private Double totalPurchases;
        private bool discountMember;
        private int rewardsEarned;
        
        public DateTime CustomerSince
        {
            get
            {
                return customerSince;
            }
            set
            {
                customerSince = value;
            }
        }

        public Double TotalPurchases
        {
            get
            {
                return totalPurchases;
            }
            set
            {
                if(value >= 0)
                {
                    totalPurchases = value;
                }
                else
                {
                    feedback += "ERROR: Total Purchases must be number greater than 0\n";
                }
            }
        }

        public bool DiscountMember
        {
            get
            {
                return discountMember;
            }
            set
            {
                discountMember = value;
            }
        }

        public int RewardsEarned
        {
            get
            {
                return rewardsEarned;
            }
            set
            {
                if (value >= 0)
                {
                    rewardsEarned = value;
                }
                else
                {
                    feedback += "ERROR: Rewards Earned must be number greater than 0\n";
                }
            }
        }

        public Customer() : base()
        {
            customerSince = DateTime.Parse("1/1/1000");
            totalPurchases = 0;
            discountMember = false;
            rewardsEarned = 0;
        }
    }
}
