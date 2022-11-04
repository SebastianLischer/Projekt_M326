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
        }

        private void btn_rasterErstellen_page(object sender, RoutedEventArgs e)
        {
            Main.Content = new RasterErstellen();


            //using (var ctx = new M326Db())
            //{
            //    var stud = new User() { FirstName = "Bill" };

            //    ctx.Users.Add(stud);
            //    ctx.SaveChanges();
            //}
        }
    }
}
