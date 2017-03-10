using System;

namespace DefiningClassesPartOneHomework
{
    public class Battery
    {
        private string model;
        private int? hoursIdle;
        private int? hoursTalk;
        private BatteryType batteryType;

        public Battery()
        {
            
        }
        public Battery(string model, int? hoursIdle, int? hoursTalk, BatteryType batteryType) : this()
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(value, "Battery Model can't be empty or null!");
                }

                this.model = value;
            }
        }

        public int? HoursIdle
        {
            get { return this.hoursIdle;}
            set
            {
                if (value < 0f)
                {
                    throw new ArgumentOutOfRangeException("Battery Hours idle can't be negative!");
                }

                this.hoursIdle = value;
            }
        }

        public int? HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0f)
                {
                    throw new ArgumentOutOfRangeException("Battery Hours talk can't be negative!");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType
        {
            get{ return this.batteryType; }
            set { this.batteryType = value; }
        }

        public override string ToString()
        {
            return $"model: {this.Model}, hours idle: {this.HoursIdle}, hours talk: {this.HoursTalk}, battery type: {this.BatteryType}";
        }
    }
}