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
    public class CategoryPageViewModel
    {
        public List<Category> Categories { get; set; } = new();
        public RelayCommand AddCommand { get; set; }
        public Repository<Category> categoryRepository { get; set; } = new();

        public void Add(object? param)
        {
            Category newCategory = new()
            {
                Name=Categories.Last().Name
            };
            categoryRepository.Add(newCategory);
            categoryRepository.SaveChanges();
        }

        public CategoryPageViewModel(List<Category> categories)
        {
            Categories = categories;
            AddCommand=new RelayCommand(Add);
        }
    }
}
