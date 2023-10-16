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
    public class TeacherPageViewModel
    {
        public List<Teacher> Teachers { get; set; } = new();

        public RelayCommand AddCommand { get; set; }
        public Repository<Teacher> teacherRepository { get; set; } = new();

        public void Add(object? param)
        {
            Teacher newTeacher = new()
            {
                FirstName=Teachers.Last().FirstName,
                LastName=Teachers.Last().LastName,
                Id_Dep=Teachers.Last().Id_Dep,
            };
            teacherRepository.Add(newTeacher);
            teacherRepository.SaveChanges();
        }
        public TeacherPageViewModel(List<Teacher> teachers)
        {
            Teachers = teachers;
            AddCommand = new RelayCommand(Add);
        }
       
    }
}
