using Library_DB.Entities;
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
        public PressPageViewModel(List<Press> presses)
        {

            Presses = presses;
        }
    }
}
