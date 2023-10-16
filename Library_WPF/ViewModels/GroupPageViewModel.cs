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
    public class GroupPageViewModel
    {
        public List<Group> Groups { get; set; } = new();
        public Repository<Group> groupRepository { get; set; } = new();
        public RelayCommand AddCommand { get; set; }

        public void Add(object? param)
        {
            Group newGroup = new()
            {
                Name=Groups.Last().Name,
                Id_Faculty=Groups.Last().Id_Faculty,
            };
            groupRepository.Add(newGroup);
            groupRepository.SaveChanges();
        }
        public GroupPageViewModel(List<Group> groups)
        {
            Groups = groups;
            AddCommand = new RelayCommand(Add);
        }
    }
}
