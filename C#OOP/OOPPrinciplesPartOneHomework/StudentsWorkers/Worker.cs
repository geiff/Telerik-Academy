namespace StudentsWorkers
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary{ get; set; }
        public int WorkHoursPerDay{ get; set; }

        /// <summary>
        /// Calculate money per hour
        /// </summary>
        /// <returns></returns>
        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = this.WeekSalary/(this.WorkHoursPerDay*50);
            return moneyPerHour;
        }

        /// <summary>
        /// Override ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Worker {this.FirstName} {this.LastName} with ${this.WeekSalary} salary for week" +
                   $" and {this.WorkHoursPerDay} workhours per day, and money per hour are: ${this.MoneyPerHour().ToString("0.00")}";
        }
    }
}