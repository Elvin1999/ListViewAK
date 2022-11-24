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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Book> Books { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Books = new List<Book>
            {
                new Book
                {
                     Title="Crime and Punishment",
                      AuthorName="Dostoyevskiy",
                       Page=750
                },
                new Book
                {
                     Title="Rich Dad Poor Dad ",
                      AuthorName="Robert Kiyosoki",
                       Page=350
                },
                new Book
                {
                     Title="Think and Grow",
                      AuthorName="Napoloen Hill",
                       Page=150
                },
            };

            this.DataContext = this;
            // booksListView.ItemsSource=Books;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ListView lv)
            {
                var book = lv.SelectedItem as Book;
               // MessageBox.Show(book.Title);
            }
        }

        private void MenuItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Background = Brushes.Red;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Background= new SolidColorBrush(Colors.Red);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

            this.Background= new SolidColorBrush(Colors.SpringGreen);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            this.Background= new SolidColorBrush(Colors.DeepPink);

        }
    }
}
