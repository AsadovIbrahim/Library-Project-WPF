using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DB.Entities
{
    public class Group : BaseEntity
    {
        public string? Name { get; set; }
        public int Id_Faculty { get; set; }

        public ICollection<Student>? Student { get; set; }
        public Faculty? Faculty { get; set; }

    }
}
