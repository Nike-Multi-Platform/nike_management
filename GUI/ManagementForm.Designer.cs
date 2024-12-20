﻿namespace Nike_Shop_Management.GUI
{
    partial class ManagementForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementForm));
            this.headerPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FormLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Menu = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_nhanvien = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btn_ParentProduct = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_customer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_RevenueStatistics = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnProductObject = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_order = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_OrdersCancle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_flashsale = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnImportProduct = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnVoucher = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panelBody = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonCommand1 = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            ((System.ComponentModel.ISupportInitialize)(this.headerPanel)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).BeginInit();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.pictureBox2);
            this.headerPanel.Controls.Add(this.FormLabel);
            this.headerPanel.Controls.Add(this.btn_Menu);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.headerPanel.Size = new System.Drawing.Size(1100, 47);
            this.headerPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(281, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // FormLabel
            // 
            this.FormLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.FormLabel.Location = new System.Drawing.Point(75, 12);
            this.FormLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(206, 24);
            this.FormLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormLabel.TabIndex = 1;
            this.FormLabel.Values.Text = "Nike Shop Management";
            // 
            // btn_Menu
            // 
            this.btn_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Menu.Image")));
            this.btn_Menu.Location = new System.Drawing.Point(23, 12);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(26, 28);
            this.btn_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Menu.TabIndex = 1;
            this.btn_Menu.TabStop = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.btn_nhanvien);
            this.sidebar.Controls.Add(this.btn_ParentProduct);
            this.sidebar.Controls.Add(this.btn_customer);
            this.sidebar.Controls.Add(this.btn_RevenueStatistics);
            this.sidebar.Controls.Add(this.btnProductObject);
            this.sidebar.Controls.Add(this.btn_order);
            this.sidebar.Controls.Add(this.btn_OrdersCancle);
            this.sidebar.Controls.Add(this.btn_flashsale);
            this.sidebar.Controls.Add(this.btnImportProduct);
            this.sidebar.Controls.Add(this.kryptonButton1);
            this.sidebar.Controls.Add(this.kryptonButton2);
            this.sidebar.Controls.Add(this.btnVoucher);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sidebar.Location = new System.Drawing.Point(0, 47);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(233, 753);
            this.sidebar.TabIndex = 1;
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btn_nhanvien.Location = new System.Drawing.Point(0, 0);
            this.btn_nhanvien.Margin = new System.Windows.Forms.Padding(0);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.Palette = this.kryptonPalette1;
            this.btn_nhanvien.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btn_nhanvien.Size = new System.Drawing.Size(233, 58);
            this.btn_nhanvien.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_nhanvien.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_nhanvien.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btn_nhanvien.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.btn_nhanvien.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_nhanvien.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_nhanvien.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btn_nhanvien.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btn_nhanvien.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10);
            this.btn_nhanvien.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_nhanvien.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_nhanvien.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhanvien.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.btn_nhanvien.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_nhanvien.TabIndex = 5;
            this.btn_nhanvien.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_nhanvien.Values.Image")));
            this.btn_nhanvien.Values.Text = "     Quản lý nhân viên";
            this.btn_nhanvien.Click += new System.EventHandler(this.Btn_nhanvien);
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 15;
            // 
            // btn_ParentProduct
            // 
            this.btn_ParentProduct.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btn_ParentProduct.Location = new System.Drawing.Point(0, 58);
            this.btn_ParentProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ParentProduct.Name = "btn_ParentProduct";
            this.btn_ParentProduct.Palette = this.kryptonPalette1;
            this.btn_ParentProduct.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btn_ParentProduct.Size = new System.Drawing.Size(232, 58);
            this.btn_ParentProduct.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_ParentProduct.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_ParentProduct.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btn_ParentProduct.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.btn_ParentProduct.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ParentProduct.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ParentProduct.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btn_ParentProduct.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btn_ParentProduct.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btn_ParentProduct.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ParentProduct.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_ParentProduct.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ParentProduct.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.btn_ParentProduct.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_ParentProduct.TabIndex = 7;
            this.btn_ParentProduct.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_ParentProduct.Values.Image")));
            this.btn_ParentProduct.Values.Text = "     Quản lý sản phẩm";
            this.btn_ParentProduct.Click += new System.EventHandler(this.btn_ParentProduct_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btn_customer.Location = new System.Drawing.Point(0, 116);
            this.btn_customer.Margin = new System.Windows.Forms.Padding(0);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_customer.Size = new System.Drawing.Size(233, 58);
            this.btn_customer.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_customer.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_customer.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btn_customer.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.btn_customer.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_customer.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_customer.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btn_customer.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btn_customer.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btn_customer.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_customer.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_customer.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.btn_customer.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_customer.TabIndex = 9;
            this.btn_customer.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_customer.Values.Image")));
            this.btn_customer.Values.Text = "     Quản lý khách hàng";
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_RevenueStatistics
            // 
            this.btn_RevenueStatistics.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btn_RevenueStatistics.Location = new System.Drawing.Point(0, 174);
            this.btn_RevenueStatistics.Margin = new System.Windows.Forms.Padding(0);
            this.btn_RevenueStatistics.Name = "btn_RevenueStatistics";
            this.btn_RevenueStatistics.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_RevenueStatistics.Size = new System.Drawing.Size(233, 58);
            this.btn_RevenueStatistics.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_RevenueStatistics.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_RevenueStatistics.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btn_RevenueStatistics.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.btn_RevenueStatistics.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_RevenueStatistics.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_RevenueStatistics.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btn_RevenueStatistics.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btn_RevenueStatistics.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btn_RevenueStatistics.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_RevenueStatistics.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_RevenueStatistics.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RevenueStatistics.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.btn_RevenueStatistics.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_RevenueStatistics.TabIndex = 10;
            this.btn_RevenueStatistics.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_RevenueStatistics.Values.Image")));
            this.btn_RevenueStatistics.Values.Text = "     Thống kê doanh thu";
            this.btn_RevenueStatistics.Click += new System.EventHandler(this.btn_RevenueStatistics_Click);
            // 
            // btnProductObject
            // 
            this.btnProductObject.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btnProductObject.Location = new System.Drawing.Point(0, 232);
            this.btnProductObject.Margin = new System.Windows.Forms.Padding(0);
            this.btnProductObject.Name = "btnProductObject";
            this.btnProductObject.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnProductObject.Size = new System.Drawing.Size(233, 58);
            this.btnProductObject.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnProductObject.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnProductObject.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnProductObject.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.btnProductObject.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnProductObject.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnProductObject.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnProductObject.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnProductObject.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btnProductObject.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnProductObject.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnProductObject.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductObject.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.btnProductObject.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnProductObject.TabIndex = 11;
            this.btnProductObject.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnProductObject.Values.Image")));
            this.btnProductObject.Values.Text = "     Đối tượng sản phẩm";
            this.btnProductObject.Click += new System.EventHandler(this.btnProductObject_Click);
            // 
            // btn_order
            // 
            this.btn_order.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btn_order.Location = new System.Drawing.Point(0, 290);
            this.btn_order.Margin = new System.Windows.Forms.Padding(0);
            this.btn_order.Name = "btn_order";
            this.btn_order.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_order.Size = new System.Drawing.Size(233, 58);
            this.btn_order.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_order.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_order.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btn_order.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.btn_order.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_order.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_order.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btn_order.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btn_order.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btn_order.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_order.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_order.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.btn_order.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_order.TabIndex = 12;
            this.btn_order.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_order.Values.Image")));
            this.btn_order.Values.Text = "     Đơn hàng";
            // 
            // btn_OrdersCancle
            // 
            this.btn_OrdersCancle.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btn_OrdersCancle.Location = new System.Drawing.Point(0, 348);
            this.btn_OrdersCancle.Margin = new System.Windows.Forms.Padding(0);
            this.btn_OrdersCancle.Name = "btn_OrdersCancle";
            this.btn_OrdersCancle.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_OrdersCancle.Size = new System.Drawing.Size(233, 58);
            this.btn_OrdersCancle.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_OrdersCancle.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_OrdersCancle.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btn_OrdersCancle.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.btn_OrdersCancle.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_OrdersCancle.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_OrdersCancle.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btn_OrdersCancle.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btn_OrdersCancle.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btn_OrdersCancle.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_OrdersCancle.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_OrdersCancle.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OrdersCancle.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.btn_OrdersCancle.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_OrdersCancle.TabIndex = 16;
            this.btn_OrdersCancle.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_OrdersCancle.Values.Image")));
            this.btn_OrdersCancle.Values.Text = "     Hủy / Trả";
            // 
            // btn_flashsale
            // 
            this.btn_flashsale.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btn_flashsale.Location = new System.Drawing.Point(0, 406);
            this.btn_flashsale.Margin = new System.Windows.Forms.Padding(0);
            this.btn_flashsale.Name = "btn_flashsale";
            this.btn_flashsale.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_flashsale.Size = new System.Drawing.Size(233, 58);
            this.btn_flashsale.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_flashsale.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_flashsale.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btn_flashsale.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.btn_flashsale.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_flashsale.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_flashsale.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btn_flashsale.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btn_flashsale.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btn_flashsale.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_flashsale.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_flashsale.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_flashsale.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.btn_flashsale.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_flashsale.TabIndex = 13;
            this.btn_flashsale.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_flashsale.Values.Image")));
            this.btn_flashsale.Values.Text = "     Flash sale";
            this.btn_flashsale.Click += new System.EventHandler(this.btn_flashsale_Click);
            // 
            // btnImportProduct
            // 
            this.btnImportProduct.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btnImportProduct.Location = new System.Drawing.Point(0, 464);
            this.btnImportProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnImportProduct.Name = "btnImportProduct";
            this.btnImportProduct.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnImportProduct.Size = new System.Drawing.Size(233, 58);
            this.btnImportProduct.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnImportProduct.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnImportProduct.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnImportProduct.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.btnImportProduct.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnImportProduct.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnImportProduct.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnImportProduct.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnImportProduct.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btnImportProduct.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnImportProduct.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnImportProduct.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportProduct.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.btnImportProduct.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnImportProduct.TabIndex = 14;
            this.btnImportProduct.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnImportProduct.Values.Image")));
            this.btnImportProduct.Values.Text = "     Nhập hàng";
            this.btnImportProduct.Click += new System.EventHandler(this.btnImportProduct_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton1.Location = new System.Drawing.Point(0, 522);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.kryptonButton1.Size = new System.Drawing.Size(233, 58);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.kryptonButton1.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.kryptonButton1.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonButton1.TabIndex = 15;
            this.kryptonButton1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton1.Values.Image")));
            this.kryptonButton1.Values.Text = "     Xem các đơn nhập";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.kryptonButton2.Location = new System.Drawing.Point(0, 580);
            this.kryptonButton2.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.kryptonButton2.Size = new System.Drawing.Size(233, 58);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.kryptonButton2.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.kryptonButton2.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.kryptonButton2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.kryptonButton2.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonButton2.TabIndex = 16;
            this.kryptonButton2.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton2.Values.Image")));
            this.kryptonButton2.Values.Text = "     Size áo, quần,...";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // btnVoucher
            // 
            this.btnVoucher.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btnVoucher.Location = new System.Drawing.Point(0, 638);
            this.btnVoucher.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoucher.Name = "btnVoucher";
            this.btnVoucher.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnVoucher.Size = new System.Drawing.Size(233, 58);
            this.btnVoucher.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnVoucher.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnVoucher.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnVoucher.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.btnVoucher.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVoucher.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnVoucher.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnVoucher.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnVoucher.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btnVoucher.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnVoucher.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnVoucher.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoucher.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.btnVoucher.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnVoucher.TabIndex = 17;
            this.btnVoucher.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnVoucher.Values.Image")));
            this.btnVoucher.Values.Text = "     Voucher";
            this.btnVoucher.Click += new System.EventHandler(this.btnVoucher_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(233, 47);
            this.panelBody.Margin = new System.Windows.Forms.Padding(0);
            this.panelBody.Name = "panelBody";
            this.panelBody.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.panelBody.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.InputControlRibbon;
            this.panelBody.Size = new System.Drawing.Size(867, 753);
            this.panelBody.TabIndex = 5;
            // 
            // kryptonCommand1
            // 
            this.kryptonCommand1.Text = "kryptonCommand1";
            // 
            // ManagementForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1100, 800);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "ManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagementForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagementForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.headerPanel)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).EndInit();
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel headerPanel;
        private System.Windows.Forms.PictureBox btn_Menu;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel FormLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_nhanvien;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelBody;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_ParentProduct;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_customer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_RevenueStatistics;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnProductObject;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_order;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_flashsale;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnImportProduct;
        private ComponentFactory.Krypton.Toolkit.KryptonCommand kryptonCommand1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OrdersCancle;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnVoucher;
    }
}