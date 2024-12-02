namespace Nike_Shop_Management.GUI
{
    partial class OrderManagementForm
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
            this.cbo_order_status = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.grd_user_order = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel_right = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panel_order_products = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panel_order_product = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Confirm_Order = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_order_status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_user_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_right)).BeginInit();
            this.panel_right.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_order_products)).BeginInit();
            this.panel_order_products.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_order_status
            // 
            this.cbo_order_status.DropDownWidth = 175;
            this.cbo_order_status.Location = new System.Drawing.Point(3, 29);
            this.cbo_order_status.Name = "cbo_order_status";
            this.cbo_order_status.Size = new System.Drawing.Size(127, 21);
            this.cbo_order_status.TabIndex = 1;
            this.cbo_order_status.Text = "kryptonComboBox1";
            // 
            // grd_user_order
            // 
            this.grd_user_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_user_order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_user_order.Location = new System.Drawing.Point(0, 0);
            this.grd_user_order.Name = "grd_user_order";
            this.grd_user_order.Size = new System.Drawing.Size(753, 251);
            this.grd_user_order.TabIndex = 0;
            // 
            // panel_right
            // 
            this.panel_right.Controls.Add(this.flowLayoutPanel1);
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_right.Location = new System.Drawing.Point(753, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(127, 537);
            this.panel_right.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.kryptonLabel1);
            this.flowLayoutPanel1.Controls.Add(this.cbo_order_status);
            this.flowLayoutPanel1.Controls.Add(this.btn_Confirm_Order);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(127, 537);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(122, 20);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Trạng thái đơn hàng";
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.grd_user_order);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(753, 251);
            this.kryptonPanel4.TabIndex = 5;
            // 
            // panel_order_products
            // 
            this.panel_order_products.Controls.Add(this.panel_order_product);
            this.panel_order_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_order_products.Location = new System.Drawing.Point(0, 251);
            this.panel_order_products.Name = "panel_order_products";
            this.panel_order_products.Size = new System.Drawing.Size(753, 286);
            this.panel_order_products.TabIndex = 6;
            // 
            // panel_order_product
            // 
            this.panel_order_product.BackColor = System.Drawing.SystemColors.Control;
            this.panel_order_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_order_product.Location = new System.Drawing.Point(0, 0);
            this.panel_order_product.Name = "panel_order_product";
            this.panel_order_product.Size = new System.Drawing.Size(753, 286);
            this.panel_order_product.TabIndex = 0;
            // 
            // btn_Confirm_Order
            // 
            this.btn_Confirm_Order.Location = new System.Drawing.Point(3, 56);
            this.btn_Confirm_Order.Name = "btn_Confirm_Order";
            this.btn_Confirm_Order.Size = new System.Drawing.Size(121, 25);
            this.btn_Confirm_Order.TabIndex = 3;
            this.btn_Confirm_Order.Values.Text = "Xác nhận đơn hàng";
            // 
            // OrderManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 537);
            this.Controls.Add(this.panel_order_products);
            this.Controls.Add(this.kryptonPanel4);
            this.Controls.Add(this.panel_right);
            this.Name = "OrderManagementForm";
            this.Text = "OrderManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.cbo_order_status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_user_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_right)).EndInit();
            this.panel_right.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_order_products)).EndInit();
            this.panel_order_products.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbo_order_status;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grd_user_order;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel_right;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel_order_products;
        private System.Windows.Forms.FlowLayoutPanel panel_order_product;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Confirm_Order;
    }
}