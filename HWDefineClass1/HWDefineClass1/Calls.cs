using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWDefineClass1
{
    class Call
    {
        public DateTime CallDate { get; set; }
        public string PhoneNumber { get; set; }
        public int Duration { get; set; }

        public Call(DateTime d, string s, int du)
        {
            this.CallDate = d;
            this.PhoneNumber = s;
            this.Duration = du;
        }
        public TimeSpan CallTime()
        {
            return this.CallDate.TimeOfDay;
        }

        public DateTime CallDay()
        {
            return this.CallDate.Date;
        }
        public override string ToString()
        {
            return string.Format("Caller: {0} Time:{1: HH:MM:ss} Date:{1:dd/mm/yyyy} Duration: {2}s ", this.PhoneNumber, this.CallDate, this.Duration);
        }
    }
}
