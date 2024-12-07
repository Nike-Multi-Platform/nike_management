
namespace Nike_Shop_Management.GUI
{
    partial class AddProductColor
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tx_description2 = new System.Windows.Forms.RichTextBox();
            this.tx_description = new System.Windows.Forms.RichTextBox();
            this.txStylecode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txSizeAndFit = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.comboSupplier = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.tx_more_info = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txColorShown = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_ = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.checked_list_Size = new ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox();
            this.u_PictureBox = new Nike_Shop_Management.u_PictureBox();
            this.cancelButton1 = new Nike_Shop_Management.CustomControl.CancelButton();
            this.txSalePrices = new Nike_Shop_Management.CustomControl.PriceTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.comboSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // tx_description2
            // 
            this.tx_description2.Location = new System.Drawing.Point(515, 219);
            this.tx_description2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_description2.Name = "tx_description2";
            this.tx_description2.Size = new System.Drawing.Size(237, 180);
            this.tx_description2.TabIndex = 69;
            this.tx_description2.Text = "";
            // 
            // tx_description
            // 
            this.tx_description.Location = new System.Drawing.Point(232, 219);
            this.tx_description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_description.Name = "tx_description";
            this.tx_description.Size = new System.Drawing.Size(233, 180);
            this.tx_description.TabIndex = 68;
            this.tx_description.Text = "";
            // 
            // txStylecode
            // 
            this.txStylecode.Location = new System.Drawing.Point(419, 491);
            this.txStylecode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txStylecode.Name = "txStylecode";
            this.txStylecode.Size = new System.Drawing.Size(211, 27);
            this.txStylecode.TabIndex = 67;
            // 
            // txSizeAndFit
            // 
            this.txSizeAndFit.Location = new System.Drawing.Point(419, 546);
            this.txSizeAndFit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txSizeAndFit.Name = "txSizeAndFit";
            this.txSizeAndFit.Size = new System.Drawing.Size(211, 27);
            this.txSizeAndFit.TabIndex = 66;
            // 
            // comboSupplier
            // 
            this.comboSupplier.DropDownWidth = 208;
            this.comboSupplier.Location = new System.Drawing.Point(915, 67);
            this.comboSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboSupplier.Name = "comboSupplier";
            this.comboSupplier.Size = new System.Drawing.Size(213, 25);
            this.comboSupplier.TabIndex = 65;
            // 
            // tx_more_info
            // 
            this.tx_more_info.Location = new System.Drawing.Point(232, 67);
            this.tx_more_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_more_info.Name = "tx_more_info";
            this.tx_more_info.Size = new System.Drawing.Size(521, 101);
            this.tx_more_info.TabIndex = 64;
            this.tx_more_info.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(955, 620);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 44);
            this.btnAdd.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdd.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(126)))), ((int)(((byte)(52)))));
            this.btnAdd.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnAdd.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnAdd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateCommon.Border.Rounding = 10;
            this.btnAdd.StateCommon.Border.Width = 1;
            this.btnAdd.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.TabIndex = 61;
            this.btnAdd.Values.Image = global::Nike_Shop_Management.Properties.Resources.icons8_add_30;
            this.btnAdd.Values.Text = "Thêm";
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(789, 67);
            this.kryptonLabel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(119, 27);
            this.kryptonLabel12.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel12.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel12.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel12.TabIndex = 60;
            this.kryptonLabel12.Values.Text = "Nhà cung cấp";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(541, 187);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(72, 27);
            this.kryptonLabel7.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel7.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel7.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 59;
            this.kryptonLabel7.Values.Text = "Mô tả 2";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(217, 187);
            this.kryptonLabel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(72, 27);
            this.kryptonLabel8.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel8.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel8.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 58;
            this.kryptonLabel8.Values.Text = "Mô tả 1";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(232, 434);
            this.kryptonLabel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(139, 27);
            this.kryptonLabel9.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel9.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel9.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 57;
            this.kryptonLabel9.Values.Text = "Màu sắc hiển thị";
            // 
            // txColorShown
            // 
            this.txColorShown.Location = new System.Drawing.Point(419, 434);
            this.txColorShown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txColorShown.Name = "txColorShown";
            this.txColorShown.Size = new System.Drawing.Size(211, 27);
            this.txColorShown.TabIndex = 56;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(789, 127);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(71, 27);
            this.kryptonLabel6.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel6.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel6.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 51;
            this.kryptonLabel6.Values.Text = "Giá bán";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(232, 491);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(117, 27);
            this.kryptonLabel3.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 49;
            this.kryptonLabel3.Values.Text = "Mã sản phẩm";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(232, 546);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(164, 27);
            this.kryptonLabel2.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 48;
            this.kryptonLabel2.Values.Text = "Kích thước phù hợp";
            // 
            // lbl_
            // 
            this.lbl_.Location = new System.Drawing.Point(217, 27);
            this.lbl_.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(131, 27);
            this.lbl_.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.lbl_.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.lbl_.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.TabIndex = 47;
            this.lbl_.Values.Text = "Thêm thông tin ";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(789, 186);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(68, 27);
            this.kryptonLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 73;
            this.kryptonLabel1.Values.Text = "Kích cỡ";
            // 
            // checked_list_Size
            // 
            this.checked_list_Size.Location = new System.Drawing.Point(797, 219);
            this.checked_list_Size.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checked_list_Size.Name = "checked_list_Size";
            this.checked_list_Size.Size = new System.Drawing.Size(319, 179);
            this.checked_list_Size.TabIndex = 74;
            // 
            // u_PictureBox
            // 
            this.u_PictureBox.Location = new System.Drawing.Point(11, 90);
            this.u_PictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.u_PictureBox.Name = "u_PictureBox";
            this.u_PictureBox.PathThumbail = null;
            this.u_PictureBox.Size = new System.Drawing.Size(176, 220);
            this.u_PictureBox.TabIndex = 46;
            this.u_PictureBox.TabStop = false;
            // 
            // cancelButton1
            // 
            this.cancelButton1.Location = new System.Drawing.Point(767, 621);
            this.cancelButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton1.Name = "cancelButton1";
            this.cancelButton1.Size = new System.Drawing.Size(137, 42);
            this.cancelButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.cancelButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelButton1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.cancelButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cancelButton1.StateCommon.Border.Rounding = 10;
            this.cancelButton1.StateCommon.Border.Width = 1;
            this.cancelButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.cancelButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton1.TabIndex = 75;
            this.cancelButton1.Values.Image = global::Nike_Shop_Management.Properties.Resources.icons8_cancel_30;
            this.cancelButton1.Values.Text = "Hủy";
            // 
            // txSalePrices
            // 
            this.txSalePrices.Location = new System.Drawing.Point(915, 124);
            this.txSalePrices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txSalePrices.Name = "txSalePrices";
            this.txSalePrices.Size = new System.Drawing.Size(213, 27);
            this.txSalePrices.TabIndex = 76;
            // 
            // AddProductColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 697);
            this.Controls.Add(this.txSalePrices);
            this.Controls.Add(this.cancelButton1);
            this.Controls.Add(this.checked_list_Size);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.tx_description2);
            this.Controls.Add(this.tx_description);
            this.Controls.Add(this.txStylecode);
            this.Controls.Add(this.txSizeAndFit);
            this.Controls.Add(this.comboSupplier);
            this.Controls.Add(this.tx_more_info);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.kryptonLabel12);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.txColorShown);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.u_PictureBox);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddProductColor";
            this.Text = "AddProductColor";
            this.Load += new System.EventHandler(this.AddProductColor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox tx_description2;
        private System.Windows.Forms.RichTextBox tx_description;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txStylecode;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txSizeAndFit;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboSupplier;
        private System.Windows.Forms.RichTextBox tx_more_info;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txColorShown;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_;
        private u_PictureBox u_PictureBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox checked_list_Size;
        private CustomControl.CancelButton cancelButton1;
        private CustomControl.PriceTextBox txSalePrices;
    }
}