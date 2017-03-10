using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClassesPartOneHomework
{
    class Gsm
    {
        private static readonly Gsm iPhoneFourS;

        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery batteryCharacteristics;
        private Display displayCharacteristics;
        private List<Call> callHistory; 
        static Gsm()
        {
            iPhoneFourS = new Gsm("IPhone4S", "Apple", 1020.00m, "Tina Moleva", new Battery("SD-L", 50, 32, BatteryType.LiIon), new Display(5, 23));
        }
        public Gsm(string model, string manufacturer) 
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.CallHistory = new List<Call>();
        }

        public Gsm(string model, string manufacturer, decimal? price, string owner,
            Battery batteryCharacteristics, Display displayCharacteristics) : this(model, manufacturer)
        {            
            this.Price = price;
            this.Owner = owner;
            this.BatteryCharacteristics = batteryCharacteristics;
            this.DisplayCharacteristics = displayCharacteristics;            
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(model, "GSM Model can't be null or empty");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(value, "Manufacturer on gsm can't be negativ or empty!");
                }

                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price on gsm can't be negative!");
                }

                this.price = value;
            } 
        } 

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(value, "Owner can't be null or emty!");   
                }

                this.owner = value;
            }
        } 

        public Battery BatteryCharacteristics
        {
            get { return this.batteryCharacteristics; }
            set { this.batteryCharacteristics = value; }
        }

        public Display DisplayCharacteristics
        {
            get { return this.displayCharacteristics; }
            set { this.displayCharacteristics = value; }
        }

        public static Gsm IPhoneFourS { get { return iPhoneFourS; } }

        public List<Call> CallHistory { get { return this.callHistory; } set { this.callHistory = value; } }

        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            if (CallHistory.Contains(call))
            {
                CallHistory.RemoveAll(x => x == call);
            }
        }

        public void ClearCallHistory()
        {
            CallHistory.Clear();
        }

        public decimal CalculatePrice(decimal price)
        {

            int allSeconds = 0;
            CallHistory.ForEach(x => allSeconds += x.Duration);
            decimal allPriceForMinute = ((decimal)allSeconds / 60m)* price;

            return allPriceForMinute;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"Model: {this.Model}\nManufacturer: {this.Manufacturer}");

            if (this.Price != null)
            {
                result.Append($"\nPrice: {this.Price} lv.");
            }

            if (this.Owner != null)
            {
                result.Append($"\nOwner: {this.Owner}");
            }

            if (this.BatteryCharacteristics != null)
            {
                result.Append($"\nBattery characteristics: {this.BatteryCharacteristics}");
            }

            if (this.DisplayCharacteristics != null)
            {
                result.Append($"\nDisplay characteristics: {this.DisplayCharacteristics}");
            }

            if (this.CallHistory.Count != 0)
            {
                result.Append($"\nCall History: ");
                this.CallHistory.ForEach(x => result.Append($"\n{x}"));               
            }

            return result.ToString();
        }
    }
}