﻿namespace Nike_Shop_Management.GUI
{
    partial class FlashSaleManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlashSaleManagementForm));
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtFlashSaleName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pickerEndAt = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pickerStartAt = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pickerStartTF = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.pickerEndTF = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnAddTF = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnDeleteTF = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdateTF = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonDataGridView2 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.u_PictureBox1 = new Nike_Shop_Management.u_PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.AllowDrop = true;
            this.btnAdd.Location = new System.Drawing.Point(42, 457);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 56);
            this.btnAdd.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAdd.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.btnAdd.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnAdd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateCommon.Border.Rounding = 10;
            this.btnAdd.StateCommon.Border.Width = 1;
            this.btnAdd.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Values.Image")));
            this.btnAdd.Values.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(27, 9);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(119, 27);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Tên flash sale:";
            // 
            // txtFlashSaleName
            // 
            this.txtFlashSaleName.Location = new System.Drawing.Point(28, 39);
            this.txtFlashSaleName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFlashSaleName.Name = "txtFlashSaleName";
            this.txtFlashSaleName.Size = new System.Drawing.Size(201, 27);
            this.txtFlashSaleName.TabIndex = 5;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.AllowDrop = true;
            this.kryptonLabel4.Location = new System.Drawing.Point(21, 396);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(124, 27);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel4.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 8;
            this.kryptonLabel4.Values.Text = "Ngày kết thúc:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(21, 328);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(121, 27);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel5.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 7;
            this.kryptonLabel5.Values.Text = "Ngày bắt đầu:";
            // 
            // pickerEndAt
            // 
            this.pickerEndAt.CalendarTodayDate = new System.DateTime(2024, 12, 7, 0, 0, 0, 0);
            this.pickerEndAt.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.pickerEndAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerEndAt.Location = new System.Drawing.Point(21, 426);
            this.pickerEndAt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pickerEndAt.Name = "pickerEndAt";
            this.pickerEndAt.ShowUpDown = true;
            this.pickerEndAt.Size = new System.Drawing.Size(247, 25);
            this.pickerEndAt.TabIndex = 10;
            this.pickerEndAt.ValueNullable = new System.DateTime(2024, 12, 5, 0, 53, 34, 581);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(27, 71);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(98, 27);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "Thumbnail:";
            // 
            // pickerStartAt
            // 
            this.pickerStartAt.CalendarTodayDate = new System.DateTime(2024, 12, 7, 0, 0, 0, 0);
            this.pickerStartAt.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.pickerStartAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerStartAt.Location = new System.Drawing.Point(27, 359);
            this.pickerStartAt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pickerStartAt.Name = "pickerStartAt";
            this.pickerStartAt.ShowUpDown = true;
            this.pickerStartAt.Size = new System.Drawing.Size(241, 25);
            this.pickerStartAt.TabIndex = 9;
            this.pickerStartAt.ValueNullable = new System.DateTime(2024, 12, 5, 1, 30, 51, 325);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.u_PictureBox1);
            this.kryptonPanel1.Controls.Add(this.btnDelete);
            this.kryptonPanel1.Controls.Add(this.btnUpdate);
            this.kryptonPanel1.Controls.Add(this.txtFlashSaleName);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.btnAdd);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.pickerEndAt);
            this.kryptonPanel1.Controls.Add(this.pickerStartAt);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel1.Location = new System.Drawing.Point(1070, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonNavigatorStack;
            this.kryptonPanel1.Size = new System.Drawing.Size(329, 621);
            this.kryptonPanel1.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(110, 526);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 56);
            this.btnDelete.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDelete.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnDelete.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnDelete.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StateCommon.Border.Rounding = 10;
            this.btnDelete.StateCommon.Border.Width = 1;
            this.btnDelete.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Values.Image")));
            this.btnDelete.Values.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(159, 457);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 56);
            this.btnUpdate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUpdate.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnUpdate.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnUpdate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StateCommon.Border.Rounding = 10;
            this.btnUpdate.StateCommon.Border.Width = 1;
            this.btnUpdate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Values.Image")));
            this.btnUpdate.Values.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonDataGridView1);
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonForm;
            this.kryptonPanel2.Size = new System.Drawing.Size(991, 283);
            this.kryptonPanel2.TabIndex = 16;
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonDataGridView1.MultiSelect = false;
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.kryptonDataGridView1.RowTemplate.Height = 26;
            this.kryptonDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(991, 283);
            this.kryptonDataGridView1.TabIndex = 0;
            this.kryptonDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridView1_CellClick);
            this.kryptonDataGridView1.SelectionChanged += new System.EventHandler(this.kryptonDataGridView1_SelectionChanged);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(2, 59);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(95, 24);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel3.TabIndex = 0;
            this.kryptonLabel3.Values.Text = "Giờ bắt đầu:";
            // 
            // pickerStartTF
            // 
            this.pickerStartTF.CalendarTodayDate = new System.DateTime(2024, 12, 7, 0, 0, 0, 0);
            this.pickerStartTF.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.pickerStartTF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerStartTF.Location = new System.Drawing.Point(97, 58);
            this.pickerStartTF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pickerStartTF.Name = "pickerStartTF";
            this.pickerStartTF.ShowUpDown = true;
            this.pickerStartTF.Size = new System.Drawing.Size(211, 25);
            this.pickerStartTF.TabIndex = 10;
            // 
            // pickerEndTF
            // 
            this.pickerEndTF.CalendarTodayDate = new System.DateTime(2024, 12, 7, 0, 0, 0, 0);
            this.pickerEndTF.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.pickerEndTF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerEndTF.Location = new System.Drawing.Point(411, 57);
            this.pickerEndTF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pickerEndTF.Name = "pickerEndTF";
            this.pickerEndTF.ShowUpDown = true;
            this.pickerEndTF.Size = new System.Drawing.Size(211, 25);
            this.pickerEndTF.TabIndex = 12;
            this.pickerEndTF.ValueNullable = new System.DateTime(2024, 12, 5, 0, 53, 34, 614);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(314, 60);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(98, 24);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel6.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel6.TabIndex = 11;
            this.kryptonLabel6.Values.Text = "Giờ kết thúc:";
            // 
            // btnAddTF
            // 
            this.btnAddTF.AllowDrop = true;
            this.btnAddTF.Location = new System.Drawing.Point(646, 40);
            this.btnAddTF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTF.Name = "btnAddTF";
            this.btnAddTF.Size = new System.Drawing.Size(104, 52);
            this.btnAddTF.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddTF.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(73)))));
            this.btnAddTF.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnAddTF.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddTF.StateCommon.Border.Rounding = 10;
            this.btnAddTF.StateCommon.Border.Width = 1;
            this.btnAddTF.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddTF.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTF.TabIndex = 13;
            this.btnAddTF.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTF.Values.Image")));
            this.btnAddTF.Values.Text = "Thêm";
            this.btnAddTF.Click += new System.EventHandler(this.btnAddTF_Click);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.btnDeleteTF);
            this.kryptonPanel3.Controls.Add(this.btnUpdateTF);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel3.Controls.Add(this.btnAddTF);
            this.kryptonPanel3.Controls.Add(this.pickerStartTF);
            this.kryptonPanel3.Controls.Add(this.pickerEndTF);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 289);
            this.kryptonPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonForm;
            this.kryptonPanel3.Size = new System.Drawing.Size(991, 96);
            this.kryptonPanel3.TabIndex = 17;
            // 
            // btnDeleteTF
            // 
            this.btnDeleteTF.AllowDrop = true;
            this.btnDeleteTF.Location = new System.Drawing.Point(899, 40);
            this.btnDeleteTF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteTF.Name = "btnDeleteTF";
            this.btnDeleteTF.Size = new System.Drawing.Size(83, 52);
            this.btnDeleteTF.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteTF.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnDeleteTF.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnDeleteTF.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeleteTF.StateCommon.Border.Rounding = 10;
            this.btnDeleteTF.StateCommon.Border.Width = 1;
            this.btnDeleteTF.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDeleteTF.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTF.TabIndex = 16;
            this.btnDeleteTF.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteTF.Values.Image")));
            this.btnDeleteTF.Values.Text = "Xóa";
            this.btnDeleteTF.Click += new System.EventHandler(this.btnDeleteTF_Click);
            // 
            // btnUpdateTF
            // 
            this.btnUpdateTF.AllowDrop = true;
            this.btnUpdateTF.Location = new System.Drawing.Point(756, 40);
            this.btnUpdateTF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateTF.Name = "btnUpdateTF";
            this.btnUpdateTF.Size = new System.Drawing.Size(137, 52);
            this.btnUpdateTF.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUpdateTF.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnUpdateTF.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnUpdateTF.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdateTF.StateCommon.Border.Rounding = 10;
            this.btnUpdateTF.StateCommon.Border.Width = 1;
            this.btnUpdateTF.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUpdateTF.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTF.TabIndex = 15;
            this.btnUpdateTF.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateTF.Values.Image")));
            this.btnUpdateTF.Values.Text = "Cập nhật";
            this.btnUpdateTF.Click += new System.EventHandler(this.btnUpdateTF_Click);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel7.Location = new System.Drawing.Point(264, 17);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(284, 35);
            this.kryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel7.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel7.TabIndex = 14;
            this.kryptonLabel7.Values.Text = "KHUNG GIỜ FLASH SALE";
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.kryptonDataGridView2);
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 388);
            this.kryptonPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonForm;
            this.kryptonPanel4.Size = new System.Drawing.Size(991, 233);
            this.kryptonPanel4.TabIndex = 18;
            // 
            // kryptonDataGridView2
            // 
            this.kryptonDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kryptonDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridView2.Location = new System.Drawing.Point(0, 0);
            this.kryptonDataGridView2.MultiSelect = false;
            this.kryptonDataGridView2.Name = "kryptonDataGridView2";
            this.kryptonDataGridView2.ReadOnly = true;
            this.kryptonDataGridView2.RowHeadersWidth = 51;
            this.kryptonDataGridView2.RowTemplate.Height = 24;
            this.kryptonDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kryptonDataGridView2.Size = new System.Drawing.Size(991, 233);
            this.kryptonDataGridView2.TabIndex = 0;
            this.kryptonDataGridView2.SelectionChanged += new System.EventHandler(this.kryptonDataGridView2_SelectionChanged);
            // 
            // u_PictureBox1
            // 
            this.u_PictureBox1.Location = new System.Drawing.Point(28, 99);
            this.u_PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.u_PictureBox1.Name = "u_PictureBox1";
            this.u_PictureBox1.PathThumbail = null;
            this.u_PictureBox1.Size = new System.Drawing.Size(176, 207);
            this.u_PictureBox1.TabIndex = 15;
            // 
            // FlashSaleManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 621);
            this.Controls.Add(this.kryptonPanel4);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FlashSaleManagementForm";
            this.Text = "Quản lý flash sale";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFlashSaleName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker pickerEndAt;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker pickerStartAt;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddTF;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker pickerEndTF;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker pickerStartTF;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDeleteTF;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdateTF;
        private u_PictureBox u_PictureBox1;
    }
}