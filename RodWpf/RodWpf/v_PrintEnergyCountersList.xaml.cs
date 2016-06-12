using System;
using System.Collections.Generic;
using System.Data;
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

namespace RodWpf
{
    /// <summary>
    /// Interaction logic for v_PrintEnergyCountersList.xaml
    /// </summary>
    public partial class v_PrintEnergyCountersList : Window
    {
        public v_PrintEnergyCountersList()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Form f = new Form();

            dataGrid.ItemsSource = f.Load().DefaultView;
        }
    }
}
