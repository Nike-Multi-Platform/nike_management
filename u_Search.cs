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
    public partial class u_Search : UserControl
    {
        public u_Search()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
        }
        public string UserSearched { get; set; }
        public event EventHandler ClickChanged;
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if(input_search.Text.Length==0)
            {
                MessageBox.Show("Nothing!");
                return;
            }
            
        }
    }
}
