using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVUniversityGraphQL.DB.Models
{
    public class Building
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public int CampusId { get; set; }
        public Campus Campus { get; set; }
        public List<Room> Rooms { get; set; } = new();
    }
}
