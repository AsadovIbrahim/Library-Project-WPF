using Library_DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WPF.ViewModels
{
    public class FacultyPageViewModel
    {
        public List<Faculty> Faculties { get; set; } = new();
        public FacultyPageViewModel(List<Faculty> faculties)
        {
            Faculties = faculties;
        }

    }
}
