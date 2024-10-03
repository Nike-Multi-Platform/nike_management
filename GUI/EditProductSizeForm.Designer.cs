
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
            this.label1.Location = new System.Drawing.Point(98, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Size Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Product size current";
            // 
            // btnLeftToRight
            // 
            this.btnLeftToRight.Location = new System.Drawing.Point(341, 123);
            this.btnLeftToRight.Name = "btnLeftToRight";
            this.btnLeftToRight.Size = new System.Drawing.Size(90, 25);
            this.btnLeftToRight.TabIndex = 6;
            this.btnLeftToRight.Values.Text = ">>";
            // 
            // btnRightToLeft
            // 
            this.btnRightToLeft.Location = new System.Drawing.Point(341, 171);
            this.btnRightToLeft.Name = "btnRightToLeft";
            this.btnRightToLeft.Size = new System.Drawing.Size(90, 25);
            this.btnRightToLeft.TabIndex = 7;
            this.btnRightToLeft.Values.Text = "<<";
            // 
            // ListSizeCurrent
            // 
            this.ListSizeCurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListSizeCurrent.Location = new System.Drawing.Point(454, 97);
            this.ListSizeCurrent.Name = "ListSizeCurrent";
            this.ListSizeCurrent.Size = new System.Drawing.Size(303, 125);
            this.ListSizeCurrent.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(282, 249);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 11;
            this.btnSave.Values.Text = "Save";
            // 
            // ListSizeInventory
            // 
            this.ListSizeInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListSizeInventory.Location = new System.Drawing.Point(31, 104);
            this.ListSizeInventory.Name = "ListSizeInventory";
            this.ListSizeInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListSizeInventory.Size = new System.Drawing.Size(279, 118);
            this.ListSizeInventory.TabIndex = 8;
            // 
            // cancelButton1
            // 
            this.cancelButton1.Location = new System.Drawing.Point(400, 249);
            this.cancelButton1.Name = "cancelButton1";
            this.cancelButton1.Size = new System.Drawing.Size(85, 28);
            this.cancelButton1.TabIndex = 10;
            this.cancelButton1.Values.Text = "cancelButton1";
            // 
            // EditProductSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 364);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cancelButton1);
            this.Controls.Add(this.ListSizeCurrent);
            this.Controls.Add(this.ListSizeInventory);
            this.Controls.Add(this.btnRightToLeft);
            this.Controls.Add(this.btnLeftToRight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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