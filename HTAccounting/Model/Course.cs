using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTAccounting.Model
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
    }
}
