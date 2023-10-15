using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DB.Entities
{
    public class Book:BaseEntity
    {
        public string? Name { get; set; }
        public int Pages { get; set; }
        public DateTime YearPress { get; set; }
        public int Id_Themes { get; set; }
        public int Id_Category { get; set; }
        public int Id_Author { get; set; }
        public int Id_Press { get; set; }
        public string? Comment { get; set; }
        public int Quantity { get; set; }

        public Theme? Theme { get; set; }
        public Author? Author { get; set; }
        public Press? Press { get; set; }
        public Category? Category { get; set; }

        public ICollection<T_Card>? T_Card { get; set; }
        public ICollection<S_Card>? S_Card { get; set; }
    }
}
