using Library_DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WPF.ViewModels
{
    public class BookPageViewModel
    {
        public List<Book> Books { get; set; } = new();

        public BookPageViewModel(List<Book> books)
        {

            Books = books;
        }
    }
}
