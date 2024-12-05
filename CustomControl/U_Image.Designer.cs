namespace Nike_Shop_Management.CustomControl
{
    partial class U_Image
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
            this.img_product = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_product)).BeginInit();
            this.SuspendLayout();
            // 
            // img_product
            // 
            this.img_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.img_product.ErrorImage = global::Nike_Shop_Management.Properties.Resources._default;
            this.img_product.Image = global::Nike_Shop_Management.Properties.Resources._default;
            this.img_product.InitialImage = global::Nike_Shop_Management.Properties.Resources._default;
            this.img_product.Location = new System.Drawing.Point(18, 12);
            this.img_product.Margin = new System.Windows.Forms.Padding(2);
            this.img_product.Name = "img_product";
            this.img_product.Size = new System.Drawing.Size(189, 139);
            this.img_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_product.TabIndex = 8;
            this.img_product.TabStop = false;
            // 
            // U_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.img_product);
            this.Name = "U_Image";
            this.Size = new System.Drawing.Size(228, 167);
            ((System.ComponentModel.ISupportInitialize)(this.img_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_product;
    }
}
