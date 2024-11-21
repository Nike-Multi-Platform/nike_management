
namespace Nike_Shop_Management.GUI
{
    partial class EditProductSizeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLeftToRight = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnRightToLeft = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ListSizeCurrent = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ListSizeInventory = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cancelButton1 = new Nike_Shop_Management.CustomControl.CancelButton();
            ((System.ComponentModel.ISupportInitialize)(this.ListSizeCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListSizeInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kích thước sản phẩm tồn kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(670, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kích thước sản phẩm hiện tại";
            // 
            // btnLeftToRight
            // 
            this.btnLeftToRight.Location = new System.Drawing.Point(505, 106);
            this.btnLeftToRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLeftToRight.Name = "btnLeftToRight";
            this.btnLeftToRight.Size = new System.Drawing.Size(135, 35);
            this.btnLeftToRight.TabIndex = 6;
            this.btnLeftToRight.Values.Text = ">>";
            // 
            // btnRightToLeft
            // 
            this.btnRightToLeft.Location = new System.Drawing.Point(505, 172);
            this.btnRightToLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRightToLeft.Name = "btnRightToLeft";
            this.btnRightToLeft.Size = new System.Drawing.Size(135, 35);
            this.btnRightToLeft.TabIndex = 7;
            this.btnRightToLeft.Values.Text = "<<";
            // 
            // ListSizeCurrent
            // 
            this.ListSizeCurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListSizeCurrent.Location = new System.Drawing.Point(674, 80);
            this.ListSizeCurrent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListSizeCurrent.Name = "ListSizeCurrent";
            this.ListSizeCurrent.RowHeadersWidth = 51;
            this.ListSizeCurrent.Size = new System.Drawing.Size(454, 163);
            this.ListSizeCurrent.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(416, 280);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 37);
            this.btnSave.TabIndex = 11;
            this.btnSave.Values.Text = "Lưu";
            // 
            // ListSizeInventory
            // 
            this.ListSizeInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListSizeInventory.Location = new System.Drawing.Point(39, 80);
            this.ListSizeInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListSizeInventory.Name = "ListSizeInventory";
            this.ListSizeInventory.RowHeadersWidth = 51;
            this.ListSizeInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListSizeInventory.Size = new System.Drawing.Size(418, 163);
            this.ListSizeInventory.TabIndex = 8;
            // 
            // cancelButton1
            // 
            this.cancelButton1.Location = new System.Drawing.Point(593, 280);
            this.cancelButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton1.Name = "cancelButton1";
            this.cancelButton1.Size = new System.Drawing.Size(127, 38);
            this.cancelButton1.TabIndex = 10;
            this.cancelButton1.Values.Text = "Hủy";
            // 
            // EditProductSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 360);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cancelButton1);
            this.Controls.Add(this.ListSizeCurrent);
            this.Controls.Add(this.ListSizeInventory);
            this.Controls.Add(this.btnRightToLeft);
            this.Controls.Add(this.btnLeftToRight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditProductSizeForm";
            this.Text = "EditProductSizeForm";
            this.Load += new System.EventHandler(this.EditProductSizeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListSizeCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListSizeInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLeftToRight;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRightToLeft;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView ListSizeCurrent;
        private CustomControl.CancelButton cancelButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView ListSizeInventory;
    }
}