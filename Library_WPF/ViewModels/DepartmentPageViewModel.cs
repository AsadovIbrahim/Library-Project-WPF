using Library_DB.Entities;
using Library_DB.Repositories.Concrets;
using Library_WPF.Commands;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
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
        public RelayCommand AddCommand { get; set; }
        public Repository<Department> departmentRepository { get; set; } = new();

        public void Add(object? param)
        {
            Department newDepartment = new()
            {
                Name = Departments.Last().Name
            };
            departmentRepository.Add(newDepartment);
            departmentRepository.SaveChanges();
        }
        public DepartmentPageViewModel(List<Department> departments)
        {
            Departments = departments;
            AddCommand=new RelayCommand(Add);
        }
    }
}
