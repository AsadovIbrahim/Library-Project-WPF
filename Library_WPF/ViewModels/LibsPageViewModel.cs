using Library_DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WPF.ViewModels
{
    public class LibsPageViewModel
    {
        public List<Lib> Libs { get; set; } = new();
        public LibsPageViewModel(List<Lib> libs)
        {
            Libs = libs;
        }
    }
}
