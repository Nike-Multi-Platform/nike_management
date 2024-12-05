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
    public partial class SizeManagement : Form
    {
        private DbContextDataContext db = new DbContextDataContext();
        public SizeManagement()
        {
            InitializeComponent();
        }

        private void SizeManagement_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            editDataGridView();
        }

        private void loadDataGridView()
        {
            var sizes = db.sizes.Select(s => new
            {
                s.size_id,
                s.size_name
            });
            kryptonDataGridView1.DataSource = sizes;
        }
        private void editDataGridView()
        {
            // Thêm nút sửa
            KryptonDataGridViewButtonColumn btnEdit = new KryptonDataGridViewButtonColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.Text = "Sửa";
            btnEdit.HeaderText = "Sửa";
            btnEdit.UseColumnTextForButtonValue = true;
            kryptonDataGridView1.Columns.Add(btnEdit);

            // Thêm nút xóa
            KryptonDataGridViewButtonColumn btnDelete = new KryptonDataGridViewButtonColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "Xóa";
            btnDelete.HeaderText = "Xóa";
            btnDelete.UseColumnTextForButtonValue = true;
            kryptonDataGridView1.Columns.Add(btnDelete);
        }

        private void kryptonDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                // Kiểm tra nếu click vào nút sửa
                if (kryptonDataGridView1.Columns[e.ColumnIndex].Name == "btnEdit")
                {
                    // Xử lý sửa
                    // Lấy size_id
                    int size_id = Convert.ToInt32(kryptonDataGridView1.Rows[e.RowIndex].Cells["size_id"].Value);
                    handleEdit(size_id);
                }
                // Kiểm tra nếu click vào nút xóa
                if (kryptonDataGridView1.Columns[e.ColumnIndex].Name == "btnDelete")
                {
                    // Xử lý xóa
                    // Lấy size_id
                    int size_id = Convert.ToInt32(kryptonDataGridView1.Rows[e.RowIndex].Cells["size_id"].Value);
                    handleDelete(size_id);
                }
            }
        }

        private void handleEdit(int size_id)
        {
            // Tìm size
            size size = db.sizes.Where(s => s.size_id == size_id).FirstOrDefault();
            // Mở form con
            EditSizeName editSizeName = new EditSizeName(size);
            editSizeName.handleSaveSize = new EditSizeName.saveSize(saveSize);
            editSizeName.ShowDialog();
        }
        private void saveSize(size size)
        {
            db.SubmitChanges();
            KryptonMessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadDataGridView();
        }

        private void handleDelete(int size_id)
        {
            // Hỏi trước khi xóa
            DialogResult result = KryptonMessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            // Kiểm tra xem có sản phẩm nào dùng size này chưa
            var product_sizes = db.product_sizes.Where(p => p.size_id == size_id).ToList();
            if (product_sizes.Count > 0)
            {
                KryptonMessageBox.Show("Không thể xóa size này vì có sản phẩm đang sử dụng size này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var size = db.sizes.Where(s => s.size_id == size_id).FirstOrDefault();
                db.sizes.DeleteOnSubmit(size);
                db.SubmitChanges();
                KryptonMessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDataGridView();
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            // Kiểm tra textBox có rỗng không
            if (kryptonTextBox1.Text.Length < 1)
            {
                KryptonMessageBox.Show("Vui lòng nhập tên size", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                // Tìm theo tên xem đã tồn tại chưa
                var size = db.sizes.Where(s => s.size_name == kryptonTextBox1.Text).FirstOrDefault();
                if (size != null)
                {
                    KryptonMessageBox.Show("Size này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    // Thêm size mới
                    size new_size = new size();
                    new_size.size_name = kryptonTextBox1.Text;
                    db.sizes.InsertOnSubmit(new_size);
                    db.SubmitChanges();
                    KryptonMessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGridView();
                }
            }
        }
    }
}
