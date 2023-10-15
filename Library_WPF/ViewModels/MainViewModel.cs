using Library_DB.Contexts;
using Library_WPF.Commands;
using Library_WPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Library_WPF.ViewModels
{
    public class MainViewModel
    {
        public LibraryDbContext context { get; set; } = new();
        public RelayCommand? CloseAppCommand { get; set; }
        public RelayCommand? AuthorsCommand { get; set; }
        public RelayCommand? BooksCommand { get; set; }
        public RelayCommand? CategoriesCommand { get; set; }
        public RelayCommand? DepartmentsPageCommand { get; set; }
        public RelayCommand? FacultiesPageCommand { get; set; }
        public RelayCommand? GroupsCommand { get; set; }
        public RelayCommand? LibsCommand { get; set; }
        public RelayCommand? PressCommand { get; set; }
        public RelayCommand? S_CardCommand { get; set; }
        public RelayCommand? StudentsCommand { get; set; }
        public RelayCommand? T_CardCommand { get; set; }
        public RelayCommand? TeachersCommand { get; set; }
        public RelayCommand? ThemesCommand { get; set; }






        private Frame? currentFrame;

        public void CloseCommand(object? param)
        {
            App.Current.MainWindow.Close();
        }
        public void AuthorsTable(object? param)
        {
            currentFrame!.Content = new AuthorPage(context.Authors!);
        }

        public void BooksTable(object? param)
        {
            currentFrame!.Content = new BooksPage(context.Books!);
        }
        public void CategoriesTable(object? param)
        {
            currentFrame!.Content = new CategoryPage(context.Categories!);
        }
        public void DepartmentsTable(object? param)
        {
            currentFrame!.Content = new DepartmentsPage(context.Departments!);
        }

        public void FacultiesTable(object? param)
        {
            currentFrame!.Content = new FacultiesPage(context.Faculties!);

        }

        public void GroupTable(object? param)
        {
            currentFrame!.Content = new GroupPage(context.Groups!);
        }

        public void LibTable(object? param)
        {
            currentFrame!.Content = new LibsPage(context.Libs!);
        }

        public void PressTable(object? param)
        {
            currentFrame!.Content = new PressPage(context.Presses!);
        }

        public void SCardTable(object? param)
        {
            currentFrame!.Content = new SCardsPage(context.S_Cards!);
        }
        public void StudentTable(object? param)
        {
            currentFrame!.Content = new StudentPage(context.Students!);
        }

        public void TCardTable(object? param)
        {
            currentFrame!.Content = new TCardsPage(context.T_Cards!);
        }

        public void TeachersTable(object? param)
        {
            currentFrame!.Content = new TeachersPage(context.Teachers!);
        }

        public void ThemesTable(object? param)
        {
            currentFrame!.Content = new ThemesPage(context.Themes!);
        }



        public MainViewModel(Frame frame)
        {
            currentFrame = frame;
            CloseAppCommand = new(CloseCommand);
            AuthorsCommand = new(AuthorsTable);
            BooksCommand = new(BooksTable);
            CategoriesCommand = new(CategoriesTable);
            DepartmentsPageCommand = new(DepartmentsTable);
            FacultiesPageCommand = new(FacultiesTable);
            GroupsCommand = new(GroupTable);
            LibsCommand = new(LibTable);
            PressCommand = new(PressTable);
            S_CardCommand = new(SCardTable);
            StudentsCommand = new(StudentTable);
            T_CardCommand = new(TCardTable);
            TeachersCommand = new(TeachersTable);
            ThemesCommand = new(ThemesTable);
        }
    }
}
