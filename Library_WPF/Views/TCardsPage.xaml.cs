using Library_DB.Entities;
using Library_WPF.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Library_WPF.Views
{
    
    public partial class TCardsPage : Page
    {
        public TCardsPage(DbSet<T_Card> t_Cards)
        {
            InitializeComponent();
            DataContext = new T_CardPageViewModel(t_Cards.ToList());
        }
    }
}
