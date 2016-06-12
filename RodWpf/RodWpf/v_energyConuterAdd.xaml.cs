using System;
using System.Windows;
using System.Windows.Controls;

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
            cbx.DisplayMemberPath = "roomNumber";
            cbx.IsEditable = true;
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            TextBox tbxEcn = this.tbxEnergyConuterNumber;
            TextBox tbxMd = this.tbxMountDate;
            TextBox tbxVd = this.tbxValidDate;

            Validation vld = new Validation();

            vld.AddToBoxList(labelNumber.Content.ToString(), tbxEcn);
            vld.AddToBoxList(labelMd.Content.ToString(), tbxMd);
            vld.AddToBoxList(labelVd.Content.ToString(), tbxVd);

            TextBox firstErrorBox = vld.IsRequired();

            if (firstErrorBox != null)
            {
                firstErrorBox.Focus();
            }
            else
            {
                try
                {
                    this.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}
