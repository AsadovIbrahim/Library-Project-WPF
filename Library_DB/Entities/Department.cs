using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DB.Entities
{
    public class Department : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<Teacher>? Teacher { get; set; }
    }
}
