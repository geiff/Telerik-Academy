using System;

namespace DefiningClassesPartOneHomework
{
    public class Display
    {
        private double? size;
        private int? numberOfColors;

        public Display()
        {
            
        }
        public Display(double? size, int? numberOfColors) : this()
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double? Size
        {
            get { return this.size; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Size on display can't be negative!");
                }

                this.size = value;
            }
        }

        public int? NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of colors on display can't be negative!");
                }

                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            return $"size: {this.Size}, number of colors: {this.NumberOfColors}";
        }
    }
}