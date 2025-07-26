using PRELIM_LAB3_BSIT31A1_PIERREBENEDICT_DECASTRO.Home;
using PRELIM_LAB3_BSIT31A3_PIERREBENEDICT_DECASTRO.Models;
using System;
using System.Collections.Generic;

namespace PRELIM_LAB3_BSIT31A1_PIERREBENEDICT_DECASTRO.Home
{
    public class CustomerView
    {
        public void Render(List<IDescribable> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.describe());
            }
        }
    }
}
}
