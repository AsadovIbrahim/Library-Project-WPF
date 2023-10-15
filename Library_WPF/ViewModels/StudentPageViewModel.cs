using Library_DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WPF.ViewModels
{
    public class StudentPageViewModel
    {
        public List<Student> Students { get; set; }
        public StudentPageViewModel(List<Student> students)
        {
            Students = students;
        }
    }
}
