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

namespace Nike_Shop_Management.GUI.Test
{
    public partial class EditProductImportItemForm : Form
    {
        private ProductImportDTO productImportDTO;
        public delegate void saveProductImportItem(ProductImportDTO productImportDTO);
        public saveProductImportItem handleSaveProductImportItem;
        public EditProductImportItemForm(ProductImportDTO productImportDTO)
        {
            InitializeComponent();
            this.productImportDTO = productImportDTO;
        }

        private void EditProductImportItemForm_Load(object sender, EventArgs e)
        {
            this.kryptonNumericUpDown1.Value = this.productImportDTO.quantity;
            this.kryptonNumericUpDown2.Value = this.productImportDTO.price;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            handleSaveProductImportItem(this.productImportDTO);
            this.Close();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.productImportDTO.quantity = Convert.ToInt32(this.kryptonNumericUpDown1.Value);
        }

        private void kryptonNumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.productImportDTO.price = Convert.ToInt32(this.kryptonNumericUpDown2.Value);
        }
    }
}
