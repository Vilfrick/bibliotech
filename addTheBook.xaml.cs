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
    /// Логика взаимодействия для addTheBook.xaml
    /// </summary>
    public partial class addTheBook : Window
    {
        public addTheBook()
        {
            InitializeComponent();
            formatb.ItemsSource = Class1.bd.Format.ToList();
            qualityb.ItemsSource = Class1.bd.Quality.ToList();
            genreb.ItemsSource = Class1.bd.BookGenre.ToList();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            var item = formatb.SelectedItem as Format;
            var item2 = qualityb.SelectedItem as Quality;
            var item3 = genreb.SelectedItem as BookGenre;

            
            int item4 = Convert.ToInt32(amountb.Text);

            Class1.bd.BookList.Add(new BookList
            {
                bookName = nameb.Text,
                amountPages = item4,
                format_id = item.id,
                publisher = publisherb.Text,
                quality_id = item2.id,
                author = authorb.Text,
                publicationDate = dateb.SelectedDate,
                bookGenre_id = item3.id,
                note = notesB.Text

            });

            Class1.bd.SaveChanges();
            
            formatb.ItemsSource = Class1.bd.Format.ToList();
            qualityb.ItemsSource = Class1.bd.Quality.ToList();
            genreb.ItemsSource = Class1.bd.BookGenre.ToList();

            
        }
    }
}
