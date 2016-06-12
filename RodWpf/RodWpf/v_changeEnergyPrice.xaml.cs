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
    /// Interaction logic for v_changeEnergyPrice.xaml
    /// </summary>
    public partial class v_changeEnergyPrice : Window
    {
        public v_changeEnergyPrice()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            EnergyPrice ep = new EnergyPrice();

            ep.Select();

            tbxPrice.Text = ep.Price.ToString();
            tbxIssueDate.Text = ep.IssueDate;
            tbxToPayDays.Text = ep.ToPayDays.ToString();
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            EnergyPrice ep = new EnergyPrice();

            ep.Price = Convert.ToSingle(tbxPrice.Text.ToString());
            ep.IssueDate = tbxIssueDate.Text;
            ep.ToPayDays = Int32.Parse(tbxToPayDays.Text);

            ep.Update();

            this.Close();
        }
    }
}
