
namespace Nike_Shop_Management.GUI
{
    partial class AddProductParentForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtProductName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.comboProductCategoriesFileter = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.comboProductObjectFilter = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ComboSubCategoriesFilter = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.u_PictureBox = new Nike_Shop_Management.u_PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cancelButton1 = new Nike_Shop_Management.CustomControl.CancelButton();
            this.txPrice = new Nike_Shop_Management.CustomControl.PriceTextBox();
            this.txWidth = new Nike_Shop_Management.CustomControl.NumberTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txLength = new Nike_Shop_Management.CustomControl.NumberTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txHeight = new Nike_Shop_Management.CustomControl.NumberTextBox();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txWeight = new Nike_Shop_Management.CustomControl.NumberTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.comboProductCategoriesFileter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboProductObjectFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboSubCategoriesFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(315, 238);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(120, 27);
            this.kryptonLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Tên sản phẩm";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(315, 315);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(117, 27);
            this.kryptonLabel2.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Giá sản phẩm";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(315, 267);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(242, 27);
            this.txtProductName.TabIndex = 6;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(315, 90);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(171, 27);
            this.kryptonLabel7.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel7.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel7.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 19;
            this.kryptonLabel7.Values.Text = "Danh mục sản phẩm";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(315, 15);
            this.kryptonLabel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(171, 27);
            this.kryptonLabel8.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel8.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel8.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 18;
            this.kryptonLabel8.Values.Text = "Đối tượng sản phẩm";
            // 
            // comboProductCategoriesFileter
            // 
            this.comboProductCategoriesFileter.DropDownWidth = 184;
            this.comboProductCategoriesFileter.Enabled = false;
            this.comboProductCategoriesFileter.Location = new System.Drawing.Point(315, 121);
            this.comboProductCategoriesFileter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboProductCategoriesFileter.Name = "comboProductCategoriesFileter";
            this.comboProductCategoriesFileter.Size = new System.Drawing.Size(242, 25);
            this.comboProductCategoriesFileter.TabIndex = 17;
            // 
            // comboProductObjectFilter
            // 
            this.comboProductObjectFilter.DropDownWidth = 203;
            this.comboProductObjectFilter.Location = new System.Drawing.Point(315, 46);
            this.comboProductObjectFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboProductObjectFilter.Name = "comboProductObjectFilter";
            this.comboProductObjectFilter.Size = new System.Drawing.Size(242, 25);
            this.comboProductObjectFilter.TabIndex = 16;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(315, 164);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(126, 27);
            this.kryptonLabel6.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel6.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel6.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 21;
            this.kryptonLabel6.Values.Text = "Danh mục phụ";
            // 
            // ComboSubCategoriesFilter
            // 
            this.ComboSubCategoriesFilter.DropDownWidth = 163;
            this.ComboSubCategoriesFilter.Enabled = false;
            this.ComboSubCategoriesFilter.Location = new System.Drawing.Point(315, 195);
            this.ComboSubCategoriesFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboSubCategoriesFilter.Name = "ComboSubCategoriesFilter";
            this.ComboSubCategoriesFilter.Size = new System.Drawing.Size(242, 25);
            this.ComboSubCategoriesFilter.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(695, 411);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 46);
            this.btnAdd.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdd.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnAdd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateCommon.Border.Rounding = 10;
            this.btnAdd.StateCommon.Border.Width = 1;
            this.btnAdd.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdd.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Values.Image = global::Nike_Shop_Management.Properties.Resources.icons8_add_30;
            this.btnAdd.Values.Text = "Thêm vào";
            // 
            // u_PictureBox
            // 
            this.u_PictureBox.Location = new System.Drawing.Point(62, 44);
            this.u_PictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.u_PictureBox.Name = "u_PictureBox";
            this.u_PictureBox.PathThumbail = null;
            this.u_PictureBox.Size = new System.Drawing.Size(183, 221);
            this.u_PictureBox.TabIndex = 0;
            this.u_PictureBox.Load += new System.EventHandler(this.u_PictureBox_Load);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // cancelButton1
            // 
            this.cancelButton1.Location = new System.Drawing.Point(566, 411);
            this.cancelButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton1.Name = "cancelButton1";
            this.cancelButton1.Size = new System.Drawing.Size(123, 46);
            this.cancelButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.cancelButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.cancelButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cancelButton1.StateCommon.Border.Rounding = 10;
            this.cancelButton1.StateCommon.Border.Width = 1;
            this.cancelButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.cancelButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.cancelButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton1.TabIndex = 24;
            this.cancelButton1.Values.Image = global::Nike_Shop_Management.Properties.Resources.icons8_cancel_30;
            this.cancelButton1.Values.Text = "Hủy bỏ";
            // 
            // txPrice
            // 
            this.txPrice.Location = new System.Drawing.Point(315, 345);
            this.txPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(242, 27);
            this.txPrice.TabIndex = 25;
            // 
            // txWidth
            // 
            this.txWidth.Location = new System.Drawing.Point(640, 46);
            this.txWidth.Name = "txWidth";
            this.txWidth.Size = new System.Drawing.Size(173, 27);
            this.txWidth.TabIndex = 26;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(640, 15);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(98, 27);
            this.kryptonLabel3.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 27;
            this.kryptonLabel3.Values.Text = "Chiều rộng";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(640, 90);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(84, 27);
            this.kryptonLabel4.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel4.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel4.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 29;
            this.kryptonLabel4.Values.Text = "Chiều dài";
            // 
            // txLength
            // 
            this.txLength.Location = new System.Drawing.Point(640, 121);
            this.txLength.Name = "txLength";
            this.txLength.Size = new System.Drawing.Size(173, 27);
            this.txLength.TabIndex = 28;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(640, 164);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(88, 27);
            this.kryptonLabel5.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel5.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel5.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 31;
            this.kryptonLabel5.Values.Text = "Chiều cao";
            // 
            // txHeight
            // 
            this.txHeight.Location = new System.Drawing.Point(640, 195);
            this.txHeight.Name = "txHeight";
            this.txHeight.Size = new System.Drawing.Size(173, 27);
            this.txHeight.TabIndex = 30;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(640, 236);
            this.kryptonLabel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(108, 27);
            this.kryptonLabel9.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel9.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel9.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 33;
            this.kryptonLabel9.Values.Text = "Trọng lượng";
            // 
            // txWeight
            // 
            this.txWeight.Location = new System.Drawing.Point(640, 267);
            this.txWeight.Name = "txWeight";
            this.txWeight.Size = new System.Drawing.Size(173, 27);
            this.txWeight.TabIndex = 32;
            // 
            // AddProductParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 479);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.txWeight);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.txHeight);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.txLength);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.txWidth);
            this.Controls.Add(this.txPrice);
            this.Controls.Add(this.cancelButton1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.ComboSubCategoriesFilter);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.comboProductCategoriesFileter);
            this.Controls.Add(this.comboProductObjectFilter);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.u_PictureBox);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddProductParentForm";
            this.Text = "AddProductParentForm";
            ((System.ComponentModel.ISupportInitialize)(this.comboProductCategoriesFileter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboProductObjectFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboSubCategoriesFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private u_PictureBox u_PictureBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProductName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboProductCategoriesFileter;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboProductObjectFilter;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ComboSubCategoriesFilter;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CustomControl.CancelButton cancelButton1;
        private CustomControl.PriceTextBox txPrice;
        private CustomControl.NumberTextBox txWidth;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private CustomControl.NumberTextBox txLength;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private CustomControl.NumberTextBox txHeight;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private CustomControl.NumberTextBox txWeight;
    }
}