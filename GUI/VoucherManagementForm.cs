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
using LibBLL;
using LibDTO;

namespace Nike_Shop_Management.GUI
{
    public partial class VoucherManagementForm : Form
    {
        private DiscountVoucherManager _discountVoucherManager = new DiscountVoucherManager();
        public VoucherManagementForm()
        {
            InitializeComponent();
            _discountVoucherManager = new DiscountVoucherManager();
            LoadDiscountVoucher();
        }

        private void VoucherManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadDiscountVoucher()
        {
            try
            {
                List<DiscountVoucherDTO> discountVouchers = _discountVoucherManager.GetAll();
                foreach (var voucher in discountVouchers)
                {
                    if (voucher.discount_type == "BY PERCENT")
                    {
                        voucher.discount_type = "Theo phần trăm";
                    }
                    else if (voucher.discount_type == "NOT BY PERCENT")
                    {
                        voucher.discount_type = "Số tiền giảm";
                    }
                }
                kryptonDataGridView1.DataSource = discountVouchers;

                kryptonDataGridView1.Columns["discount_voucher_id"].Visible = false;
                kryptonDataGridView1.Columns["discription"].Visible = false;
                kryptonDataGridView1.Columns["voucher_code"].HeaderText = "Mã Voucher";
                kryptonDataGridView1.Columns["voucer_name"].HeaderText = "Tên Voucher";
                kryptonDataGridView1.Columns["discount_type"].HeaderText = "Loại giảm giá";
                kryptonDataGridView1.Columns["usage"].HeaderText = "Số lần sử dụng";
                kryptonDataGridView1.Columns["quantity"].HeaderText = "Số lượng";
                kryptonDataGridView1.Columns["min_order_value"].HeaderText = "Gia trị đơn tối thiểu";
                kryptonDataGridView1.Columns["discount_value"].HeaderText = "Giá trị giảm giá";
                kryptonDataGridView1.Columns["discount_max_value"].HeaderText = "Giá trị giảm giá ta";
                kryptonDataGridView1.Columns["discription"].HeaderText = "Mô tả";
                kryptonDataGridView1.Columns["Start_at"].HeaderText = "Ngày bắt đầu";
                kryptonDataGridView1.Columns["Start_at"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                kryptonDataGridView1.Columns["End_at"].HeaderText = "Ngày kết thúc";
                kryptonDataGridView1.Columns["End_at"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUsage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void kryptonDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (kryptonDataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    DiscountVoucherDTO discountVoucher = (DiscountVoucherDTO)kryptonDataGridView1.SelectedRows[0].DataBoundItem;

                    txtId.Text = discountVoucher.discount_voucher_id.ToString();
                    txtVoucherCode.Text = discountVoucher.voucher_code;
                    txtVoucherName.Text = discountVoucher.voucer_name;
                    txtUsage.Text = discountVoucher.usage.ToString();
                    if (cboVoucherType.Items.Contains(discountVoucher.discount_type))
                    {
                        cboVoucherType.SelectedItem = discountVoucher.discount_type;
                    }
                    else
                    {
                        cboVoucherType.SelectedIndex = -1;
                    }
                    txtMinOrderValue.Text = discountVoucher.min_order_value.ToString();
                    txtDiscountValue.Text = discountVoucher.discount_value.ToString();
                    txtMaxDiscountValue.Text = discountVoucher.discount_max_value.ToString();
                    txtDescription.Text = discountVoucher.discription;
                    pickerStartAt.Value = discountVoucher.Start_at;
                    pickerEndAt.Value = discountVoucher.End_at;

                    DateTime now = DateTime.Now;
                    if (now >= discountVoucher.Start_at && now <= discountVoucher.End_at)
                    {
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;

                        kryptonPanel3.Enabled = false;
                    }
                    else if (now > discountVoucher.End_at)
                    {
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;

                        kryptonPanel3.Enabled = false;
                    }
                    else
                    {
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;

                        kryptonPanel3.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            DiscountVoucherDTO enity = new DiscountVoucherDTO();
            enity.voucher_code = txtVoucherCode.Text;
            enity.voucer_name = txtVoucherName.Text;
            enity.usage = Convert.ToInt32(txtUsage.Value);
            enity.quantity = 10;
            enity.discount_type = cboVoucherType.SelectedIndex == 0 ? "BY PERCENT" : "NOT BY PERCENT";
            enity.min_order_value = Convert.ToInt32(txtMinOrderValue.Value);
            enity.discount_value = Convert.ToInt32(txtDiscountValue.Value);
            enity.discount_max_value = Convert.ToInt32(txtMaxDiscountValue.Value);
            enity.discription = txtDescription.Text;
            enity.Start_at = pickerStartAt.Value;
            enity.End_at = pickerEndAt.Value;

            try
            {
                if(checkInvalidValue(enity.quantity) == 1)
                {
                    MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int result = _discountVoucherManager.Add(enity);
                if (result == 0)
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == 3)
                {
                    MessageBox.Show("Mã voucher đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                clearForm();
                LoadDiscountVoucher();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


        }

        private void btnAddQuantity_Click(object sender, EventArgs e)
        {
            DiscountVoucherDTO enity = new DiscountVoucherDTO();
            enity.discount_voucher_id = Convert.ToInt32(txtId.Text);
            enity.quantity = Convert.ToInt32(txtAddQuantity.Value);

            try
            {
                int result = _discountVoucherManager.AddQuantity(enity);
                if (result == 0)
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadDiscountVoucher();
                txtAddQuantity.Value = 0;
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void clearForm()
        {
            txtId.Text = "";
            txtVoucherName.Text = "";
            txtVoucherCode.Text = "";
            txtUsage.Value = 0;
            cboVoucherType.SelectedIndex = -1;
            txtMinOrderValue.Value = 0;
            txtDiscountValue.Value = 0;
            txtMaxDiscountValue.Value = 0;
            txtDescription.Text = "";
            pickerStartAt.Value = DateTime.Now;
            pickerEndAt.Value = DateTime.Now;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = kryptonDataGridView1.SelectedRows[0];
                int voucherId = Convert.ToInt32(selectedRow.Cells["discount_voucher_id"].Value);
                int quantity = Convert.ToInt32(selectedRow.Cells["quantity"].Value);
                try
                {
                    DiscountVoucherDTO entity = new DiscountVoucherDTO
                    {
                        discount_voucher_id = voucherId,
                        voucer_name = txtVoucherName.Text,
                        voucher_code = txtVoucherCode.Text,
                        usage = Convert.ToInt32(txtUsage.Value),
                        quantity = quantity,
                        discount_type = cboVoucherType.SelectedIndex == 0 ? "BY PERCENT" : "NOT BY PERCENT",
                        min_order_value = Convert.ToInt32(txtMinOrderValue.Value),
                        discount_value = Convert.ToInt32(txtDiscountValue.Value),
                        discount_max_value = Convert.ToInt32(txtMaxDiscountValue.Value),
                        discription = txtDescription.Text,
                        Start_at = pickerStartAt.Value,
                        End_at = pickerEndAt.Value,
                    };

                    checkInvalidValue(entity.quantity);
                    if (checkInvalidValue(entity.quantity) == 1)
                    {
                        MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int result = _discountVoucherManager.Update(entity);
                    if (result == 0)
                    {
                        MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    LoadDiscountVoucher();
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = kryptonDataGridView1.SelectedRows[0];
            int voucherId = Convert.ToInt32(selectedRow.Cells["discount_voucher_id"].Value);

            int result = _discountVoucherManager.Delete(voucherId);
            if (result == 0)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadDiscountVoucher();
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private int checkInvalidValue(int quantity)
        {
            if (string.IsNullOrWhiteSpace(txtVoucherCode.Text))
            {
                //MessageBox.Show("Mã voucher không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            if (string.IsNullOrWhiteSpace(txtVoucherName.Text))
            {
                //MessageBox.Show("Tên voucher không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            if (cboVoucherType.SelectedIndex == -1)
            {
                //MessageBox.Show("Loại voucher không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            if (txtUsage.Value <= 0 || txtUsage.Value > quantity)
            {
                //MessageBox.Show("Số lần sử dụng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            if (txtMinOrderValue.Value < 0 || txtMinOrderValue.Value >= txtMaxDiscountValue.Value)
            {
                //MessageBox.Show("Gía trị đơn hàng tối thiểu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return 1;
            }
            if (txtDiscountValue.Value <= 0)
            {
                //MessageBox.Show("Giá trị giảm giá không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            if (txtMaxDiscountValue.Value < txtDiscountValue.Value)
            {
                //MessageBox.Show("Giá trị giảm giá tối đa không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                //MessageBox.Show("Mô tả không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            if (pickerStartAt.Value < DateTime.Now)
            {
                //MessageBox.Show("Ngày bắt đầu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            if (pickerStartAt.Value >= pickerEndAt.Value)
            {
                //MessageBox.Show("Ngày kết thúc không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }

            return 0;
        }

    }
}
