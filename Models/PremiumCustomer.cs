using Microsoft.AspNetCore.Mvc.RazorPages;
using PRELIM_LAB3_BSIT31A1_PIERREBENEDICT_DECASTRO.Models;
using PRELIM_LAB3_BSIT31A3_PIERREBENEDICT_DECASTRO.Models;
using System.Net;

namespace PRELIM_LAB3_BSIT31A1_PIERREBENEDICT_DECASTRO.Models
{
    public class PremiumCustomer : Customer
    {
        public bool IsVip { get; set; }
        public override string Describe()
        {
            string vipLabel = IsVip ? "Yes" : "No";
            return $"🌟 Premium Customer → ID: {CustomerId}, Name: {FirstName} {MiddleName} {LastName}, Email: {Email}, " +
                   $"Address: {Address}, Birthday: {Birthday.ToShortDateString()}, Age: {Age}, VIP: {vipLabel}";
        }
    }
}
