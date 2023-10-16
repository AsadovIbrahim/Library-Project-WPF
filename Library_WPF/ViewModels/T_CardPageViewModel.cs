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
    public class T_CardPageViewModel
    {
        public List<T_Card> T_Cards { get; set; } = new();
        public RelayCommand AddCommand { get; set; }
        public Repository<T_Card> tCardsRepository { get; set; } = new();

        public void Add(object? param)
        {
            T_Card newT_Cards = new()
            {
                Id_Teacher=T_Cards.Last().Id_Teacher,
                Id_Book=T_Cards.Last().Id_Book,
                DateOut=T_Cards.Last().DateOut,
                DateIn=T_Cards.Last().DateIn,
                Id_Lib=T_Cards.Last().Id_Lib
            };
            tCardsRepository.Add(newT_Cards);
            tCardsRepository.SaveChanges();
        }
        
        public T_CardPageViewModel(List<T_Card> t_Cards)
        {
            T_Cards = t_Cards;
            AddCommand = new RelayCommand(Add);
        }
    }
}
