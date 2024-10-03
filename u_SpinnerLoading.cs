using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nike_Shop_Management
{
    public partial class u_SpinnerLoading : UserControl
    {
        public u_SpinnerLoading()
        {
            InitializeComponent();
        }
        int dir = 1;
        private void strecth_Tick(object sender, EventArgs e)
        {
            if (circularProgressBar1.Value == 99)
            {
                dir = -1;
                circularProgressBar1.AnimationSpeed = 50;

            }
            else if (circularProgressBar1.Value == 1)
            {
                dir = 1;
                circularProgressBar1.AnimationSpeed = 100;
            }
            circularProgressBar1.Value += dir;
        }
    }
}
