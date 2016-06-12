using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RodWpf
{
    public struct Box
    {
        public string name;
        public TextBox tbx;
    }


    class Validation
    {
        private List<Box> BoxList;

        public Validation()
        {
            BoxList = new List<Box>();
        }

        public void AddToBoxList(string name,TextBox tbx)
        {
            Box b = new Box();
            b.name = name;
            b.tbx = tbx;
            BoxList.Add(b);
        }

        private Boolean IsFilled(string boxValue)
        {
            if (String.IsNullOrWhiteSpace(boxValue)) return false;
            return true;
        }

        public TextBox IsRequired()
        {
            TextBox firstError = null;
            string message = null;

            foreach(Box b in BoxList)
            {
                if (!IsFilled(b.tbx.Text))
                {
                    message += "Pole " + b.name + " nie może być puste.\r\n";
                    if (firstError == null) firstError = b.tbx;
                }
            }
            if (message != null)
            {
                MessageBox.Show(message);
                return firstError;
            }
            else return null;
        }
    }
}
