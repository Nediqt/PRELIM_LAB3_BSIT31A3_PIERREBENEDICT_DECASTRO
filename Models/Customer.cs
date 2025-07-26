using System;

namespace PRELIM_LAB3_BSIT31A3_PIERREBENEDICT_DECASTRO.Models
{
    public class Customer : BaseEntity, IDescribable
    {
        public string Email { get; set; }
        public string Address { get; set; }
        public string CustomerId { get; set; }


        public virtual string Describe()
        {
   
           return $"Customer ID: {CustomerId}, Name: {FirstName} {MiddleName} {LastName}, Email: {Email}, " +
                   $"Address: {Address}, Birthday: {Birthday.ToShortDateString()}, Age: {Age}";
        }
    }
}
