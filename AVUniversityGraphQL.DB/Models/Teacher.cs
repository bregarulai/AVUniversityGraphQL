using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVUniversityGraphQL.DB.Models
{
    public class Teacher : User
    {
        public float PayRate { get; set; }
        public List<Course> Courses { get; set; } = new();
    }
}