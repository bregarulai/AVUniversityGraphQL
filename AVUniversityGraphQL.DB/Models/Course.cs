using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVUniversityGraphQL.DB.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public int CreditHour { get; set; }
        public int YearNumber { get; set; }
        public int SemesterNumber { get; set; }
    }
}
