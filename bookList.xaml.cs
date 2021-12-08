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
using System.Windows.Shapes;

namespace bibliotech
{
    /// <summary>
    /// Логика взаимодействия для bookList.xaml
    /// </summary>
    public partial class bookList : Window
    {
        public bookList()
        {
            InitializeComponent();
            booklist.ItemsSource = Class1.bd.Quality.ToList();
            booklist.ItemsSource = Class1.bd.Format.ToList();
            booklist.ItemsSource = Class1.bd.BookList.ToList();
        }

        private void deleteBook_Click(object sender, RoutedEventArgs e)
        {
            var delete = booklist.SelectedItem as BookList;
            Class1.bd.BookList.Remove(delete);
            Class1.bd.SaveChanges();
            booklist.ItemsSource = Class1.bd.Quality.ToList();
        }

        private void addBook_Click(object sender, RoutedEventArgs e)
        {
            addTheBook add = new addTheBook();
            add.Show();
        }
    }
}
