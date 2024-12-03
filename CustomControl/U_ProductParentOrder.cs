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
namespace Nike_Shop_Management.CustomControl
{
    public partial class U_ProductParentOrder : UserControl
    {
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_price;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl;
        private PictureBox img_product;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_product_name;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_amount;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel amount;
        CloudIService CloudIService;

        public ProductParentDTO productParentDTO { get; set; }

        public event EventHandler Clicked;
        public event EventHandler DoubleClicked;
        public event EventHandler DeleteClicked;
        public U_ProductParentOrder()
        {
            InitializeComponent();
            this.Click += U_ProductParent_Click1;
            this.MouseEnter += U_ProductParent_MouseEnter;
            this.MouseLeave += U_ProductParent_MouseLeave;
            img_product.MouseEnter += U_ProductParent_MouseEnter;
            img_product.MouseLeave += U_ProductParent_MouseLeave;
            img_product.Click += U_ProductParent_Click1;
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

        public void PaintData(ProductParentDTO productParent, UserOrderProductDTO productsOrder)
        {
            productParentDTO = productParent;
            lbl_product_name.Text = productParent.product_parent_name;
            lbl_price.Text = productParent.product_price;
            amount.Text = productsOrder.amount.ToString();
            LoadImgFromUrl(productParent.thumbnail);
        }
        public void LoadImgFromUrl(string path)
        {
            ServiceConfig ServiceConfig = new ServiceConfig();
            CloudIService = new CloudIService(ServiceConfig.CloudinaryCloudName, ServiceConfig.CloudinaryApiKey, ServiceConfig.CloudinaryApiSecret);
            img_product.ImageLocation = CloudIService.GetImageUrlByPublicId(path);
            img_product.ErrorImage = (Image)Properties.Resources._default;
        }

        private void InitializeComponent()
        {
            this.lbl_price = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.img_product = new System.Windows.Forms.PictureBox();
            this.lbl_product_name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb_amount = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.amount = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.img_product)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_price
            // 
            this.lbl_price.Location = new System.Drawing.Point(75, 170);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(134, 25);
            this.lbl_price.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbl_price.TabIndex = 9;
            this.lbl_price.Values.Text = "kryptonLabel1";
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(5, 170);
            this.lbl.Margin = new System.Windows.Forms.Padding(2);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(34, 24);
            this.lbl.TabIndex = 8;
            this.lbl.Values.Text = "Giá";
            // 
            // img_product
            // 
            this.img_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.img_product.ErrorImage = global::Nike_Shop_Management.Properties.Resources._default;
            this.img_product.Image = global::Nike_Shop_Management.Properties.Resources._default;
            this.img_product.InitialImage = global::Nike_Shop_Management.Properties.Resources._default;
            this.img_product.Location = new System.Drawing.Point(20, 26);
            this.img_product.Margin = new System.Windows.Forms.Padding(2);
            this.img_product.Name = "img_product";
            this.img_product.Size = new System.Drawing.Size(189, 139);
            this.img_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_product.TabIndex = 7;
            this.img_product.TabStop = false;
            // 
            // lbl_product_name
            // 
            this.lbl_product_name.Location = new System.Drawing.Point(5, 2);
            this.lbl_product_name.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.Size = new System.Drawing.Size(76, 24);
            this.lbl_product_name.TabIndex = 6;
            this.lbl_product_name.Values.Text = "TÊN GIÀY";
            // 
            // lb_amount
            // 
            this.lb_amount.Location = new System.Drawing.Point(5, 213);
            this.lb_amount.Margin = new System.Windows.Forms.Padding(2);
            this.lb_amount.Name = "lb_amount";
            this.lb_amount.Size = new System.Drawing.Size(73, 24);
            this.lb_amount.TabIndex = 10;
            this.lb_amount.Values.Text = "Số lượng";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(75, 213);
            this.amount.Margin = new System.Windows.Forms.Padding(2);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(134, 25);
            this.amount.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.amount.TabIndex = 11;
            this.amount.Values.Text = "kryptonLabel1";
            // 
            // U_ProductParentOrder
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.amount);
            this.Controls.Add(this.lb_amount);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.img_product);
            this.Controls.Add(this.lbl_product_name);
            this.Name = "U_ProductParentOrder";
            this.Size = new System.Drawing.Size(238, 252);
            ((System.ComponentModel.ISupportInitialize)(this.img_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
