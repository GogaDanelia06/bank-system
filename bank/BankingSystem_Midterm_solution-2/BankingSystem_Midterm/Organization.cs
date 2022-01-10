using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem_Midterm
{
    public class Organization : Client
    {
        public string OrganizationName { get; set; }
        public string IdentificationCode { get; set; }
        public DateTime AccountOpened { get; set; }
        public string AccountNumber { get; set; }
        public float Balance { get; set; }

        public override void detailedInfo()
        {
            //not done yet
        }
        public override void searchByDate(DateTime startDate, DateTime endDate)
        {
            //not done yet
        }
    }
}
