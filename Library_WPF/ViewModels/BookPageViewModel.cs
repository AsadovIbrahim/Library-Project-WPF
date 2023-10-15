using Library_DB.Contexts;
using Library_DB.Entities;
using Library_DB.Repositories.Concrets;
using Library_WPF.Commands;
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
        public LibraryDbContext Context { get; set; } = new();
        public RelayCommand AddCommand { get; set; }

        public Repository<Book> bookRepository = new();

        public void Add(object? param)
        {
            Book newBook = new Book()
            {
                Name=Books.Last().Name,
                Pages=Books.Last().Pages,
                YearPress=Books.Last().YearPress,
                Id_Themes = Books.Last().Id_Themes,
                Id_Category = Books.Last().Id_Category,
                Id_Author = Books.Last().Id_Author,
                Id_Press = Books.Last().Id_Press,
                Comment =Books.Last().Comment,
                Quantity=Books.Last().Quantity,
            };
            bookRepository.Add(newBook);

            bookRepository.SaveChanges();
        }
       
        public BookPageViewModel(List<Book> books)
        {
            Books = books;
            AddCommand = new RelayCommand(Add);
        }
    }
}
