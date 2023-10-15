using Library_DB.Entities;
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

        public CategoryPageViewModel(List<Category> categories)
        {
            Categories = categories;
        }
    }
}
