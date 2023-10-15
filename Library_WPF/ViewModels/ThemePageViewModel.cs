using Library_DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WPF.ViewModels
{
    public class ThemePageViewModel
    {
        public List<Theme> Themes { get; set; }
        public ThemePageViewModel(List<Theme> themes)
        {
            Themes = themes;
        }
    }
}
