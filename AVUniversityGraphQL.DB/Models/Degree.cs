using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVUniversityGraphQL.DB.Models
{
    public class Degree
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int CreditHour { get; set; }
        public int DegreeDepartmentId { get; set; }
        public DegreeDepartment DegreeDepartment { get; set; }
        public List<Campus> Campuses { get; set; }
    }
}
