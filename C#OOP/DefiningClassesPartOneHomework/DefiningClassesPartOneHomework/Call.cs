using System;

namespace DefiningClassesPartOneHomework
{
    class Call
    {
        private DateTime dateTime;
        private string dialledPhoneNumber;
        private int duration;

        public Call(DateTime dateTime, string dialledPhoneNumber, int duration)
        {
            this.DateTime = dateTime;
            this.DialledPhoneNumber = dialledPhoneNumber;
            this.Duration = duration;
        }

        public DateTime DateTime
        {
            get { return this.dateTime; }
            set { this.dateTime = value; }
        }

        public string Date { get { return this.DateTime.Date.ToString("dd/MM/yyyy"); } }

        public string Time { get { return this.DateTime.ToString("hh:mm:ss"); } }
        public string DialledPhoneNumber
        {
            get { return this.dialledPhoneNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(value, "Dialled phone number can't be null or empty!");
                }
                this.dialledPhoneNumber = value;
            }
        }
        public int Duration
        {
            get { return this.duration; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Duration on call can't be negative!");
                }

                this.duration = value;
            }
        }

        public override string ToString()
        {
            return
                $"Date: {this.Date}, Time: {this.Time}, Dialled Phone Number: {this.DialledPhoneNumber}, Duration: {this.Duration}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Call otherObj = obj as Call;
            return this.Date == otherObj.Date && this.Time == otherObj.Time && this.DialledPhoneNumber == otherObj.DialledPhoneNumber && this.Duration == otherObj.Duration;
        }
    }
}