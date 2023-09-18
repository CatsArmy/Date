using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dates;

namespace Dates
{
    internal class Passport
    {
        private string name;
        private int number;
        private Date expiryDate;
        public Passport(string name,int number,Date expiryDate)
        {
            this.name = name;
            this.number = number;
            this.expiryDate = expiryDate;
        }
        public Passport(Passport passport)
        {
            this.name = passport.name;
            this.number = passport.number;
            this.expiryDate = passport.expiryDate;
        }
        
        public bool IsValid(Date checkedDate)
        {
            return this.expiryDate.Compare(checkedDate) == 1;
        }
        public void SetExpiryDate(Date date)
        {
            this.expiryDate = new Date(date);
        }

        public override string ToString()
        {
            return $"Name: {name}\nPassport number: {number}\nExpiry Date: {expiryDate}";
        }
    }
}
