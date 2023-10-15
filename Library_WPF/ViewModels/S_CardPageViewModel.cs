using Library_DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WPF.ViewModels
{
    public class S_CardPageViewModel
    {
        public List<S_Card> S_Cards { get; set; }
        public S_CardPageViewModel(List<S_Card> s_Cards)
        {

            S_Cards = s_Cards;
        }
    }
}
