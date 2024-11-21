namespace Nike_Shop_Management.GUI
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_product = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btn_ParentProduct = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_order = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_customer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_RevenueStatistics = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnProductObject = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panelBody = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.headerPanel)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).BeginInit();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
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
            this.sidebar.Controls.Add(this.kryptonPanel1);
            this.sidebar.Controls.Add(this.btn_product);
            this.sidebar.Controls.Add(this.btn_ParentProduct);
            this.sidebar.Controls.Add(this.btn_order);
            this.sidebar.Controls.Add(this.btn_customer);
            this.sidebar.Controls.Add(this.btn_RevenueStatistics);
            this.sidebar.Controls.Add(this.btnProductObject);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 47);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(233, 603);
            this.sidebar.TabIndex = 1;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(200, 58);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPanel1.TabIndex = 6;
            // 
            // btn_product
            // 
            this.btn_product.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btn_product.Location = new System.Drawing.Point(0, 58);
            this.btn_product.Margin = new System.Windows.Forms.Padding(0);
            this.btn_product.Name = "btn_product";
            this.btn_product.Palette = this.kryptonPalette1;
            this.btn_product.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btn_product.Size = new System.Drawing.Size(200, 58);
            this.btn_product.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_product.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_product.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btn_product.StateCommon.Border.Color1 = System.Drawing.Color.Cyan;
            this.btn_product.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_product.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_product.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btn_product.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btn_product.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btn_product.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_product.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_product.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidRightLine;
            this.btn_product.StatePressed.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_product.TabIndex = 5;
            this.btn_product.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_product.Values.Image")));
            this.btn_product.Values.Text = "Quản lý nhân viên";
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
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
            this.btn_ParentProduct.Location = new System.Drawing.Point(0, 116);
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
            this.btn_ParentProduct.Values.Text = "Quản lý sản phẩm";
            this.btn_ParentProduct.Click += new System.EventHandler(this.btn_ParentProduct_Click);
            // 
            // btn_order
            // 
            this.btn_order.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btn_order.Location = new System.Drawing.Point(0, 174);
            this.btn_order.Margin = new System.Windows.Forms.Padding(0);
            this.btn_order.Name = "btn_order";
            this.btn_order.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_order.Size = new System.Drawing.Size(200, 58);
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
            this.btn_order.TabIndex = 8;
            this.btn_order.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_order.Values.Image")));
            this.btn_order.Values.Text = "Quản lý đặt hàng";
            // 
            // btn_customer
            // 
            this.btn_customer.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btn_customer.Location = new System.Drawing.Point(0, 232);
            this.btn_customer.Margin = new System.Windows.Forms.Padding(0);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_customer.Size = new System.Drawing.Size(200, 58);
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
            this.btn_customer.Values.Text = "Quản lý khách hàng";
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_RevenueStatistics
            // 
            this.btn_RevenueStatistics.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btn_RevenueStatistics.Location = new System.Drawing.Point(0, 290);
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
            this.btn_RevenueStatistics.Values.Text = "Thống kê doanh thu";
            // 
            // btnProductObject
            // 
            this.btnProductObject.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.btnProductObject.Location = new System.Drawing.Point(0, 348);
            this.btnProductObject.Margin = new System.Windows.Forms.Padding(0);
            this.btnProductObject.Name = "btnProductObject";
            this.btnProductObject.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnProductObject.Size = new System.Drawing.Size(221, 58);
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
            this.btnProductObject.Values.Text = "Đối tượng sản phẩm";
            this.btnProductObject.Click += new System.EventHandler(this.btnProductObject_Click);
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
            this.panelBody.Size = new System.Drawing.Size(867, 603);
            this.panelBody.TabIndex = 5;
            // 
            // ManagementForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "ManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.headerPanel)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).EndInit();
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
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
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_product;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelBody;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_ParentProduct;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_order;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_customer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_RevenueStatistics;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnProductObject;
    }
}