using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DB.Entities
{
    public class Teacher : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Id_Dep { get; set; }

        public Department? Department { get; set; }
        public ICollection<T_Card>? T_Card { get; set; }


    }
}
