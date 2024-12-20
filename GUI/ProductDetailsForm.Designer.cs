﻿
using System.Drawing;
using System.Windows.Forms;

namespace Nike_Shop_Management.GUI
{
    partial class ProductDetailsForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbl_ = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txSolds = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txColorShown = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tx_more_info = new System.Windows.Forms.RichTextBox();
            this.txSizeAndFit = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txStylecode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tx_description = new System.Windows.Forms.RichTextBox();
            this.tx_description2 = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tx_price = new Nike_Shop_Management.CustomControl.PriceTextBox();
            this.cancelButton1 = new Nike_Shop_Management.CustomControl.CancelButton();
            this.u_PictureBox = new Nike_Shop_Management.u_PictureBox();
            this.panel_anh_detail = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnAddMoreImg = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ListSizeCurrent = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ListSizeInventory = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnRightToLeft = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnLeftToRight = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panel_anh_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListSizeCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListSizeInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(315, 664);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1111, 172);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_
            // 
            this.lbl_.Location = new System.Drawing.Point(315, 36);
            this.lbl_.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(129, 24);
            this.lbl_.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lbl_.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.lbl_.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.TabIndex = 3;
            this.lbl_.Values.Text = "Thêm thông tin ";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(871, 184);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(94, 24);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Kích thước ";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(871, 126);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(118, 24);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 5;
            this.kryptonLabel3.Values.Text = "Mã sản phẩm";
            // 
            // txSolds
            // 
            this.txSolds.Location = new System.Drawing.Point(1330, 122);
            this.txSolds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txSolds.Name = "txSolds";
            this.txSolds.Size = new System.Drawing.Size(190, 27);
            this.txSolds.TabIndex = 12;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(1200, 119);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(91, 24);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel5.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 10;
            this.kryptonLabel5.Values.Text = "Tình trạng";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(1200, 71);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(121, 24);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel6.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 9;
            this.kryptonLabel6.Values.Text = "Giá sản phẩm";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(640, 195);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(70, 24);
            this.kryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel7.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 17;
            this.kryptonLabel7.Values.Text = "Mô tả 2";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(315, 195);
            this.kryptonLabel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(70, 24);
            this.kryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel8.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 16;
            this.kryptonLabel8.Values.Text = "Mô tả 1";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(871, 71);
            this.kryptonLabel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(78, 24);
            this.kryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel9.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 15;
            this.kryptonLabel9.Values.Text = "Màu sắc";
            // 
            // txColorShown
            // 
            this.txColorShown.Location = new System.Drawing.Point(983, 71);
            this.txColorShown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txColorShown.Name = "txColorShown";
            this.txColorShown.Size = new System.Drawing.Size(211, 27);
            this.txColorShown.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(329, 849);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 45);
            this.btnAdd.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAdd.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.btnAdd.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnAdd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateCommon.Border.Rounding = 10;
            this.btnAdd.StateCommon.Border.Width = 1;
            this.btnAdd.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdd.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Values.Image = global::Nike_Shop_Management.Properties.Resources.icons8_add_30;
            this.btnAdd.Values.Text = "Thêm";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(519, 849);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(147, 45);
            this.btnEdit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEdit.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnEdit.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnEdit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEdit.StateCommon.Border.Rounding = 10;
            this.btnEdit.StateCommon.Border.Width = 1;
            this.btnEdit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnEdit.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnEdit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Values.Image = global::Nike_Shop_Management.Properties.Resources.icons8_edit_30;
            this.btnEdit.Values.Text = "Sửa";
            // 
            // tx_more_info
            // 
            this.tx_more_info.Location = new System.Drawing.Point(329, 68);
            this.tx_more_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_more_info.Name = "tx_more_info";
            this.tx_more_info.Size = new System.Drawing.Size(521, 102);
            this.tx_more_info.TabIndex = 35;
            this.tx_more_info.Text = "";
            // 
            // txSizeAndFit
            // 
            this.txSizeAndFit.Location = new System.Drawing.Point(983, 184);
            this.txSizeAndFit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txSizeAndFit.Name = "txSizeAndFit";
            this.txSizeAndFit.Size = new System.Drawing.Size(211, 27);
            this.txSizeAndFit.TabIndex = 37;
            // 
            // txStylecode
            // 
            this.txStylecode.Location = new System.Drawing.Point(983, 128);
            this.txStylecode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txStylecode.Name = "txStylecode";
            this.txStylecode.Size = new System.Drawing.Size(211, 27);
            this.txStylecode.TabIndex = 38;
            // 
            // tx_description
            // 
            this.tx_description.Location = new System.Drawing.Point(329, 228);
            this.tx_description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_description.Name = "tx_description";
            this.tx_description.Size = new System.Drawing.Size(211, 179);
            this.tx_description.TabIndex = 39;
            this.tx_description.Text = "";
            // 
            // tx_description2
            // 
            this.tx_description2.Location = new System.Drawing.Point(640, 228);
            this.tx_description2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_description2.Name = "tx_description2";
            this.tx_description2.Size = new System.Drawing.Size(211, 179);
            this.tx_description2.TabIndex = 40;
            this.tx_description2.Text = "";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(694, 850);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 44);
            this.btnDelete.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDelete.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnDelete.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnDelete.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StateCommon.Border.Rounding = 10;
            this.btnDelete.StateCommon.Border.Width = 1;
            this.btnDelete.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDelete.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.TabIndex = 78;
            this.btnDelete.Values.Image = global::Nike_Shop_Management.Properties.Resources.icons8_delete_30;
            this.btnDelete.Values.Text = "Xóa";
            // 
            // tx_price
            // 
            this.tx_price.Location = new System.Drawing.Point(1330, 71);
            this.tx_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_price.Name = "tx_price";
            this.tx_price.Size = new System.Drawing.Size(190, 27);
            this.tx_price.TabIndex = 77;
            // 
            // cancelButton1
            // 
            this.cancelButton1.Location = new System.Drawing.Point(856, 853);
            this.cancelButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton1.Name = "cancelButton1";
            this.cancelButton1.Size = new System.Drawing.Size(157, 41);
            this.cancelButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.cancelButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.cancelButton1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.cancelButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cancelButton1.StateCommon.Border.Rounding = 10;
            this.cancelButton1.StateCommon.Border.Width = 1;
            this.cancelButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.cancelButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.cancelButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton1.TabIndex = 76;
            this.cancelButton1.Values.Image = global::Nike_Shop_Management.Properties.Resources.icons8_cancel_30;
            this.cancelButton1.Values.Text = "Hủy";
            // 
            // u_PictureBox
            // 
            this.u_PictureBox.Location = new System.Drawing.Point(46, 38);
            this.u_PictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.u_PictureBox.Name = "u_PictureBox";
            this.u_PictureBox.PathThumbail = null;
            this.u_PictureBox.Size = new System.Drawing.Size(176, 220);
            this.u_PictureBox.TabIndex = 1;
            // 
            // panel_anh_detail
            // 
            this.panel_anh_detail.AutoScroll = true;
            this.panel_anh_detail.Location = new System.Drawing.Point(12, 291);
            this.panel_anh_detail.Name = "panel_anh_detail";
            this.panel_anh_detail.Size = new System.Drawing.Size(228, 351);
            this.panel_anh_detail.TabIndex = 81;
            // 
            // btnAddMoreImg
            // 
            this.btnAddMoreImg.Location = new System.Drawing.Point(12, 648);
            this.btnAddMoreImg.Name = "btnAddMoreImg";
            this.btnAddMoreImg.Size = new System.Drawing.Size(178, 70);
            this.btnAddMoreImg.TabIndex = 82;
            this.btnAddMoreImg.Values.Image = global::Nike_Shop_Management.Properties.Resources.icons8_add_30;
            this.btnAddMoreImg.Values.Text = "";
            // 
            // ListSizeCurrent
            // 
            this.ListSizeCurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListSizeCurrent.Location = new System.Drawing.Point(953, 460);
            this.ListSizeCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.ListSizeCurrent.Name = "ListSizeCurrent";
            this.ListSizeCurrent.RowHeadersWidth = 51;
            this.ListSizeCurrent.Size = new System.Drawing.Size(454, 163);
            this.ListSizeCurrent.TabIndex = 88;
            // 
            // ListSizeInventory
            // 
            this.ListSizeInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListSizeInventory.Location = new System.Drawing.Point(318, 460);
            this.ListSizeInventory.Margin = new System.Windows.Forms.Padding(4);
            this.ListSizeInventory.Name = "ListSizeInventory";
            this.ListSizeInventory.RowHeadersWidth = 51;
            this.ListSizeInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListSizeInventory.Size = new System.Drawing.Size(418, 163);
            this.ListSizeInventory.TabIndex = 87;
            // 
            // btnRightToLeft
            // 
            this.btnRightToLeft.Location = new System.Drawing.Point(784, 552);
            this.btnRightToLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnRightToLeft.Name = "btnRightToLeft";
            this.btnRightToLeft.Size = new System.Drawing.Size(135, 35);
            this.btnRightToLeft.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnRightToLeft.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnRightToLeft.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightToLeft.TabIndex = 86;
            this.btnRightToLeft.Values.Text = "<<";
            // 
            // btnLeftToRight
            // 
            this.btnLeftToRight.Location = new System.Drawing.Point(784, 486);
            this.btnLeftToRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeftToRight.Name = "btnLeftToRight";
            this.btnLeftToRight.Size = new System.Drawing.Size(135, 35);
            this.btnLeftToRight.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnLeftToRight.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnLeftToRight.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftToRight.TabIndex = 85;
            this.btnLeftToRight.Values.Text = ">>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(949, 421);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 23);
            this.label2.TabIndex = 84;
            this.label2.Text = "Kích thước sản phẩm hiện tại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 421);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 23);
            this.label1.TabIndex = 83;
            this.label1.Text = "Kích thước sản phẩm tồn kho";
            // 
            // ProductDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 905);
            this.Controls.Add(this.ListSizeCurrent);
            this.Controls.Add(this.ListSizeInventory);
            this.Controls.Add(this.btnRightToLeft);
            this.Controls.Add(this.btnLeftToRight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddMoreImg);
            this.Controls.Add(this.panel_anh_detail);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tx_price);
            this.Controls.Add(this.cancelButton1);
            this.Controls.Add(this.tx_description2);
            this.Controls.Add(this.tx_description);
            this.Controls.Add(this.txStylecode);
            this.Controls.Add(this.txSizeAndFit);
            this.Controls.Add(this.tx_more_info);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.txColorShown);
            this.Controls.Add(this.txSolds);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.u_PictureBox);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductDetailsForm";
            this.Text = "CRUD_ProductDetails";
            ((System.ComponentModel.ISupportInitialize)(this.panel_anh_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListSizeCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListSizeInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private u_PictureBox u_PictureBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txSolds;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txColorShown;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEdit;
        private System.Windows.Forms.RichTextBox tx_more_info;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txSizeAndFit;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txStylecode;
        private System.Windows.Forms.RichTextBox tx_description;
        private System.Windows.Forms.RichTextBox tx_description2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CustomControl.CancelButton cancelButton1;
        private CustomControl.PriceTextBox tx_price;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel_anh_detail;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddMoreImg;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView ListSizeCurrent;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView ListSizeInventory;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRightToLeft;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLeftToRight;
        private Label label2;
        private Label label1;
    }
}