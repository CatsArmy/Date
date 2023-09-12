using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    internal class Child
    {
        private string name;
        private string id;
        private char gender;
        private Date birthday;

        public Child(string name, string id,char gender,Date birthday)
        {
            this.name = name;
            this.id = id;
            this.gender = gender;
            this.birthday = new Date(birthday);
        }
        
        public string GetName() => name;
        public string GetID() => id;
        public char GetGender() => gender;
        public Date GetBirthday() => birthday;
        
        public void SetName(string name) => this.name = name;
        public void SetID(string id) => this.id = id;
        public void SetGender(char gender) => this.gender = gender;
        public void SetBirthday(Date birthday) => this.birthday = birthday;

        public bool SameBirthDay(Child other)
        {
            return birthday.Equals(other.birthday);
        }
    }
}
