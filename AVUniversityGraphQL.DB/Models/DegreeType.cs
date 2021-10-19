using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVUniversityGraphQL.DB.Models
{
    public class DegreeType
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
    }
}
