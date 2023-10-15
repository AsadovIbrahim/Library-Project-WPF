using Library_DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WPF.ViewModels
{
    public class TeacherPageViewModel
    {
        public List<Teacher> Teachers { get; set; }
        public TeacherPageViewModel(List<Teacher> teachers)
        {
            Teachers = teachers;
        }
    }
}
