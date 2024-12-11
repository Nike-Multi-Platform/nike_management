using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nike_Shop_Management.CustomControl
{
    public class NumberTextBox : ComponentFactory.Krypton.Toolkit.KryptonTextBox
    {
        private ErrorProvider error = new ErrorProvider();
        public NumberTextBox()
        {
            this.Text = "";
            this.KeyPress += new KeyPressEventHandler(NumberTextBox_KeyPress);
        }

        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
