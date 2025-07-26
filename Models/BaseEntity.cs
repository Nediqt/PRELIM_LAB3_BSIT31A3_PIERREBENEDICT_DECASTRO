using System;
using System.Reflection.Metadata.Ecma335;

namespace PRELIM_LAB3_BSIT31A3_PIERREBENEDICT_DECASTRO.Models
{
    public class BaseEntity
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string GetFullname()
        {
            return $"Mr. {LastName}, {FirstName} {MiddleName}";
        }
        public DateTime Birthday { get; set; }
        public int GetAge();
            {
                return (DateTime.now.Year - Birthday.Year);
            }
        }
    }

