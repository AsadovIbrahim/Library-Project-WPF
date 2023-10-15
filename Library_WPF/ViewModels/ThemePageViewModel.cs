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
    public class ThemePageViewModel
    {

        public LibraryDbContext Context { get; set; } = new();
        public Repository<Theme> themeRepository { get; set; } = new();
        public List<Theme> Themes { get; set; }
        public RelayCommand AddCommand { get; set; }
        public void Add(object? param)
        {
            Theme newTheme = new Theme()
            {
                Name = Themes.Last().Name,
            };
            themeRepository.Add(newTheme);

            themeRepository.SaveChanges();
        }
        public ThemePageViewModel(List<Theme> themes)
        {
            Themes = themes;
            AddCommand=new RelayCommand(Add);
        }



     
    }
}
