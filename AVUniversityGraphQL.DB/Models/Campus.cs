using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVUniversityGraphQL.DB.Models
{
    public class Campus
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public List<Address> Addresses { get; set; } = new();
        public List<Building> Buildings { get; set; } = new();
        public List<Degree> Degrees { get; set; } = new();
    }
}
