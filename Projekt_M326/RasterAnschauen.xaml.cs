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
    /// Interaktionslogik für Page1.xaml
    /// </summary>
    public partial class RasterAnschauen : Page
    {
        public RasterAnschauen()
        {
            InitializeComponent();
            comboBoxFach.DataContext = new DataForFach();
            comboBoxRaster.DataContext = new DataForRaster();

        }
    }
    public class Fach
    {
        public string Name { get; set; }

        public Fach(string name)
        {
            Name = name;
        }
    }
    public class Raster
    {
        public string Name2 { get; set; }

        public Raster(string name2)
        {
            Name2 = name2;
        }
    }
    public class DataForFach
    {
        //load list of Fach from Database
        public DataForFach()
        {
            ListOfFach = new List<Fach>();
            ListOfFach.Add(new Fach("TestFAch"));
            ListOfFach.Add(new Fach("TestFach2"));
        }
        public List<Fach> ListOfFach { get; set; }
    }
    public class DataForRaster
    {
        //load list of Raster from Database
        public DataForRaster()
        {
            ListOfRaster = new List<Raster>();
            ListOfRaster.Add(new Raster("Raster"));
            ListOfRaster.Add(new Raster("Raster2"));
        }
        public List<Raster> ListOfRaster { get; set; }
    }
    
}
