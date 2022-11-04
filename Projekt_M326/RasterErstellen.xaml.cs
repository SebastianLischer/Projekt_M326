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
    /// Interaction logic for RasterErstellen.xaml
    /// </summary>
    public partial class RasterErstellen : Page
    {
        public RasterErstellen()
        {
            InitializeComponent();
            DataContext = new Data();
        }

        private void btnRasterErstelen(object sender, RoutedEventArgs e)
        {
            
        }
    }

    public class Job
    {
        public string Name { get; set; }

        public Job(string name)
        {
            Name = name;
        }
    }

    public class Data
    {
        //load list of Jobs from Database
        public Data()
        {
            ListOfJobs = new List<Job>();
            ListOfJobs.Add(new Job("TestRNA"));
            ListOfJobs.Add(new Job("Test"));
        }
        public List<Job> ListOfJobs { get; set; }
    }
}
