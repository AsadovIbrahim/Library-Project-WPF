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
    public class PressPageViewModel
    {
        public List<Press> Presses { get; set; }
        public RelayCommand AddCommand { get; set; }
        public Repository<Press> pressRepository { get; set; } = new();

        public void Add(object? param)
        {
            Press newPress = new()
            {
                Name = Presses.Last().Name
            };
            pressRepository.Add(newPress);
            pressRepository.SaveChanges();
        }
        public PressPageViewModel(List<Press> presses)
        {
            Presses = presses;
            AddCommand = new RelayCommand(Add);
        }
    }
}
