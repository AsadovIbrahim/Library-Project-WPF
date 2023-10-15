using Library_DB.Entities;
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
        public GroupPageViewModel(List<Group> groups)
        {
            Groups = groups;
        }
    }
}
