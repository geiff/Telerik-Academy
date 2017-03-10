using System.Collections.Generic;
using System.Text;

namespace SchoolClasses
{
    public class School
    {
        private List<Class> classes;

        public School(List<Class> classes)
        {
            this.Classes = classes;
        }
        public List<Class> Classes { get; set; }

        /// <summary>
        /// Override ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"This school have \n");
            foreach (var c in this.Classes)
            {
                result.Append(c);
            }

            return result.ToString();
        }
    }
}