using LibDTO;
using LibBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Nike_Shop_Management.CloudService;
using System.Drawing;

namespace Nike_Shop_Management.GUI
{
    public partial class FlashSaleManagementForm : Form
    {
        private FlashSaleManager flashSaleManager;
        private FlashSaleTimeFrameManager flashSaleTimeFrameManager;

        CloudIService CloudIService;
        public FlashSaleManagementForm()
        {
            InitializeComponent();
            flashSaleManager = new FlashSaleManager();
            flashSaleTimeFrameManager = new FlashSaleTimeFrameManager();
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
        private void LoadFlashSaleTimeFrame(int flash_sale_id)
        {
            try
            {
                List<FlashSaleTimeFrameDTO> flashSaleTimeFrames = flashSaleTimeFrameManager.GetAll(flash_sale_id);

                kryptonDataGridView2.DataSource = flashSaleTimeFrames;

                kryptonDataGridView2.Columns["flash_sale_time_frame_id"].HeaderText = "ID";
                kryptonDataGridView2.Columns["start_at"].HeaderText = "Bắt đầu";
                kryptonDataGridView2.Columns["start_at"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                kryptonDataGridView2.Columns["end_at"].HeaderText = "Kết thúc";
                kryptonDataGridView2.Columns["end_at"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                kryptonDataGridView2.Columns["status"].HeaderText = "Trạng thái";
                kryptonDataGridView2.Columns["flash_sale_id"].Visible = false;
                kryptonDataGridView2.Columns["createAt"].Visible = false;
                kryptonDataGridView2.Columns["updateAt"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        private int checkInvalidValue()
        {
            if (string.IsNullOrWhiteSpace(txtFlashSaleName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên flash sale!");
                return 1;
            }

            if (txtFlashSaleName.Text.Length > 50)
            {
                MessageBox.Show("Tên không quá 50 ký tự");
                return 1;
            }

            if (pickerStartAt.Value <= DateTime.Now)
            {
                MessageBox.Show("Ngày bắt đầu không hợp lệ!");
                return 1;
            }

            if (pickerStartAt.Value >= pickerEndAt.Value)
            {
                MessageBox.Show("Ngày bắt đầu và kết thúc không hợp lệ!");
                return 1;
            }


            return 0;
        }
        private int checkInvalidValueTF(DateTime flashSaleStart, DateTime flashSaleEnd)
        {
            if (pickerStartTF.Value < flashSaleStart || pickerStartTF.Value > flashSaleEnd)
            {
                MessageBox.Show("Ngày bắt đầu của khung thời gian phải nằm trong khoảng thời gian của Flash Sale!");
                return 1;
            }

            if (pickerEndTF.Value < flashSaleStart || pickerEndTF.Value > flashSaleEnd)
            {
                MessageBox.Show("Ngày kết thúc của khung thời gian phải nằm trong khoảng thời gian của Flash Sale!");
                return 1;
            }

            if (pickerStartTF.Value >= pickerEndTF.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!");
                return 1;
            }

            return 0;
        }
        private void clearForm()
        {
            txtFlashSaleName.Text = "";
            pickerStartAt.Value = DateTime.Now;
            pickerEndAt.Value = DateTime.Now;
            u_PictureBox1.LoadImgFromUrl("");
        }
        private void kryptonDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = kryptonDataGridView1.Rows[e.RowIndex];
                int flashSaleId = Convert.ToInt32(selectedRow.Cells["flash_sale_id"].Value);
                txtFlashSaleName.Text = selectedRow.Cells["flash_sale_name"].Value?.ToString();

                string thumbnailUrl = selectedRow.Cells["thumbnail"].Value?.ToString();
                if (!string.IsNullOrEmpty(thumbnailUrl))
                {
                    u_PictureBox1.PathThumbail = thumbnailUrl;
                    u_PictureBox1.LoadImgFromUrl(thumbnailUrl);
                }
                else
                {
                    u_PictureBox1.LoadImgFromUrl("");

                }
                LoadFlashSaleTimeFrame(flashSaleId);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkInvalidValue() != 1)
            {
                try
                {
                    string thumbnailUrl = string.Empty;

                    if (!string.IsNullOrEmpty(u_PictureBox1.PathThumbail))
                    {

                        try
                        {
                            thumbnailUrl = u_PictureBox1.UploadImage(u_PictureBox1.PathThumbail);
                            u_PictureBox1.PathThumbail = thumbnailUrl;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi load ảnh: {ex.Message}");
                            return;
                        }
                    }
                    Console.WriteLine("Bắt đầu thêm Flash Sale...");
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
                    if (result == 1)
                    {
                        MessageBox.Show("Thêm flash sale rồi ha!");
                        clearForm();
                        LoadFlashSale();

                    }
                    else
                    {
                        MessageBox.Show("Lỗi rồi lỗi rồi ha!");
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm Flash Sale: {ex.Message}");
                    return;
                }
            }
            else
            {
                return;
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkInvalidValue() != 1)
            {
                string thumbnailUrl = string.Empty;

                if (!string.IsNullOrEmpty(u_PictureBox1.PathThumbail))
                {

                    try
                    {
                        thumbnailUrl = u_PictureBox1.UploadImage(u_PictureBox1.PathThumbail);
                        u_PictureBox1.PathThumbail = thumbnailUrl;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi load ảnh: {ex.Message}");
                        return;
                    }
                }
                try
                {
                    if (kryptonDataGridView1.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = kryptonDataGridView1.SelectedRows[0];
                        int flashSaleId = Convert.ToInt32(selectedRow.Cells["flash_sale_id"].Value);

                        FlashSaleDTO flashSale = new FlashSaleDTO();

                        flashSale.flash_sale_id = flashSaleId;
                        flashSale.flash_sale_name = txtFlashSaleName.Text;
                        flashSale.thumbnail = thumbnailUrl;
                        flashSale.Start_at = pickerStartAt.Value;
                        flashSale.End_at = pickerEndAt.Value;
                        flashSale.UpdatedAt = DateTime.UtcNow;

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
            else
            {
                return;
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
                        FlashSaleDTO flashSale = new FlashSaleDTO
                        {
                            flash_sale_id = flashSaleId
                        };

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

        private void kryptonDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (kryptonDataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = kryptonDataGridView1.SelectedRows[0];
                string status = selectedRow.Cells["status"].Value?.ToString();

                if (status == "active" || status == "ended")
                {
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;

                    btnAddTF.Enabled = false;
                    btnUpdateTF.Enabled = false;
                    btnDeleteTF.Enabled = false;
                }
                else
                {
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;

                    btnAddTF.Enabled = true;

                }
            }
            else
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                btnAddTF.Enabled = false;
                btnUpdateTF.Enabled = false;
                btnDeleteTF.Enabled = false;

            }
        }

        private void btnAddTF_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridView1.SelectedRows.Count > 0)
            {
                // Lấy thông tin Flash Sale đang được chọn
                DataGridViewRow selectedRow = kryptonDataGridView1.SelectedRows[0];
                int flashSaleId = Convert.ToInt32(selectedRow.Cells["flash_sale_id"].Value);
                DateTime flashSaleStart = DateTime.Parse(selectedRow.Cells["start_at"].Value?.ToString() ?? DateTime.Now.ToString());
                DateTime flashSaleEnd = DateTime.Parse(selectedRow.Cells["end_at"].Value?.ToString() ?? DateTime.Now.ToString());

                // Kiểm tra giá trị Time Frame
                if (checkInvalidValueTF(flashSaleStart, flashSaleEnd) != 1)
                {
                    try
                    {

                        // Tạo đối tượng Time Frame
                        FlashSaleTimeFrameDTO timeFrame = new FlashSaleTimeFrameDTO
                        {
                            flash_sale_id = flashSaleId,
                            Start_at = pickerStartTF.Value,
                            End_at = pickerEndTF.Value,
                            status = "waiting",
                            CreateAt = DateTime.UtcNow,
                            UpdateAt = DateTime.UtcNow
                        };

                        // Gọi phương thức thêm Time Frame từ Manager
                        int result = flashSaleTimeFrameManager.Add(timeFrame);

                        if (result == 1)
                        {
                            MessageBox.Show("Thêm khung thời gian thành công!");
                            LoadFlashSaleTimeFrame(flashSaleId); // Tải lại danh sách Time Frame
                        }
                        else if (result == 2)
                        {
                            MessageBox.Show("Khung thời gian đã tồn tại!");
                        }
                        else
                        {
                            MessageBox.Show("Thêm khung thời gian thất bại!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi thêm khung thời gian: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một Flash Sale trước khi thêm khung thời gian!");
            }
        }

        private void kryptonDataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (kryptonDataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = kryptonDataGridView2.SelectedRows[0];
                pickerStartTF.Value = Convert.ToDateTime(selectedRow.Cells["start_at"].Value);
                pickerEndTF.Value = Convert.ToDateTime(selectedRow.Cells["end_at"].Value);
                string status = selectedRow.Cells["status"].Value?.ToString();

                if (status == "active" || status == "ended")
                {

                    btnAddTF.Enabled = false;
                    btnUpdateTF.Enabled = false;
                    btnDeleteTF.Enabled = false;
                }
                else
                {
                    btnAddTF.Enabled = true;
                    btnUpdateTF.Enabled = true;
                    btnDeleteTF.Enabled = true;
                }

            }
        }

        private void btnUpdateTF_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = kryptonDataGridView2.SelectedRows[0];
                int timeFrameId = Convert.ToInt32(selectedRow.Cells["flash_sale_time_frame_id"].Value);
                int flashSaleId = Convert.ToInt32(selectedRow.Cells["flash_sale_id"].Value);
                DateTime flashSaleStart = pickerStartAt.Value;
                DateTime flashSaleEnd = pickerEndTF.Value;

                if (checkInvalidValueTF(flashSaleStart, flashSaleEnd) != 1)
                {
                    try
                    {
                        FlashSaleTimeFrameDTO timeFrame = new FlashSaleTimeFrameDTO
                        {
                            flash_sale_time_frame_id = timeFrameId,
                            flash_sale_id = flashSaleId,
                            Start_at = pickerStartTF.Value,
                            End_at = pickerEndTF.Value,
                            status = "waiting",
                            UpdateAt = DateTime.UtcNow
                        };

                        int result = flashSaleTimeFrameManager.Update(timeFrame);

                        if (result == 1)
                        {
                            MessageBox.Show("Cập nhật khung thời gian thành công!");
                            LoadFlashSaleTimeFrame(flashSaleId);
                        }
                        else if (result == 2)
                        {
                            MessageBox.Show("Khung thời gian đã tồn tại!");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật khung thời gian thất bại!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi cập nhật khung thời gian: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khung thời gian trước khi cập nhật!");
            }
        }

        private void btnDeleteTF_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = kryptonDataGridView2.SelectedRows[0];
                int timeFrameId = Convert.ToInt32(selectedRow.Cells["flash_sale_time_frame_id"].Value);
                int flashSaleId = Convert.ToInt32(selectedRow.Cells["flash_sale_id"].Value);

                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa khung thời gian này?",
                                                    "Xác nhận xóa",
                                                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    FlashSaleTimeFrameDTO timeFrame = new FlashSaleTimeFrameDTO
                    {
                        flash_sale_time_frame_id = timeFrameId
                    };

                    int result = flashSaleTimeFrameManager.Delete(timeFrame.flash_sale_time_frame_id);

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa khung thời gian thành công!");
                        LoadFlashSaleTimeFrame(flashSaleId);
                    }
                    else
                    {
                        MessageBox.Show("Xóa khung thời gian thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khung thời gian trước khi xóa!");

            }
        }
    }
}
