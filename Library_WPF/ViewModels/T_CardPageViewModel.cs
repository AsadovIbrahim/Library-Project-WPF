using Library_DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WPF.ViewModels
{
    public class T_CardPageViewModel
    {
        public List<T_Card> T_Cards { get; set; } = new();
        public T_CardPageViewModel(List<T_Card> t_Cards)
        {
            T_Cards = t_Cards;
        }
    }
}
