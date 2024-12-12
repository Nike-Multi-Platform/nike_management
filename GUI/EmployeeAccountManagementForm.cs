using LibBLL;
using LibDAL;
using LibDTO;
using Nike_Shop_Management.CloudService;
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
    public partial class EmployeeAccountManagementForm : Form
    {
        private UserAccountManager employeeAccountManger;
        CloudIService CloudIService;
        public EmployeeAccountManagementForm()
        {
            employeeAccountManger = new UserAccountManager(new UserAccountRepository(new DbContextDataContext()));
            InitializeComponent();
            LoadData();
            LoadGenderComboBox();
        }

        private void EmployeeAccountManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            var allUsers = employeeAccountManger.GetUserAccounts();

            if (allUsers == null || allUsers.Count == 0)
            {
                MessageBox.Show("Không có user nào được tải về từ cơ sở dữ liệu.");
                return;
            }

            var employee = allUsers.Where(user => user.user_role_id == 2).ToList();
            if (employee.Count == 0)
            {
                MessageBox.Show("Không có nhân viên nào!");
                return;
            }

            dgv_user.DataSource = employee;

            dgv_user.Columns["user_id"].Visible = false;
            dgv_user.Columns["user_password"].Visible = false;
            dgv_user.Columns["user_role_id"].Visible = false;
            dgv_user.Columns["user_url"].Visible = false;
            dgv_user.Columns["user_username"].HeaderText = "Tên tài khoản";
            dgv_user.Columns["user_first_name"].HeaderText = "Họ";
            dgv_user.Columns["user_last_name"].HeaderText = "Tên";
            dgv_user.Columns["user_gender"].HeaderText = "Giới tính";
            dgv_user.Columns["user_phone_number"].HeaderText = "Số điện thoại";
            dgv_user.Columns["user_email"].HeaderText = "Email";
            dgv_user.Columns["user_address"].HeaderText = "Địa chỉ";
        }

        private void dgv_user_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_user.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_user.SelectedRows[0];
                string genderValue = selectedRow.Cells["user_gender"].Value?.ToString();
                if (selectedRow.Cells["user_id"] != null)
                {
                    txt_id.Text = selectedRow.Cells["user_id"].Value?.ToString() ?? string.Empty;
                    txt_username.Text = selectedRow.Cells["user_username"].Value?.ToString() ?? string.Empty;
                    txt_firstname.Text = selectedRow.Cells["user_first_name"].Value?.ToString() ?? string.Empty;
                    txt_lastname.Text = selectedRow.Cells["user_last_name"].Value?.ToString() ?? string.Empty;
                    txt_email.Text = selectedRow.Cells["user_email"].Value?.ToString() ?? string.Empty;
                    txt_phone.Text = selectedRow.Cells["user_phone_number"].Value?.ToString() ?? string.Empty;
                    txt_address.Text = selectedRow.Cells["user_address"].Value?.ToString() ?? string.Empty;
                    cbb_gender.SelectedValue = genderValue;
                    txt_password.Text = selectedRow.Cells["user_password"].Value?.ToString() ?? string.Empty;
                    u_PictureBox1.LoadImgFromUrl(selectedRow.Cells["user_url"].Value?.ToString() ?? string.Empty);
                }
            }
            else
            {
                ClearFields();
            }
        }
        private void LoadGenderComboBox()
        {
            var genderList = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("Male", "Nam"),
                new KeyValuePair<string, string>("Female", "Nữ")
            };

            cbb_gender.DataSource = genderList;
            cbb_gender.DisplayMember = "Value";
            cbb_gender.ValueMember = "Key";
        }

        private void ClearFields()
        {
            txt_id.Clear();
            txt_username.Clear();
            txt_firstname.Clear();
            txt_lastname.Clear();
            txt_email.Clear();
            txt_phone.Clear();
            txt_address.Clear();
            txt_password.Clear();
            u_PictureBox1.LoadImgFromUrl("");
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!ValidateForm(isEdit: true))
            {
                return;
            }

            string userUrl = string.Empty;

            if (!string.IsNullOrEmpty(u_PictureBox1.PathThumbail))
            {
                try
                {
                    userUrl = u_PictureBox1.UploadImage(u_PictureBox1.PathThumbail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi upload ảnh: {ex.Message}");
                    return;
                }
            }

            if (!string.IsNullOrWhiteSpace(txt_id.Text))
            {
                UserAccountDTO user = employeeAccountManger.GetUserByID(txt_id.Text);
                user.user_first_name = txt_firstname.Text;
                user.user_last_name = txt_lastname.Text;
                user.user_address = txt_address.Text;
                user.user_email = txt_email.Text;
                user.user_phone_number = txt_phone.Text;
                user.user_password = txt_password.Text;
                user.user_url = userUrl;

                int result = employeeAccountManger.EditUser(user);
                if (result == 1)
                {
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            string userUrl = string.Empty;

            if (!string.IsNullOrEmpty(u_PictureBox1.PathThumbail))
            {
                try
                {
                    userUrl = u_PictureBox1.UploadImage(u_PictureBox1.PathThumbail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi upload ảnh: {ex.Message}");
                    return;
                }
            }
            var newUser = new UserAccountDTO
            {
                user_id = txt_id.Text,
                user_username = txt_username.Text,
                user_first_name = txt_firstname.Text,
                user_last_name = txt_lastname.Text,
                user_email = txt_email.Text,
                user_phone_number = txt_phone.Text,
                user_address = txt_address.Text,
                user_gender = cbb_gender.SelectedValue?.ToString() ?? "Male",
                user_role_id = 2,
                user_url = userUrl,
                user_password = txt_password.Text
            };

            int result = employeeAccountManger.InsertUser(newUser);

            if (result == 1)
            {
                MessageBox.Show("Thêm nhân viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                txt_id.Focus();
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên mới thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_id.Text))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int deleteResult = employeeAccountManger.DeleleUser(txt_id.Text);

                if (deleteResult == 1)
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateForm(bool isEdit = false)
        {
            if (!isEdit && string.IsNullOrWhiteSpace(txt_id.Text))
            {
                MessageBox.Show("Vui lòng nhập User ID.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_id.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_username.Text) ||
                string.IsNullOrWhiteSpace(txt_firstname.Text) ||
                string.IsNullOrWhiteSpace(txt_lastname.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_phone.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsValidEmail(txt_email.Text))
            {
                MessageBox.Show("Email không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_email.Focus();
                return false;
            }

            if (txt_phone.Text.Length < 10 || txt_phone.Text.Length > 11)
            {
                MessageBox.Show("Số điện thoại phải có độ dài từ 10-11 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_phone.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text != string.Empty)
            {
                var result = employeeAccountManger.SearchUser(txt_search.Text);
                if (result != null)
                {
                    dgv_user.DataSource = result;
                }
                else
                {
                    LoadData();
                }
            }
            else
            {
                LoadData();
            }
        }
    }
}
