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
    public class FacultyPageViewModel
    {
        public List<Faculty> Faculties { get; set; } = new();
        public Repository<Faculty> facultyRepository { get; set; } = new();
        public RelayCommand AddCommand { get; set; }

        public void Add(object? param)
        {
            Faculty newFaculty = new()
            {
                Name = Faculties.Last().Name
            };
            facultyRepository.Add(newFaculty);
            facultyRepository.SaveChanges();
        }

        public FacultyPageViewModel(List<Faculty> faculties)
        {
            Faculties = faculties;
            AddCommand = new RelayCommand(Add);

        }

    }
}
