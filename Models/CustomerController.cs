using PRPRELIM_LAB3_BSIT31A3_PIERREBENEDICT_DECASTRO.Home;
using System;
using System.Collections.Generic;

namespace PRELIM_LAB3_BSIT31A3_PIERREBENEDICT_DECASTRO.Home
{
    public class CustomerController
    {
        public List<IDescribable> GetCustomers()
        {
            return new List<IDescribable>
            {
                new Customer
                {
                    Id = 1,
                    Name = "Alice",
                    Email = "alice@example.com",
                    Birthday = new DateTime(1990, 5, 15)
                },
                new PremiumCustomer
                {
                    Id = 2,
                    Name = "Bob",
                    Email = "bob@example.com",
                    Birthday = new DateTime(1985, 10, 20),
                    MembershipLevel = "Gold"
                }
            };
        }
    }
}
