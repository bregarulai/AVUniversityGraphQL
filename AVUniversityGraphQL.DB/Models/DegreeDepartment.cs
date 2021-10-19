using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVUniversityGraphQL.DB.Models
{
    public class DegreeDepartment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AADescription { get; set; }
        public string ASDescription { get; set; }
        public List<DegreeType> DegreeTypes { get; set; } = new();
        public List<Degree> Degrees { get; set; } = new();
        public List<Course> Courses { get; set; } = new();
    }
}
