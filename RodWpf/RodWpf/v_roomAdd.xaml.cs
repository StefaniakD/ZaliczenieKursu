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
    /// Interaction logic for v_roomAdd.xaml
    /// </summary>
    public partial class v_roomAdd : Window
    {
        public v_roomAdd()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            TextBox tbx = new TextBox();
            tbx = this.tbxRoomNumber;
            if (String.IsNullOrWhiteSpace(tbx.Text))
            {
                MessageBox.Show("Pole numer działki nie może być puste.");
                tbx.Focus();
            }
            else
            {

            }
        }
    }
}
