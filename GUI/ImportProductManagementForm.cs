using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using LibDAL;
using LibDTO;
using Nike_Shop_Management.GUI.Test;

namespace Nike_Shop_Management.GUI
{
    public partial class ImportProductManagementForm : Form
    {
        private DbContextDataContext _db = new DbContextDataContext();
        private List<ProductImportDTO> productImportDTOs = new List<ProductImportDTO>();
        private string product_name_select = "";
        public ImportProductManagementForm()
        {
            InitializeComponent();
        }

        private void ImportProductManagementForm_Load(object sender, EventArgs e)
        {
            // Load datagridview
            loadProductOnDataGridView();
            // Edit datagridview
            editKryptonDataGridView1And2();
        }

        private void editKryptonDataGridView1And2()
        {
            // Ẩn những cột không mong muốn
            kryptonDataGridView1.Columns["product_icon"].Visible = false;
            kryptonDataGridView1.Columns["sub_category"].Visible = false;
        }
        private void loadProductOnDataGridView()
        {
            var products = _db.product_parents.ToList();
            kryptonDataGridView1.DataSource = products;
        }

        private void kryptonDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sự kiện khi nhấn vào 1 dòng trong datagridview
            if (e.RowIndex > -1)
            {
                // gán tên product_name_select để sử dụng ở các sự kiện khác
                product_name_select = kryptonDataGridView1.Rows[e.RowIndex].Cells["product_parent_name"].Value.ToString();
                // Lấy product_parent_id của dòng đó
                int product_parent_id = Convert.ToInt32(kryptonDataGridView1.Rows[e.RowIndex].Cells["product_parent_id"].Value);
                // Lấy ra những sản phẩm con của product_parent_id đó
                var productColors = _db.products.Where(t => t.product_parent_id == product_parent_id).ToList();
                // Hiển thị lên combobox
                if (productColors.Count > 0)
                {
                    kryptonComboBox1.DataSource = productColors;
                    kryptonComboBox1.DisplayMember = "product_color_shown";
                    kryptonComboBox1.ValueMember = "product_id";
                    kryptonComboBox1.SelectedIndex = 0;
                }
            }
        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn màu chưa
            // Sự kiện mỗi khi chọn 1 màu khác nhau
            // Load các size của màu đó vào combobox 2 gồm mã size tên size
            if (kryptonComboBox1.SelectedValue != null &&
    int.TryParse(kryptonComboBox1.SelectedValue.ToString(), out int product_id))
            {
                // Sử dụng product_id
                var productSizes = _db.product_sizes.Where(t => t.product_id == product_id)
                    .Select(pz => new
                    {
                        pz.size_id,
                        pz.size.size_name
                    })
                    .ToList();
                kryptonComboBox2.DataSource = productSizes;
                kryptonComboBox2.DisplayMember = "size_name";
                kryptonComboBox2.ValueMember = "size_id";
            }
            else
            {
                // Xử lý khi giá trị không hợp lệ
                //KryptonMessageBox.Show("Vui lòng chọn một màu hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            int product_id = Convert.ToInt32(kryptonComboBox1.SelectedValue);
            string product_name = product_name_select;
            string product_color = kryptonComboBox1.Text;
            int size_id = Convert.ToInt32(kryptonComboBox2.SelectedValue);
            string product_size = kryptonComboBox2.Text;
            int quantity = Convert.ToInt32(kryptonNumericUpDown1.Value);
            int price = Convert.ToInt32(kryptonNumericUpDown2.Value);
            int total_price = quantity * price;

            // Tìm xem có sản phẩm đó chưa dựa vào product_id và size_id
            var productImportDTO1 = productImportDTOs.FirstOrDefault(t => t.product_id == product_id && t.product_size_id == size_id);
            if (productImportDTO1 != null)
            {
                return;
            }
            if (product_id == 0 || size_id == 0 || quantity == 0 || price == 0)
            {
                KryptonMessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                ProductImportDTO productImportDTO = new ProductImportDTO();
                productImportDTO.product_id = product_id;
                productImportDTO.product_name = product_name;
                productImportDTO.product_color = product_color;
                productImportDTO.product_size_id = size_id;
                productImportDTO.product_size = product_size;
                productImportDTO.quantity = quantity;
                productImportDTO.price = price;
                productImportDTO.total_price = total_price;
                productImportDTOs.Add(productImportDTO);
            }

            // Cập nhật lên datagridview 2
            loadProductImportOnDataGridView2();

            // Reset lại các control
            kryptonNumericUpDown1.Value = 1;
            kryptonNumericUpDown2.Value = 100000;
        }

        private void loadProductImportOnDataGridView2()
        {
            kryptonDataGridView2.DataSource = null;
            kryptonDataGridView2.DataSource = productImportDTOs;

            // Kiểm tra nếu cột nút "Xóa" đã tồn tại
            if (!kryptonDataGridView2.Columns.Contains("DeleteButton"))
            {
                // Thêm nút xóa vào datagridview
                KryptonDataGridViewButtonColumn btn = new KryptonDataGridViewButtonColumn();
                btn.HeaderText = "Xóa";
                btn.Text = "Xóa";
                btn.Name = "DeleteButton"; // Đặt tên cho cột
                btn.UseColumnTextForButtonValue = true;
                kryptonDataGridView2.Columns.Add(btn);
            }
            else
            {
                // Đảm bảo cột "Xóa" luôn ở cuối bảng
                var deleteColumn = kryptonDataGridView2.Columns["DeleteButton"];
                kryptonDataGridView2.Columns.Remove(deleteColumn);
                kryptonDataGridView2.Columns.Add(deleteColumn);
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            // Hỏi trước khi nhập hàng
            DialogResult dialogResult = KryptonMessageBox.Show("Bạn có chắc chắn muốn nhập hàng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            // Sự kiện nhập hàng
            // Kiểm tra xem người dùng có chọn các sản phẩm để nhập không
            if (productImportDTOs.Count == 0)
            {
                KryptonMessageBox.Show("Vui lòng chọn sản phẩm cần nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Ngược lại thì tạo 1 phiếu nhập mới
            goods_receipt goodsReceipt = new goods_receipt();
            goodsReceipt.user_id = "2MgJDl90HugryliQBcewj1Y4Cha2";
            goodsReceipt.supplier_id = 1;
            goodsReceipt.created_at = DateTime.Now;
            goodsReceipt.total_price = 0;
            goodsReceipt.is_handle = false;
            _db.goods_receipts.InsertOnSubmit(goodsReceipt);
            _db.SubmitChanges();

            // Tạo chi tiết phiếu nhập
            foreach(ProductImportDTO productImportDTO in productImportDTOs)
            {
                goods_receipt_detail goodsReceiptDetail = new goods_receipt_detail();
                goodsReceiptDetail.good_receipt_id = goodsReceipt.goods_receipt_id;
                goodsReceiptDetail.product_id = productImportDTO.product_id;
                goodsReceiptDetail.product_size_id = productImportDTO.product_size_id;
                goodsReceiptDetail.quantity = productImportDTO.quantity;
                goodsReceiptDetail.import_price = productImportDTO.price;
                goodsReceiptDetail.total_price = productImportDTO.total_price;
                _db.goods_receipt_details.InsertOnSubmit(goodsReceiptDetail);
                // Cập nhật lại tổng tiền của phiếu nhập
                goodsReceipt.total_price += productImportDTO.total_price;
            }

            _db.SubmitChanges();
            KryptonMessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset lại productImportDTOs
            productImportDTOs = new List<ProductImportDTO>();
            loadProductImportOnDataGridView2();
        }

        private void kryptonDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                //  Trường hợp khi nhấn vào nút xóa
                if (kryptonDataGridView2.Columns[e.ColumnIndex] is KryptonDataGridViewButtonColumn)
                {
                    // Xóa dòng đó ra khỏi list và cập nhật lại datagridview
                    productImportDTOs.RemoveAt(e.RowIndex);
                    loadProductImportOnDataGridView2();
                }
                else
                {
                    // Lấy ra các thông tin của dòng đó và hiển thị lên các control
                }
            }
        }

        private void kryptonDataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem dòng được nhấp có hợp lệ không (không phải tiêu đề cột)
            if (e.RowIndex >= 0)
            {
                // Lấy sản phẩm được click
                ProductImportDTO productImportDTO = productImportDTOs[e.RowIndex];
                EditProductImportItemForm editProductImportItemForm = new EditProductImportItemForm(productImportDTO);
                editProductImportItemForm.handleSaveProductImportItem = new EditProductImportItemForm.saveProductImportItem(saveProductImportItem);
                editProductImportItemForm.ShowDialog();
            }
        }

        private void saveProductImportItem(ProductImportDTO productImportDTO)
        {
            // Cập nhật lại list và datagridview
            ProductImportDTO productImportDTO1 = productImportDTOs.FirstOrDefault(t => t.product_id == productImportDTO.product_id && t.product_size_id == productImportDTO.product_size_id);
            if (productImportDTO1 != null)
            {
                productImportDTO1.quantity = productImportDTO.quantity;
                productImportDTO1.price = productImportDTO.price;
                productImportDTO1.total_price = productImportDTO.quantity * productImportDTO.price;
            }
            loadProductImportOnDataGridView2();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            // Xử lý thoát
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            KryptonMessageBox.Show("Chưa làm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
