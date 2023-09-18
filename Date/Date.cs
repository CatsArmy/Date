using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    internal class Date
    {
        private int day;
        private int month;
        private int year;
        public Date()
        {
            this.day = 1;
            this.month = 1;
            this.year = 1970;
        }
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public Date(Date other)
        {
            this.day = other.day;
            this.month = other.month;
            this.year = other.year;
        }
        
        public int GetDay() => this.day;
        public int GetMonth() => this.month;
        public int GetYear() => this.year;

        public void SetDay(int day) => this.day = day;
        public void SetMonth(int month) => this.month = month;
        public void SetYear(int year) => this.year = year;

        public bool Equal(Date other)
        {
            return this.day == other.day && this.month == other.month 
                && this.year == other.year;
        }
        public bool IsLeapYear() => (this.year % 4 == 0 && this.year % 100 != 0) || this.year % 400 == 0;
        public override string ToString()
        {
            return $"{year}/{month}/{year}";
        }
        public int Compare(Date date)
        {
            if (this.year > date.year) return 1;
            if (this.year < date.year) return -1;
            
            if (this.month > date.month) return 1;
            if (this.month < date.month) return -1;
            
            if (this.day > date.day) return 1;
            if (this.day < date.day) return -1;
            
            return 0;
        }
    }
}
