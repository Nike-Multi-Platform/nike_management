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
using LibDTO;
namespace Nike_Shop_Management.DAL
{
    public partial class U_ProductParent : UserControl
    {
        CloudIService CloudIService;

        public ProductParentDTO productParentDTO { get; set; }

        public event EventHandler Clicked;
        public event EventHandler DoubleClicked;
        public event EventHandler DeleteClicked;
        public U_ProductParent()
        {
            InitializeComponent();
            this.Click += U_ProductParent_Click1;
            this.MouseEnter += U_ProductParent_MouseEnter;
            this.MouseLeave += U_ProductParent_MouseLeave;
            img_product.MouseEnter += U_ProductParent_MouseEnter;
            img_product.MouseLeave += U_ProductParent_MouseLeave;
            img_product.Click += U_ProductParent_Click1;
            btnDelete.Click += BtnDelete_Click;
            this.MouseDoubleClick += U_ProductParent_MouseDoubleClick; ;
            img_product.MouseDoubleClick += Img_product_MouseDoubleClick;
        }

        private void U_ProductParent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DoubleClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Img_product_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DoubleClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?",
                                                  "Confirm Delete",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteClicked?.Invoke(this, EventArgs.Empty);
            
            }
            else
            {
            }
        }


        private void U_ProductParent_Click1(object sender, EventArgs e)
        {         
            Clicked?.Invoke(this, EventArgs.Empty);
        }

        private void U_ProductParent_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#fff");
        }

        private void U_ProductParent_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#ddd");
        }

        public void PaintData(ProductParentDTO productParent)
        {
            productParentDTO = productParent;
            lbl_product_name.Text = productParent.product_parent_name;
            lbl_price.Text = productParent.product_price;
            LoadImgFromUrl(productParent.thumbnail);
        }
        public void LoadImgFromUrl(string path)
        {
            ServiceConfig ServiceConfig = new ServiceConfig();
            CloudIService = new CloudIService(ServiceConfig.CloudinaryCloudName, ServiceConfig.CloudinaryApiKey, ServiceConfig.CloudinaryApiSecret);
            img_product.ImageLocation = CloudIService.GetImageUrlByPublicId(path);
            img_product.ErrorImage = (Image)Properties.Resources._default;
        }
    }
}
