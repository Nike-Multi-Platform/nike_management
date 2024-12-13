namespace Nike_Shop_Management.GUI
{
    partial class EmployeeAccountManagementForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_user = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_password = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbb_gender = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.u_PictureBox1 = new Nike_Shop_Management.u_PictureBox();
            this.txt_address = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_email = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_phone = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_lastname = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_firstname = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_username = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_id = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_search = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_search = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_add = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_edit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_delete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_gender)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1426, 775);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgv_user, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.88281F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.11719F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1426, 636);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // dgv_user
            // 
            this.dgv_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_user.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_user.Location = new System.Drawing.Point(3, 3);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.ReadOnly = true;
            this.dgv_user.RowHeadersWidth = 51;
            this.dgv_user.RowTemplate.Height = 24;
            this.dgv_user.Size = new System.Drawing.Size(1420, 343);
            this.dgv_user.TabIndex = 0;
            this.dgv_user.SelectionChanged += new System.EventHandler(this.dgv_user_SelectionChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txt_password);
            this.panel8.Controls.Add(this.kryptonLabel11);
            this.panel8.Controls.Add(this.kryptonLabel10);
            this.panel8.Controls.Add(this.cbb_gender);
            this.panel8.Controls.Add(this.u_PictureBox1);
            this.panel8.Controls.Add(this.txt_address);
            this.panel8.Controls.Add(this.kryptonLabel6);
            this.panel8.Controls.Add(this.txt_email);
            this.panel8.Controls.Add(this.kryptonLabel7);
            this.panel8.Controls.Add(this.txt_phone);
            this.panel8.Controls.Add(this.kryptonLabel8);
            this.panel8.Controls.Add(this.kryptonLabel9);
            this.panel8.Controls.Add(this.txt_lastname);
            this.panel8.Controls.Add(this.kryptonLabel5);
            this.panel8.Controls.Add(this.txt_firstname);
            this.panel8.Controls.Add(this.kryptonLabel4);
            this.panel8.Controls.Add(this.txt_username);
            this.panel8.Controls.Add(this.kryptonLabel3);
            this.panel8.Controls.Add(this.txt_id);
            this.panel8.Controls.Add(this.kryptonLabel2);
            this.panel8.Controls.Add(this.kryptonLabel1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 352);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1420, 281);
            this.panel8.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(530, 126);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(163, 27);
            this.txt_password.TabIndex = 21;
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(389, 126);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(80, 24);
            this.kryptonLabel11.TabIndex = 20;
            this.kryptonLabel11.Values.Text = "password:";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(769, 115);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(51, 24);
            this.kryptonLabel10.TabIndex = 19;
            this.kryptonLabel10.Values.Text = "Email:";
            // 
            // cbb_gender
            // 
            this.cbb_gender.DropDownWidth = 213;
            this.cbb_gender.Location = new System.Drawing.Point(884, 31);
            this.cbb_gender.Name = "cbb_gender";
            this.cbb_gender.Size = new System.Drawing.Size(213, 25);
            this.cbb_gender.TabIndex = 18;
            // 
            // u_PictureBox1
            // 
            this.u_PictureBox1.Location = new System.Drawing.Point(142, 44);
            this.u_PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.u_PictureBox1.Name = "u_PictureBox1";
            this.u_PictureBox1.PathThumbail = null;
            this.u_PictureBox1.Size = new System.Drawing.Size(177, 235);
            this.u_PictureBox1.TabIndex = 17;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(884, 162);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(338, 92);
            this.txt_address.TabIndex = 16;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(769, 165);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(61, 24);
            this.kryptonLabel6.TabIndex = 15;
            this.kryptonLabel6.Values.Text = "Địa chỉ:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(884, 115);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(213, 27);
            this.txt_email.TabIndex = 14;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(769, 72);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(105, 24);
            this.kryptonLabel7.TabIndex = 13;
            this.kryptonLabel7.Values.Text = "Số điện thoại:";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(884, 72);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(213, 27);
            this.txt_phone.TabIndex = 12;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(579, 58);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(6, 2);
            this.kryptonLabel8.TabIndex = 11;
            this.kryptonLabel8.Values.Text = "";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(769, 35);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(70, 24);
            this.kryptonLabel9.TabIndex = 9;
            this.kryptonLabel9.Values.Text = "Giới tính";
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(530, 209);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(163, 27);
            this.txt_lastname.TabIndex = 8;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(389, 212);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(36, 24);
            this.kryptonLabel5.TabIndex = 7;
            this.kryptonLabel5.Values.Text = "Tên";
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(530, 162);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(163, 27);
            this.txt_firstname.TabIndex = 6;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(389, 165);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(35, 24);
            this.kryptonLabel4.TabIndex = 5;
            this.kryptonLabel4.Values.Text = "Họ:";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(530, 83);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(163, 27);
            this.txt_username.TabIndex = 4;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(389, 83);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(107, 24);
            this.kryptonLabel3.TabIndex = 3;
            this.kryptonLabel3.Values.Text = "Tên tài khoản:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(530, 40);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(163, 27);
            this.txt_id.TabIndex = 2;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(389, 43);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(107, 24);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Mã nhân viên:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(142, 15);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(42, 24);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Ảnh:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1426, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1420, 44);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(526, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_search);
            this.panel4.Controls.Add(this.txt_search);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(846, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(577, 44);
            this.panel4.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(458, 3);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(116, 36);
            this.btn_search.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.btn_search.StateCommon.Back.Color2 = System.Drawing.Color.Silver;
            this.btn_search.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_search.StateCommon.Border.Rounding = 10;
            this.btn_search.TabIndex = 1;
            this.btn_search.Values.Text = "Tìm";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(3, 6);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(449, 33);
            this.txt_search.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_search.StateCommon.Border.Rounding = 10;
            this.txt_search.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 736);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1426, 39);
            this.panel2.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_add);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1018, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(146, 39);
            this.panel7.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add.Location = new System.Drawing.Point(0, 0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(146, 39);
            this.btn_add.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_add.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_add.TabIndex = 0;
            this.btn_add.Values.Image = global::Nike_Shop_Management.Properties.Resources.icons8_add_30;
            this.btn_add.Values.Text = "Thêm";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_edit);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1164, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(140, 39);
            this.panel6.TabIndex = 1;
            // 
            // btn_edit
            // 
            this.btn_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_edit.Location = new System.Drawing.Point(0, 0);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(140, 39);
            this.btn_edit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_edit.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_edit.TabIndex = 0;
            this.btn_edit.Values.Image = global::Nike_Shop_Management.Properties.Resources.icons8_edit_30;
            this.btn_edit.Values.Text = "Cập nhật";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_delete);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1304, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(122, 39);
            this.panel5.TabIndex = 0;
            // 
            // btn_delete
            // 
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_delete.Location = new System.Drawing.Point(0, 0);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(122, 39);
            this.btn_delete.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btn_delete.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Values.Image = global::Nike_Shop_Management.Properties.Resources.icons8_delete_30;
            this.btn_delete.Values.Text = "Xóa";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // EmployeeAccountManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 775);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeAccountManagementForm";
            this.Text = "EmployeeAccountManagementForm";
            this.Load += new System.EventHandler(this.EmployeeAccountManagementForm_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_gender)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_search;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_search;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_add;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_edit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_delete;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_user;
        private System.Windows.Forms.Panel panel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private u_PictureBox u_PictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_address;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_email;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_phone;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_lastname;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_firstname;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_username;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_id;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbb_gender;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_password;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
    }
}