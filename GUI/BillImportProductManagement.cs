using ComponentFactory.Krypton.Toolkit;
using LibDAL;
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
    public partial class BillImportProductManagement : Form
    {
        private DbContextDataContext _db = new DbContextDataContext();
        public BillImportProductManagement()
        {
            InitializeComponent();
        }

        private void BillImportProductManagement_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            editDataGridView1();
        }
        private void editDataGridView1()
        {
            // Ẩn những cột không mong muốn
            kryptonDataGridView1.Columns["supplier"].Visible = false;
            kryptonDataGridView1.Columns["user_account"].Visible = false;
        }
        private void loadDataGridView()
        {
            var goodReceipts = _db.goods_receipts.ToList();
            if (goodReceipts.Count < 1)
            {
                KryptonMessageBox.Show("Bạn chưa nhập hàng!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            kryptonDataGridView1.DataSource = goodReceipts;

            // Lấy mã phiếu nhập hàng đầu tiên
            int goodReceiptId = Convert.ToInt32(kryptonDataGridView1.Rows[0].Cells["goods_receipt_id"].Value.ToString());

            // Lấy thông tin chi tiết phiếu nhập hàng
            var goodReceiptDetails = _db.goods_receipt_details.Where(x => x.good_receipt_id == goodReceiptId).ToList();

            // Hiển thị thông tin chi tiết phiếu nhập hàng vào DataGridView2
            kryptonDataGridView2.DataSource = null;
            kryptonDataGridView2.DataSource = goodReceiptDetails;
            editDataGridView2();
        }
        private void editDataGridView2()
        {
            kryptonDataGridView2.Columns["goods_receipt"].Visible = false;
            kryptonDataGridView2.Columns["product"].Visible = false;
            kryptonDataGridView2.Columns["product_size"].Visible = false;
        }

        private void kryptonDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                // Lấy mã phiếu nhập hàng
                int goodReceiptId = Convert.ToInt32(kryptonDataGridView1.Rows[e.RowIndex].Cells["goods_receipt_id"].Value.ToString());

                // Lấy thông tin chi tiết phiếu nhập hàng
                var goodReceiptDetails = _db.goods_receipt_details.Where(x => x.good_receipt_id == goodReceiptId).ToList();

                // Hiển thị thông tin chi tiết phiếu nhập hàng vào DataGridView2
                kryptonDataGridView2.DataSource = null;
                kryptonDataGridView2.DataSource = goodReceiptDetails;
                editDataGridView2();
            }
        }
    }
}
