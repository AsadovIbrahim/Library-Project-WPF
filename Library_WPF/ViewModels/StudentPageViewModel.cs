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
    public class StudentPageViewModel
    {
        public List<Student> Students { get; set; }
        public Repository<Student> studentRepository { get; set; } = new();
        public RelayCommand AddCommand { get; set; }

        public void Add(object? param)
        {
            Student newStudent = new()
            {
                FirstName=Students.Last().FirstName,
                LastName=Students.Last().LastName,
                Id_Group=Students.Last().Id_Group,
                Term=Students.Last().Term,
            };
            studentRepository.Add(newStudent);
            studentRepository.SaveChanges();
        }
        public StudentPageViewModel(List<Student> students)
        {
            Students = students;
            AddCommand = new RelayCommand(Add);
        }
    }
}
