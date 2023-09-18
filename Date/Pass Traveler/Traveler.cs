using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    internal class Traveler
    {
        private Passport passport;
        private bool hasPaid;

        public Traveler(Passport passport, bool hasPaid)
        {
            this.passport = new Passport(passport);
            this.hasPaid = hasPaid;
        }
        public Traveler(Traveler other)
        {
            this.passport = new Passport(other.passport);
            this.hasPaid = other.hasPaid;
        }

        public void Pay() => this.hasPaid = true;
        public bool HasPaid() => this.hasPaid;
        public bool CheckTravel(Date travelDate) => this.hasPaid ? this.passport.IsValid(travelDate) : false;

        public override string ToString() => $"{this.passport}\nHas Paid: {this.hasPaid}";
    }
}
