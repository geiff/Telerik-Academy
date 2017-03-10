namespace Linq
{
    public class Group
    {
        public Group(int groupNumber, string deprtmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = deprtmentName;
        }

        public int GroupNumber { get; set; }
        public string DepartmentName { get; set; }
    }
}