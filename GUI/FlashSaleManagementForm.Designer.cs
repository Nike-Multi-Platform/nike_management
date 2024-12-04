namespace Nike_Shop_Management.GUI
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtFlashSaleName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pickerEndAt = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pickerStartAt = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.u_PictureBox1 = new Nike_Shop_Management.u_PictureBox();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.AllowDrop = true;
            this.btnAdd.Location = new System.Drawing.Point(22, 457);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 53);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Values.Text = "Thêm flash sale";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(26, 9);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(106, 24);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Tên flash sale:";
            // 
            // txtFlashSaleName
            // 
            this.txtFlashSaleName.Location = new System.Drawing.Point(26, 39);
            this.txtFlashSaleName.Name = "txtFlashSaleName";
            this.txtFlashSaleName.Size = new System.Drawing.Size(201, 27);
            this.txtFlashSaleName.TabIndex = 5;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.AllowDrop = true;
            this.kryptonLabel4.Location = new System.Drawing.Point(22, 396);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(110, 24);
            this.kryptonLabel4.TabIndex = 8;
            this.kryptonLabel4.Values.Text = "Ngày kết thúc:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(26, 329);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(107, 24);
            this.kryptonLabel5.TabIndex = 7;
            this.kryptonLabel5.Values.Text = "Ngày bắt đầu:";
            // 
            // pickerEndAt
            // 
            this.pickerEndAt.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.pickerEndAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerEndAt.Location = new System.Drawing.Point(22, 426);
            this.pickerEndAt.Name = "pickerEndAt";
            this.pickerEndAt.ShowUpDown = true;
            this.pickerEndAt.Size = new System.Drawing.Size(210, 25);
            this.pickerEndAt.TabIndex = 10;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(26, 71);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(87, 24);
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "Thumbnail:";
            // 
            // pickerStartAt
            // 
            this.pickerStartAt.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.pickerStartAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerStartAt.Location = new System.Drawing.Point(26, 359);
            this.pickerStartAt.Name = "pickerStartAt";
            this.pickerStartAt.ShowUpDown = true;
            this.pickerStartAt.Size = new System.Drawing.Size(210, 25);
            this.pickerStartAt.TabIndex = 9;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnDelete);
            this.kryptonPanel1.Controls.Add(this.btnUpdate);
            this.kryptonPanel1.Controls.Add(this.txtFlashSaleName);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.btnAdd);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.pickerEndAt);
            this.kryptonPanel1.Controls.Add(this.u_PictureBox1);
            this.kryptonPanel1.Controls.Add(this.pickerStartAt);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel1.Location = new System.Drawing.Point(891, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonFormClose;
            this.kryptonPanel1.Size = new System.Drawing.Size(413, 559);
            this.kryptonPanel1.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(284, 457);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 53);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Values.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(156, 457);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 53);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Values.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // u_PictureBox1
            // 
            this.u_PictureBox1.Location = new System.Drawing.Point(26, 100);
            this.u_PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.u_PictureBox1.Name = "u_PictureBox1";
            this.u_PictureBox1.PathThumbail = null;
            this.u_PictureBox1.Size = new System.Drawing.Size(180, 215);
            this.u_PictureBox1.TabIndex = 11;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonDataGridView1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonForm;
            this.kryptonPanel2.Size = new System.Drawing.Size(891, 559);
            this.kryptonPanel2.TabIndex = 16;
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.kryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDataGridView1.MultiSelect = false;
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.kryptonDataGridView1.RowTemplate.Height = 24;
            this.kryptonDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(891, 559);
            this.kryptonDataGridView1.TabIndex = 0;
            this.kryptonDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridView1_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 52);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // FlashSaleManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 559);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "FlashSaleManagementForm";
            this.Text = "Flash Sale Management";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFlashSaleName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker pickerEndAt;
        private u_PictureBox u_PictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker pickerStartAt;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
    }
}