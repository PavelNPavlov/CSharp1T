using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWDefineClass1
{
    class GSM
    {
        public static GSM iphone4S = new GSM("Iphone4S", "Apple", 300, new Display(new Size(10, 10), 1000), new Battery("Battery1", 40, 20, BatteryType.LI));

        #region Properties

        public string Model { get; set; }
        public string Manifacture { get; set; }
        public decimal Price { get; set; }
        public Display PhoneDisplay { get; set; }
        public Battery PhoneBattery { get; set; }
        public List<Call> CallHistory { get; set; }

        #endregion

        public GSM IPhone4S { get; set; }

        public GSM(string model, string manfact, decimal price=0, Display d=null, Battery b=null)
        {
            this.Model = model;
            this.Manifacture = manfact;
            this.Price = price;

            this.PhoneDisplay = d;
            this.PhoneBattery = b;

            this.CallHistory = new List<Call>();

        } //combined constructor

        public void AddCall(Call c)
        {
            this.CallHistory.Add(c);
        }

        public void Delete(Call c)
        {
            this.CallHistory.Remove(c);
        }

        public void Remove(Func<Call, bool> lambda)
        {
            var temp = this.CallHistory.Where(lambda).ToList();

            this.CallHistory.Remove(temp[0]);
        }

        public decimal TotalCost(decimal secondPrice)
        {
            decimal totalDuration = 0;
            foreach (var item in this.CallHistory)
            {
                totalDuration += item.Duration;
            }

            return secondPrice * totalDuration/60;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(this.Manifacture+ " ");
            result.Append(this.Model + " ");
            
            result.Append(System.Environment.NewLine);
            if (this.PhoneDisplay != null)
            {
                result.Append(this.PhoneDisplay.ToString());
            }
            result.Append(System.Environment.NewLine);
            if (this.PhoneBattery != null)
            {
                result.Append(this.PhoneBattery.ToString());
            }
            result.Append(System.Environment.NewLine);
            if (this.Price == 0)
            {
                result.Append("Price: N/A");
            }
            else
            {
                result.Append("Price: " + this.Price + " $");
            }

            return result.ToString();
        }
    }
}
