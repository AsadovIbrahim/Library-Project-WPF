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
    public class S_CardPageViewModel
    {
        public List<S_Card> S_Cards { get; set; }
        public RelayCommand AddCommand { get; set; }
        public Repository<S_Card> sCardsRepository { get; set; } = new();

        public void Add(object? param)
        {
            S_Card newS_Cards = new()
            {
                Id_Student = S_Cards.Last().Id_Student,
                Id_Book = S_Cards.Last().Id_Book,
                DateOut = S_Cards.Last().DateOut,
                DateIn = S_Cards.Last().DateIn,
                Id_Lib = S_Cards.Last().Id_Lib
            };
            sCardsRepository.Add(newS_Cards);
            sCardsRepository.SaveChanges();
        }
        public S_CardPageViewModel(List<S_Card> s_Cards)
        {
            S_Cards = s_Cards;
            AddCommand = new RelayCommand(Add);
        }
    }
}
