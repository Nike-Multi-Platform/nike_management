using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace Nike_Shop_Management.CustomControl
{
    public class PriceTextBox : ComponentFactory.Krypton.Toolkit.KryptonTextBox
    {
        private ErrorProvider error = new ErrorProvider();
        public PriceTextBox()
        {
            this.Text = "";
            this.KeyPress += new KeyPressEventHandler(PriceTextBox_KeyPress);
        }

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
                error.SetError(this, "Chỉ được phép nhập số.");
            }
            else
            {
                error.Clear();
            }
        }

    }
}
