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
    
    public partial class StudentPage : Page
    {
        public StudentPage(DbSet<Student> students)
        {
            InitializeComponent();
            DataContext=new StudentPageViewModel(students.ToList());
        }
    }
}
