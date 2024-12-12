using LibDTO;
using LibBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nike_Shop_Management.CloudService;
using LibDAL;
using ComponentFactory.Krypton.Toolkit;
using System.Net;
using Nike_Shop_Management.Firebase;
using Nike_Shop_Management.Utils;

namespace Nike_Shop_Management.GUI
{
    public partial class CustomerAccountManagementForm : Form
    {
        private UserAccountManager userAccountManger;
        CloudIService CloudIService;
        public CustomerAccountManagementForm()
        {
            userAccountManger = new UserAccountManager(new UserAccountRepository(new DbContextDataContext()));
            InitializeComponent();
            LoadGenderComboBox();
            LoadData();
        }

        private void LoadData()
        {
            var allUsers = userAccountManger.GetUserAccounts();

            if (allUsers == null || allUsers.Count == 0)
            {
                MessageBox.Show("Không có user nào được tải về từ cơ sở dữ liệu.");
                return;
            }

            var customer = allUsers.Where(user => user.user_role_id == 1).ToList();
            if (customer.Count == 0)
            {
                MessageBox.Show("Không có nhân viên nào!");
                return;
            }
            dgv_user.DataSource = customer;

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txt_search.Text != string.Empty)
            {
                var result = userAccountManger.SearchUser(txt_search.Text);
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
                    txt_firstName.Text = selectedRow.Cells["user_first_name"].Value?.ToString() ?? string.Empty;
                    txt_lastName.Text = selectedRow.Cells["user_last_name"].Value?.ToString() ?? string.Empty;
                    txt_email.Text = selectedRow.Cells["user_email"].Value?.ToString() ?? string.Empty;
                    txt_phone.Text = selectedRow.Cells["user_phone_number"].Value?.ToString() ?? string.Empty;
                    txt_address.Text = selectedRow.Cells["user_address"].Value?.ToString() ?? string.Empty;
                    cbb_gender.SelectedValue = genderValue;
                    u_PictureBox1.LoadImgFromUrl(selectedRow.Cells["user_url"].Value?.ToString() ?? string.Empty);
                }
            }
            else
            {
                ClearFields();
            }
        }

        private void ClearFields()
        {
            txt_id.Clear();
            txt_username.Clear();
            txt_firstName.Clear();
            txt_lastName.Clear();
            txt_email.Clear();
            txt_phone.Clear();
            txt_address.Clear();
            u_PictureBox1.LoadImgFromUrl("");
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!ValidateUpdateForm())
            {
                return;
            }
            string userUrl = string.Empty;

            if (!string.IsNullOrEmpty(u_PictureBox1.PathThumbail))
            {

                try
                {
                    userUrl = u_PictureBox1.UploadImage(u_PictureBox1.PathThumbail);
                    u_PictureBox1.PathThumbail = userUrl;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi load ảnh: {ex.Message}");
                    return;
                }
            }
            if (txt_id.Text != string.Empty)
            {

                UserAccountDTO user = userAccountManger.GetUserByID(txt_id.Text.ToString());
                user.user_first_name = txt_firstName.Text;
                user.user_last_name = txt_lastName.Text;
                user.user_address = txt_address.Text;
                user.user_email = txt_email.Text;
                user.user_url = userUrl;

                int result = userAccountManger.EditUser(user);
                if (result == 1)
                {
                    MessageBox.Show("Cập nhật thông tin thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thất bại");
                }
            }
        }

        private async void btn_resetPassword_Click(object sender, EventArgs e)
        {
            var email = txt_email.Text;

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email của người dùng không hợp lệ hoặc không tồn tại.");
                return;
            }

            try
            {
                var resetLink = await FirebaseHelper.GeneratePasswordResetLink(email);

                if (resetLink.StartsWith("Lỗi"))
                {
                    MessageBox.Show(resetLink);
                    return;
                }
                EmailHelper.SendResetPasswordEmail(email, resetLink);
                MessageBox.Show("Email đặt lại mật khẩu đã được gửi thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đặt lại mật khẩu: {ex.Message}");
            }
        }

        private bool ValidateUpdateForm()
        {
            if (string.IsNullOrWhiteSpace(txt_id.Text))
            {
                MessageBox.Show("Vui lòng chọn một người dùng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_id.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_firstName.Text) ||
                string.IsNullOrWhiteSpace(txt_lastName.Text) ||
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
    }
}
