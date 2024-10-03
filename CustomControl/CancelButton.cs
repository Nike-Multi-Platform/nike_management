using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace Nike_Shop_Management.CustomControl
{
    public class CancelButton : KryptonButton
    {
        public CancelButton()
        {
            this.Click += CancelButton_Click;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Parent.Visible = false;
            }
            else
            {
                MessageBox.Show("No parent container found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
