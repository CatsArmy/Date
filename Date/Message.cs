using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    internal class Message
    {
        public string from;
        public string to;
        public string message;
        public Date date;
        public Message(String from, String to, String message, Date date)
        {
            this.from = from;
            this.to = to;
            this.message = message;
            this.date = new Date(date);
        }
        public override string ToString()
        {
            string s = $" - - {this.date} - -\n";
            s += $"From: {this.from}\n";
            s += $"To: {this.to}\n";
            s += this.message;
            return s;
        }
        public void Reply(string response, Date sent)
        {
            string temp = this.from;
            this.from = this.to;
            this.to = temp;
            this.date = new Date(sent);
            this.message = $"{response}\n->\n{this.message}";
        }
        public void Forword(string to, Date sent)
        {
            this.from = this.to;
            this.to = to;
            this.date = new Date(sent);
            this.message = $"Forward >> {this.message}";    
        }
    }
}
