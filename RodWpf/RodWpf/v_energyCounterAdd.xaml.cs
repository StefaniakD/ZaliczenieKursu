using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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

            Rooms room = new Rooms();
            ComboBox cbx = this.cbxRoomList;

            Dictionary<int, string> comboSource = new Dictionary<int, string>();

            DataTable dt = room.GetRoomSet();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboSource.Add((int)dt.Rows[i]["roomId"], dt.Rows[i]["roomNumber"].ToString());
            }
            
            cbx.ItemsSource = comboSource;
            cbx.DisplayMemberPath = "Value";
            cbx.IsEditable = true;
            cbx.Focusable = true;
            
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            TextBox tbxEcn = this.tbxEnergyConuterNumber;
            TextBox tbxMd = this.tbxMountDate;
            TextBox tbxVd = this.tbxValidDate;
            ComboBox cbx = this.cbxRoomList;

            Validation vld = new Validation();
            EnergyCounter ec = new EnergyCounter();

            vld.AddToBoxList(labelNumber.Content.ToString(), tbxEcn);
            vld.AddToBoxList(labelMd.Content.ToString(), tbxMd);
            vld.AddToBoxList(labelVd.Content.ToString(), tbxVd);
            
            TextBox firstErrorBox = vld.IsRequired();
            
            if (firstErrorBox != null)
            {
                firstErrorBox.Focus();
            }
            else if (!vld.IsDate(tbxMd)) tbxMd.Focus();
            else if (!vld.IsDate(tbxVd)) tbxVd.Focus();
            else
            {
                try
                {
                    ec.Add(tbxEcn.Text,tbxMd.Text,tbxVd.Text, ((KeyValuePair<int, string>)cbx.SelectedItem).Key);
                    this.Close();
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Kwatera o podanym numerze nie istnieje.");
                    this.cbxRoomList.Text = null;
                    this.cbxRoomList.Focus();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.GetType().ToString());
                }
            }
        }
    }
}
