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
    public class LibsPageViewModel
    {
        public List<Lib> Libs { get; set; } = new();

        public RelayCommand AddCommand { get; set; }
        public Repository<Lib> libsRepository { get; set; } = new();

        public void Add(object? param)
        {
            Lib newLibs = new()
            {
                FirstName = Libs.Last().FirstName,
                LastName = Libs.Last().LastName,
            };
            libsRepository.Add(newLibs);
            libsRepository.SaveChanges();
        }
        public LibsPageViewModel(List<Lib> libs)
        {
            Libs = libs;
            AddCommand = new RelayCommand(Add);
        }
    }
}
