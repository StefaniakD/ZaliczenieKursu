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

namespace RodWpf
{
    /// <summary>
    /// Interaction logic for v_energyConuterAdd.xaml
    /// </summary>
    public partial class v_energyConuterAdd : Window
    {
        public v_energyConuterAdd()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            EnergyCounter ec = new EnergyCounter();
            ComboBox cbx = this.cbxRoomList;

            cbx.ItemsSource = ec.GetRoomSet().DefaultView;
        }
    }
}
