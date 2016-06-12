using System;
using System.Windows;
using System.Windows.Controls;

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
            

            Validation vld = new Validation();
            TextBox tbx = this.tbxRoomNumber;

            vld.AddToBoxList(label.Content.ToString(), tbx);

            Rooms room = new Rooms();

            TextBox firstErrorBox = vld.IsRequired();

            if (firstErrorBox!=null)
            {
                firstErrorBox.Focus();
            }
            else
            {
                try
                {
                    room.Add(tbx.Text);
                    this.Close();
                }
                catch ( Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}
