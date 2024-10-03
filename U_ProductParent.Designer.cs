
namespace Nike_Shop_Management.DAL
{
    partial class U_ProductParent
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_product_name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_price = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.img_product = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_product)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_product_name
            // 
            this.lbl_product_name.Location = new System.Drawing.Point(25, 19);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.Size = new System.Drawing.Size(76, 24);
            this.lbl_product_name.TabIndex = 0;
            this.lbl_product_name.Values.Text = "TÊN GIÀY";
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(12, 190);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(34, 24);
            this.lbl.TabIndex = 3;
            this.lbl.Values.Text = "Giá";
            // 
            // lbl_price
            // 
            this.lbl_price.Location = new System.Drawing.Point(71, 189);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(134, 25);
            this.lbl_price.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Values.Text = "kryptonLabel1";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Nike_Shop_Management.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(192, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(34, 25);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 5;
            this.btnDelete.TabStop = false;
            // 
            // img_product
            // 
            this.img_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.img_product.ErrorImage = global::Nike_Shop_Management.Properties.Resources._default;
            this.img_product.Image = global::Nike_Shop_Management.Properties.Resources._default;
            this.img_product.InitialImage = global::Nike_Shop_Management.Properties.Resources._default;
            this.img_product.Location = new System.Drawing.Point(25, 49);
            this.img_product.Name = "img_product";
            this.img_product.Size = new System.Drawing.Size(168, 127);
            this.img_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_product.TabIndex = 1;
            this.img_product.TabStop = false;
            // 
            // U_ProductParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.img_product);
            this.Controls.Add(this.lbl_product_name);
            this.Name = "U_ProductParent";
            this.Size = new System.Drawing.Size(224, 236);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_product_name;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_price;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox img_product;
    }
}
