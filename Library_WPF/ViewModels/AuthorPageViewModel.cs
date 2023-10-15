using Library_DB.Contexts;
using Library_DB.Entities;
using Library_DB.Repositories.Concrets;
using Library_WPF.Commands;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WPF.ViewModels
{
    public class AuthorPageViewModel
    {

        public List<Author> Authors { get; set; } = new();
        public LibraryDbContext Context { get; set; } = new();
        public RelayCommand AddCommand { get; set; }

        public Repository<Author> authorRepository = new();

        public void Add(object? param)
        {
            Author newAuthor = new Author()
            {
                FirstName = Authors.Last().FirstName,
                LastName = Authors.Last().LastName
            };
            authorRepository.Add(newAuthor);

            authorRepository.SaveChanges();
        }
        public AuthorPageViewModel(List<Author> authors)
        {
            Authors = authors;
            AddCommand = new RelayCommand(Add);

        }
    }
}
