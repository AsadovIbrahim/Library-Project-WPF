using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DB.Entities
{
    public class Student : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Id_Group { get; set; }
        public string? Term { get; set; }

        public Group? Group { get; set; }
        public ICollection<S_Card>? S_Card { get; set; }

    }
}
