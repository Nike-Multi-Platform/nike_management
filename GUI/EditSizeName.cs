using LibDAL;
using LibDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nike_Shop_Management.GUI
{
    public partial class EditSizeName : Form
    {
        public delegate void saveSize(size size);
        public saveSize handleSaveSize;
        public size size;
        public EditSizeName(size size)
        {
            InitializeComponent();
            this.size = size;
        }

        private void EditSizeName_Load(object sender, EventArgs e)
        {
            kryptonTextBox1.Text = this.size.size_name;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.size.size_name = this.kryptonTextBox1.Text;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (this.kryptonTextBox1.Text.Length < 1)
            {
                MessageBox.Show("Tên size không được để trống");
                return;
            }
            handleSaveSize(this.size);
            this.Close();
        }
    }
}
