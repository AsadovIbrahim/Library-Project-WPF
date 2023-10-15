using Library_DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WPF.ViewModels
{
    public class DepartmentPageViewModel
    {
        public List<Department> Departments { get; set; } = new();
        public DepartmentPageViewModel(List<Department> departments)
        {
            Departments = departments;
        }
    }
}
