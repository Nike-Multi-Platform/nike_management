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
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtFlashSaleName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pickerStartAt = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.pickerEndAt = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.u_PictureBox1 = new Nike_Shop_Management.u_PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(12, 104);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.RowHeadersWidth = 51;
            this.kryptonDataGridView1.RowTemplate.Height = 24;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(1019, 552);
            this.kryptonDataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1059, 586);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 70);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Values.Text = "Thêm flash sale";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(1051, 96);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(106, 24);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Tên flash sale:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(462, 24);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(215, 35);
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "Quản Lý Flash Sale";
            // 
            // txtFlashSaleName
            // 
            this.txtFlashSaleName.Location = new System.Drawing.Point(1050, 126);
            this.txtFlashSaleName.Name = "txtFlashSaleName";
            this.txtFlashSaleName.Size = new System.Drawing.Size(201, 27);
            this.txtFlashSaleName.TabIndex = 5;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(1050, 478);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(110, 24);
            this.kryptonLabel4.TabIndex = 8;
            this.kryptonLabel4.Values.Text = "Ngày kết thúc:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(1050, 408);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(107, 24);
            this.kryptonLabel5.TabIndex = 7;
            this.kryptonLabel5.Values.Text = "Ngày bắt đầu:";
            // 
            // pickerStartAt
            // 
            this.pickerStartAt.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.pickerStartAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerStartAt.Location = new System.Drawing.Point(1050, 447);
            this.pickerStartAt.Name = "pickerStartAt";
            this.pickerStartAt.ShowUpDown = true;
            this.pickerStartAt.Size = new System.Drawing.Size(210, 25);
            this.pickerStartAt.TabIndex = 9;
            this.pickerStartAt.ValueNullable = new System.DateTime(2024, 12, 2, 19, 49, 21, 0);
            // 
            // pickerEndAt
            // 
            this.pickerEndAt.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.pickerEndAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerEndAt.Location = new System.Drawing.Point(1050, 508);
            this.pickerEndAt.Name = "pickerEndAt";
            this.pickerEndAt.ShowUpDown = true;
            this.pickerEndAt.Size = new System.Drawing.Size(210, 25);
            this.pickerEndAt.TabIndex = 10;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(1050, 159);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(91, 24);
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "Thumbnaiil:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // u_PictureBox1
            // 
            this.u_PictureBox1.Location = new System.Drawing.Point(1050, 188);
            this.u_PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.u_PictureBox1.Name = "u_PictureBox1";
            this.u_PictureBox1.PathThumbail = null;
            this.u_PictureBox1.Size = new System.Drawing.Size(180, 215);
            this.u_PictureBox1.TabIndex = 11;
            // 
            // FlashSaleManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 689);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.u_PictureBox1);
            this.Controls.Add(this.pickerEndAt);
            this.Controls.Add(this.pickerStartAt);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.txtFlashSaleName);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Name = "FlashSaleManagementForm";
            this.Text = "FlashSaleManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFlashSaleName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker pickerStartAt;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker pickerEndAt;
        private u_PictureBox u_PictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}