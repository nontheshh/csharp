using System.Collections.Generic;

namespace DbManagerEntityFramework.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IList<Employee> Employees { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
