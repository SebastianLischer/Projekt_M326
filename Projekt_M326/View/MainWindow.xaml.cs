//using Projekt_M326.Model;
using Projekt_M326.Model;
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

namespace Projekt_M326
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (var ctx = new DatabaseContext())
            {
                var stud = new User() { UserFirstName = "Bill", UserLastName = "test" };

                ctx.Users.Add(stud);
                ctx.SaveChanges();
            }
        }

        private void btn_rasterErstellen_page(object sender, RoutedEventArgs e)
        {
            Main.Content = new RasterErstellen();

        }

        private void btn_rasterAnschauen_page(object sender, RoutedEventArgs e)
        {
            Main.Content = new RasterAnschauen();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
