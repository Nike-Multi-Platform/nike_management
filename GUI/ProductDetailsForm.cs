using LibBLL;
using Nike_Shop_Management.CloudService;
using Nike_Shop_Management.DAL;
using LibDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using LibDAL;
using LibConstants;

namespace Nike_Shop_Management.GUI
{
    public partial class ProductDetailsForm : Form
    {
        CloudIService CloudIService;
        bool flag = false;
        ProductColorsDTO productColorsDTO;
        ProductColorManager pcM = new ProductColorManager();
        public int Product_id { get; set; }
        public int ProductParentID { get; set; }
        List<ProductImgDTO> listImg;
        List<GetTheSizeProductCurrentResult> listSize;
        List<ProductImgDTO> listTemp = new List<ProductImgDTO>();
        List<u_pictureBoxDetail> listU_Img = new List<u_pictureBoxDetail>();
        List<ProductImgDTO> listRemoveImg = new List<ProductImgDTO>();
        public ProductDetailsForm()
        {
            InitializeComponent();
            listView1.Click += ListView1_Click;
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            btnEditSize.Click += BtnEditSize_Click;
            comboSize.SelectedValueChanged += ComboSize_SelectedValueChanged;
        }

        private void BtnEditSize_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                EditProductSizeForm edit = new EditProductSizeForm();
                TypeSize typeSize = pcM.GetTypeSize(ProductParentID);
                edit.InitData(Product_id, typeSize);
                edit.ShowDialog();
            }
            else
            {
                MessageBox.Show("CHua chon sp");
                return;
            }


        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure delete this item?",
                                          "Message",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (listSize != null)
                {
                    foreach (var item in listSize)
                    {
                        pcM.DeleteProductSize(item.product_size_id);
                    }
                    int flag = pcM.Delete(Product_id);
                    if (flag == 1)
                    {
                        MessageBox.Show("Deleted");
                        return;

                    }
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddProductColor ad = new AddProductColor();
            TypeSize typeSize = pcM.GetTypeSize(ProductParentID);
            ad.SetConditionSize(typeSize);
            ad.ProductParentID = ProductParentID;
            this.Hide();
            ad.ShowDialog();
            this.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (productColorsDTO != null)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }
        private void ComboSize_SelectedValueChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                try
                {
                    lbl_quantity.Text = pcM.GetQuantity((int)comboSize.SelectedValue).ToString();

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                u_PictureBox.LoadImgFromUrl(selectedItem.SubItems[1].Text);
                u_PictureBox.PathThumbail = selectedItem.SubItems[1].Text;
                BindingData(int.Parse(listView1.SelectedItems[0].Text), int.Parse(selectedItem.SubItems[2].Text));
            }
        }

        public void BindingData(int product_id, int supplier_id)
        {
            Product_id = product_id;
            listSize = pcM.GetProductSizesByID(product_id);
            List<SupplierDTO> listSupplier = pcM.GetSuppliers(supplier_id);
            if (listSize.Count > 0 && listSupplier.Count > 0)
            {
                comboSize.DataSource = listSize;
                comboSize.DisplayMember = "size_name";
                comboSize.ValueMember = "product_size_id";
                comboSupplier.DataSource = listSupplier;
                comboSupplier.DisplayMember = "supplier_name";
                comboSupplier.ValueMember = "supplier_id";
            }
            productColorsDTO = pcM.GetByID(product_id);
            if (productColorsDTO != null)
            {
                txColorShown.Text = productColorsDTO.product_color_shown;
                tx_price.Text = productColorsDTO.sale_prices;
                txSizeAndFit.Text = productColorsDTO.product_size_and_fit;
                txSolds.Text = productColorsDTO.sold;
                txStylecode.Text = productColorsDTO.product_style_code;
                txTotalStock.Text = productColorsDTO.total_stock;
                tx_description.Text = productColorsDTO.product_description;
                tx_description2.Text = productColorsDTO.product_description2;
                tx_more_info.Text = productColorsDTO.product_more_info;

                listImg = new ProductImgManager().getByID(productColorsDTO.product_id);
                if (listImg.Count > 0)
                {
                    PaintImg();
                }
            }
            flag = true;
        }
        public void PaintImg()
        {
            panel_anh_detail.Controls.Clear();
            int startX = 10;
            int startY = 10;
            foreach (var item in listImg)
            {
                u_pictureBoxDetail u_temp = new u_pictureBoxDetail
                {
                    PathThumbail = item.product_img_file_name
                };
                u_temp.LoadImgFromUrl(item.product_img_file_name);
                u_temp.Location = new Point(startX, startY);
                startY += u_temp.Height + 5;
                u_temp.DeleteClicked += U_temp_DeleteClicked;
                u_temp.EditedClick += U_temp_EditedClick;
                u_temp.Tag = item;
                u_temp.product_img_id = item.product_img_id;
                panel_anh_detail.Controls.Add(u_temp);

            }

        }

        private void U_temp_EditedClick(object sender, EventArgs e)
        {
            try
            {
                var u = sender as u_pictureBoxDetail;
                if (u == null)
                {
                    return;
                }

                var existImg = listImg.Find(t => t.product_img_id == u.product_img_id);
               
                listImg.Remove(existImg);
                listU_Img.Add(u);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }



        private void U_temp_DeleteClicked(object sender, EventArgs e)
        {
            try
            {
                var u = sender as u_pictureBoxDetail;
                if (u == null)
                {
                    MessageBox.Show("Error: Invalid control triggered the delete action.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var imgProduct = u.Tag as ProductImgDTO;
                if (imgProduct == null)
                {
                    MessageBox.Show("Error: Unable to identify the image to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirmResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa hình ảnh này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    listRemoveImg.Add(imgProduct);
                    listImg.Remove(imgProduct);
                    PaintImg();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PaintData(int product_parent_id)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.FullRowSelect = false;
            listView1.MultiSelect = false;
            ProductParentID = product_parent_id;
            ProductParentManager ppM = new ProductParentManager();
            List<ProductColorsDTO> list = ppM.GetProductColors(product_parent_id);
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();
            if (list != null)
            {
                ServiceConfig ServiceConfig = new ServiceConfig();
                int i = 0;
                CloudIService = new CloudIService(ServiceConfig.CloudinaryCloudName, ServiceConfig.CloudinaryApiKey, ServiceConfig.CloudinaryApiSecret);
                foreach (var product in list)
                {

                    PictureBox img_product = new PictureBox();
                    ListViewItem item = new ListViewItem(product.product_id.ToString(), i++);
                    item.SubItems.Add(product.product_img);
                    item.SubItems.Add(product.supplier_id.ToString());
                    img_product.ImageLocation = CloudIService.GetImageUrlByPublicId(product.product_img);
                    try
                    {
                        img_product.Load();
                    }
                    catch (Exception)
                    {
                        img_product.Image = img_product.ErrorImage;
                    }
                    imageListSmall.Images.Add(img_product.Image);
                    imageListLarge.Images.Add(img_product.Image);
                    imageListLarge.ColorDepth = ColorDepth.Depth32Bit;
                    imageListSmall.ColorDepth = ColorDepth.Depth32Bit;
                    listView1.Items.Add(item);
                }
            }
            imageListSmall.ImageSize = new Size(50, 50);
            imageListLarge.ImageSize = new Size(60, 80);

            listView1.LargeImageList = imageListLarge;
            listView1.SmallImageList = imageListSmall;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            u_PictureBox.UploadImage(u_PictureBox.PathThumbail);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(u_PictureBox.PathThumbail);
             string linkHolder = "Nike-application/" + fileNameWithoutExtension;
            productColorsDTO.product_color_shown = txColorShown.Text;
            productColorsDTO.product_description = tx_description.Text;
            productColorsDTO.product_description2 = tx_description2.Text;
            productColorsDTO.product_img = linkHolder;
            productColorsDTO.product_more_info = tx_more_info.Text;
            productColorsDTO.product_size_and_fit = txSizeAndFit.Text;
            productColorsDTO.product_style_code = txStylecode.Text;        
            productColorsDTO.sale_prices = tx_price.Text;
            productColorsDTO.supplier_id = 1;
            updateImg();
            deleteImg();
            int flag = pcM.Update(productColorsDTO);
            if (flag == 1)
            {
                MessageBox.Show("EDIT SUCCESSFULL");
                PaintData(ProductParentID);
            }
            else
            {
                MessageBox.Show("failed");
            }
        }
        public int updateImg()
        {
            ProductImgManager pim = new ProductImgManager();
            if (listU_Img.Count > 0)
            {
                foreach (var item in listU_Img)
                {
                    item.UploadImage(item.PathThumbail);
                    string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(item.PathThumbail);
                    string linkHolder = "Nike-application/" + fileNameWithoutExtension;
                    listTemp.Add(new ProductImgDTO()
                    {
                        product_img_id = item.product_img_id,
                        product_img_file_name = linkHolder
                    }) ;
                }
                if (listTemp.Count > 0)
                {
                    foreach (var item in listTemp)
                    {
                        if (pim.Update(item) == 0)
                        {
                            return -1;
                        }
                    }
                }
            }
            return 0;
        }
        public int deleteImg()
        {
            if(listRemoveImg.Count>0)
            {
                ProductImgManager pim = new ProductImgManager();
                foreach (var item in listRemoveImg)
                {
                    if(pim.Delete(item)==0)
                    {
                        return -1;
                    }
                }
            }
            return 0;
        }
    }
}
