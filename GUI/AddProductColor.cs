using LibBLL;
using LibDTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibConstants;
using static System.Windows.Forms.CheckedListBox;
using System.Drawing;

namespace Nike_Shop_Management.GUI
{
    public partial class AddProductColor : Form
    {
        Dictionary<string, int> SizeDic;
        public int ProductParentID { get; set; }
        public string LinkHolder { get; set; }
        public AddProductColor()
        {
            InitializeComponent();
            InitData();
            btnAdd.Click += BtnAdd_Click;
            btnAddMoreImg.Click += BtnAddMoreImg_Click;
        }

        private void BtnAddMoreImg_Click(object sender, EventArgs e)
        {
            if (panel_anh_detail.Controls.Count >= 5)
            {
                MessageBox.Show("Bạn chỉ được thêm tối đa 5 hình.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            u_pictureBoxDetail u_temp = new u_pictureBoxDetail
            {
                Name = $"pictureBox_{panel_anh_detail.Controls.Count + 1}",
                Padding = Padding.Empty
            };

            int startX = 10;
            int startY = 10;

            if (panel_anh_detail.Controls.Count > 0)
            {
                Control lastControl = panel_anh_detail.Controls[panel_anh_detail.Controls.Count - 1];

                startY = lastControl.Location.Y + lastControl.Height + 5;
            }

            u_temp.Location = new Point(startX, startY);

            u_temp.DeleteClicked += U_temp_DeleteClicked;
            panel_anh_detail.Controls.Add(u_temp);
        }




        private void U_temp_DeleteClicked(object sender, EventArgs e)
        {
            if (sender is u_pictureBoxDetail u_temp)
            {
                panel_anh_detail.Controls.Remove(u_temp);
                UpdateLocation(); // Cập nhật vị trí sau khi xóa
            }
        }

        public void UpdateLocation()
        {
            int startX = 10;
            int startY = 10;

            for (int i = 0; i < panel_anh_detail.Controls.Count; i++)
            {
                Control control = panel_anh_detail.Controls[i];
                control.Location = new Point(startX, startY + i * (control.Height));
             
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {

            backgroundWorker1.RunWorkerAsync();
        }

        private void AddProductColor_Load(object sender, EventArgs e)
        {

        }
        public void InitData()
        {
            SupplierManager supplierManager = new SupplierManager();
            comboSupplier.DataSource = supplierManager.GetAll();
            comboSupplier.DisplayMember = "supplier_name";
            comboSupplier.ValueMember = "supplier_id";
        }
        public void SetConditionSize(TypeSize type)
        {
            switch (type)
            {
                case TypeSize.Shoes:
                    InitDataComboSizeShoes();
                    break;
                case TypeSize.Clothing:
                    InitDataComboSizeClothing();
                    break;

                default:
                    break;
            }
        }
        void SetSizeDics(List<SizeDTO> sizeDTOs)
        {
            SizeDic = new Dictionary<string, int>();
            foreach (var item in sizeDTOs)
            {
                SizeDic.Add(item.size_name, item.size_id);
            }
        }
        public void InitDataComboSizeClothing()
        {
            SizeManager sizeManager = new SizeManager();
            List<SizeDTO> sizeDTOs = (List<SizeDTO>)sizeManager.GetAll();
            SetSizeDics(sizeDTOs);
            foreach (var item in sizeDTOs)
            {
                if (!item.size_name.Contains("EU"))
                {
                    checked_list_Size.Items.Add(item.size_name);
                }
            }
        }
        public void InitDataComboSizeShoes()
        {
            SizeManager sizeManager = new SizeManager();
            List<SizeDTO> sizeDTOs = (List<SizeDTO>)sizeManager.GetAll();
            SetSizeDics(sizeDTOs);
            foreach (var item in sizeDTOs)
            {
                if (item.size_name.Contains("EU"))
                {
                    checked_list_Size.Items.Add(item.size_name);
                }
            }


        }
        private void kryptonListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            u_PictureBox.UploadImage(u_PictureBox.PathThumbail);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(u_PictureBox.PathThumbail);
            string linkHolder = "Nike-application/" + fileNameWithoutExtension;

            ProductColorManager pcM = new ProductColorManager();
            ProductColorsDTO productColorsDTO = new ProductColorsDTO();
            productColorsDTO.total_stock = "0";
            productColorsDTO.product_color_shown = txColorShown.Text;
            productColorsDTO.product_description = tx_description.Text;
            productColorsDTO.product_description2 = tx_description2.Text;
            productColorsDTO.product_img = linkHolder;
            productColorsDTO.product_more_info = tx_more_info.Text;
            productColorsDTO.product_size_and_fit = txSizeAndFit.Text;
            productColorsDTO.product_style_code = txStylecode.Text;
            productColorsDTO.sale_prices = txSalePrices.Text;
            productColorsDTO.product_parent_id = ProductParentID;
            var supplierSelected = comboSupplier.SelectedValue;
            productColorsDTO.supplier_id = (int)supplierSelected;
            int flag1 = pcM.Add(productColorsDTO);
            productColorsDTO = pcM.GetLast();

            if (flag1 == 1)
            {
                ProductSizeManager pzM = new ProductSizeManager();
                bool flagTotal = false;
                ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox.CheckedItemCollection checkedItems = checked_list_Size.CheckedItems;
                foreach (var item in checkedItems)
                {
                    ProductSizeDTO productSizeDTO = new ProductSizeDTO();
                    productSizeDTO.soluong = 0;
                    productSizeDTO.product_id = productColorsDTO.product_id;
                    productSizeDTO.size_id = SizeDic[item.ToString()];

                    int temp = pzM.Add(productSizeDTO);
                    if (temp == 1)
                    {
                        flagTotal = true;
                    }
                    else
                    {
                        flagTotal = false;
                        break;
                    }
                }
                ProductImgManager pIM = new ProductImgManager();

                foreach (var item in panel_anh_detail.Controls)
                {
                    if(item is u_pictureBoxDetail)
                    {
                        u_pictureBoxDetail temp = (u_pictureBoxDetail)item;
                        ProductImgDTO imgDTO = new ProductImgDTO();
                        temp.UploadImage(temp.PathThumbail);
                        imgDTO.product_id = productColorsDTO.product_id;
                        string fileNameWithoutExtensionT = System.IO.Path.GetFileNameWithoutExtension(u_PictureBox.PathThumbail);
                        string linkHolderT = "Nike-application/" + fileNameWithoutExtensionT;
                        imgDTO.product_img_file_name = linkHolderT;
                        if(pIM.Add(imgDTO)==0)
                        {
                            MessageBox.Show("Thêm thất bại");
                            return;
                        }
                    }
                }

                if (flagTotal)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }
    }
}
