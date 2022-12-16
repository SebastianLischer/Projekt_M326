using Projekt_M326.Model;
using Projekt_M326.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
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
        MainWindow main;
        public RasterAnschauen(MainWindow window)
        {
            main = window;
            InitializeComponent();
            comboBoxRaster.DataContext = new Data2();
        }

        private void RasterLaden(object sender, RoutedEventArgs e)
        {
            if(comboBoxRaster.SelectedItem == null)
            {
                FehlerMeldung.Text = "Sie müssen zuerst ein Raster auswählen";
            }
            else
            {
                FehlerMeldung.Text = "";
                using (DatabaseContext db = new DatabaseContext())
                {
                    CompetenceGrid grid = db.CompetenceGrids
                        .Include(x => x.Job)
                        .FirstOrDefault(b => b.Name == ((CompetenceGrid)comboBoxRaster.SelectedItem).Name);

                    main.ShowCompetence(grid);
                }
            }
        }
       
    }

    public class Data2
    {
        public Data2()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                ListOfGrids = db.CompetenceGrids.ToList<CompetenceGrid>();
            }
        }
        public List<CompetenceGrid> ListOfGrids { get; set; }
    }

}
