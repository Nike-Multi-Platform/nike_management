using LibDTO;
using LibBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Nike_Shop_Management.CloudService;

namespace Nike_Shop_Management.GUI
{
    public partial class FlashSaleManagementForm : Form
    {
        private FlashSaleManager flashSaleManager;
        CloudIService CloudIService;

        public FlashSaleManagementForm()
        {
            InitializeComponent();
            flashSaleManager = new FlashSaleManager();
            LoadFlashSale();
        }

        private void LoadFlashSale()
        {
            try
            {
                List<FlashSaleDTO> flashSales = flashSaleManager.GetAll();

                kryptonDataGridView1.DataSource = flashSales;

                kryptonDataGridView1.Columns["flash_sale_id"].HeaderText = "ID";
                kryptonDataGridView1.Columns["flash_sale_name"].HeaderText = "Tên flash sale";
                kryptonDataGridView1.Columns["thumbnail"].Visible = false;
                kryptonDataGridView1.Columns["start_at"].HeaderText = "Ngày bắt đầu";
                kryptonDataGridView1.Columns["start_at"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                kryptonDataGridView1.Columns["end_at"].HeaderText = "Ngày kết thúc";
                kryptonDataGridView1.Columns["end_at"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                kryptonDataGridView1.Columns["status"].HeaderText = "Trạng thái";
                kryptonDataGridView1.Columns["CreatedAt"].Visible = false;
                kryptonDataGridView1.Columns["UpdatedAt"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFlashSaleName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên flash sale!");
                return;
            }

            if (txtFlashSaleName.Text.Length > 50)
            {
                MessageBox.Show("Tên không quá 50 ký tự");
                return;
            }

            if (pickerStartAt.Value >= pickerEndAt.Value)
            {
                MessageBox.Show("Ngày bắt đầu và kết thúc không hợp lệ!");
                return;
            }

            string thumbnailUrl = string.Empty;
            if (!string.IsNullOrEmpty(u_PictureBox1.PathThumbail))
            {
                try
                {
                    thumbnailUrl = u_PictureBox1.UploadImage(u_PictureBox1.PathThumbail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗ khi load ảnh: {ex.Message}");
                    return;
                }
            }

            u_PictureBox1.PathThumbail = thumbnailUrl;

            if (backgroundWorker1.IsBusy)
            {
                MessageBox.Show("Please wait until the current operation is complete.");
                return;
            }

            btnAdd.Enabled = false;
            backgroundWorker1.RunWorkerAsync(thumbnailUrl);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string thumbnailUrl = e.Argument as string; 

                FlashSaleDTO flashSale = new FlashSaleDTO
                {
                    flash_sale_name = txtFlashSaleName.Text,
                    thumbnail = thumbnailUrl, 
                    status = "waiting",
                    Start_at = pickerStartAt.Value,
                    End_at = pickerEndAt.Value,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };

                int result = flashSaleManager.Add(flashSale);
                e.Result = result;
            }
            catch (Exception ex)
            {
                e.Result = ex;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnAdd.Enabled = true;

            if (e.Result is Exception ex)
            {
                MessageBox.Show($"Error adding flash sale: {ex.Message}");
                return;
            }

            int flag = (int)e.Result;

            if (flag == 0)
            {
                MessageBox.Show("Failed to add flash sale!");
            }
            else
            {
                MessageBox.Show("Flash sale added successfully!");
                LoadFlashSale();
            }
        }

        private void kryptonDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a valid row, not a header or empty space
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = kryptonDataGridView1.Rows[e.RowIndex];

                txtFlashSaleName.Text = selectedRow.Cells["flash_sale_name"].Value?.ToString();
                pickerStartAt.Value = DateTime.Parse(selectedRow.Cells["start_at"].Value?.ToString() ?? DateTime.Now.ToString());
                pickerEndAt.Value = DateTime.Parse(selectedRow.Cells["end_at"].Value?.ToString() ?? DateTime.Now.ToString());

                string thumbnailUrl = selectedRow.Cells["thumbnail"].Value?.ToString();
                if (!string.IsNullOrEmpty(thumbnailUrl))
                {
                    u_PictureBox1.PathThumbail = thumbnailUrl;
                    u_PictureBox1.LoadImgFromUrl(thumbnailUrl); // Assuming LoadImage is implemented for preview
                }
                else
                {
                    u_PictureBox1.LoadImgFromUrl(""); // Assuming LoadImage is implemented for preview

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFlashSaleName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên flash sale!");
                return;
            }

            if (pickerStartAt.Value >= pickerEndAt.Value)
            {
                MessageBox.Show("Ngày bắt đầu và kết thúc không hợp lệ!");
                return;
            }

            try
            {
                // Get the selected row's ID
                if (kryptonDataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = kryptonDataGridView1.SelectedRows[0];
                    int flashSaleId = Convert.ToInt32(selectedRow.Cells["flash_sale_id"].Value);

                    FlashSaleDTO flashSale = new FlashSaleDTO
                    {
                        flash_sale_id = flashSaleId,
                        flash_sale_name = txtFlashSaleName.Text,
                        thumbnail = u_PictureBox1.PathThumbail,
                        Start_at = pickerStartAt.Value,
                        End_at = pickerEndAt.Value,
                        UpdatedAt = DateTime.UtcNow
                    };

                    int result = flashSaleManager.Update(flashSale);

                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật flash sale thành công!");
                        LoadFlashSale();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật flash sale thất bại!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một flash sale để cập nhật!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (kryptonDataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = kryptonDataGridView1.SelectedRows[0];
                    int flashSaleId = Convert.ToInt32(selectedRow.Cells["flash_sale_id"].Value);

                    var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa flash sale này?",
                                                        "Xác nhận xóa",
                                                        MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        // Create a FlashSaleDTO object with the selected ID
                        FlashSaleDTO flashSale = new FlashSaleDTO
                        {
                            flash_sale_id = flashSaleId
                        };

                        // Call the Delete method
                        int result = flashSaleManager.Delete(flashSale);

                        if (result > 0)
                        {
                            MessageBox.Show("Xóa flash sale thành công!");
                            LoadFlashSale();
                        }
                        else
                        {
                            MessageBox.Show("Xóa flash sale thất bại!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một flash sale để xóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }


    }
}
