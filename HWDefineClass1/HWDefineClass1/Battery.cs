using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWDefineClass1
{
    public enum BatteryType
    {
       LI, NiMH, NiCd, Null
    }
    class Battery
    {
        private BatteryType bT;

        public string Model { get; set; }
        public double HoursIdle { get; set; }
        public double HoursTalk { get; set; }

        public Battery(string model, double hI=0, double hT=0, BatteryType bt=BatteryType.Null)
        {
            this.Model = model;
            this.HoursIdle = hI;
            this.HoursTalk = hT;
            this.bT = bt;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("Model :"+this.Model+" :");
            result.Append(System.Environment.NewLine);
            result.Append("\t" + "Battery Life Idle: "+ this.HoursIdle+" hours");
            result.Append(System.Environment.NewLine);
            result.Append("\t" + "Battery Life Talking: " + this.HoursTalk+" hours");

            return result.ToString();

        }
    }
}
