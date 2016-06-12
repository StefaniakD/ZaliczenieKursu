//Program tworzony przez trzech uczestników kursu!!!
//Paula Piórecka
//Piotr Piórecki
//Dominik Stefaniak

using System.Windows;

namespace RodWpf
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

        private void buttonAddRoom_Click(object sender, RoutedEventArgs e)
        {
            v_roomAdd form = new v_roomAdd();
            form.Show();
        }

        private void buttonPrintList_Click(object sender, RoutedEventArgs e)
        {
            v_PrintEnergyCountersList form = new v_PrintEnergyCountersList();
            form.Show();
        }

        private void buttonAddEnergyConuter_Click(object sender, RoutedEventArgs e)
        {
            v_energyConuterAdd form = new v_energyConuterAdd();
            form.Show();
        }

        private void buttonChangeEnergyPrice_Click(object sender, RoutedEventArgs e)
        {
            v_changeEnergyPrice form = new v_changeEnergyPrice();
            form.Show();
        }
    }
}
