
namespace Nike_Shop_Management.GUI
{
    partial class AddProductParentForm
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
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtProductName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.comboProductCategoriesFileter = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.comboProductObjectFilter = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ComboSubCategoriesFilter = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.u_PictureBox = new Nike_Shop_Management.u_PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cancelButton1 = new Nike_Shop_Management.CustomControl.CancelButton();
            this.txPrice = new Nike_Shop_Management.CustomControl.PriceTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.comboProductCategoriesFileter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboProductObjectFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboSubCategoriesFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(234, 176);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(89, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Product Name";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(236, 231);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(37, 20);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Price";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(236, 200);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(150, 23);
            this.txtProductName.TabIndex = 6;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(234, 72);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(113, 20);
            this.kryptonLabel7.TabIndex = 19;
            this.kryptonLabel7.Values.Text = "Product categories";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(234, 11);
            this.kryptonLabel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(90, 20);
            this.kryptonLabel8.TabIndex = 18;
            this.kryptonLabel8.Values.Text = "Product object";
            // 
            // comboProductCategoriesFileter
            // 
            this.comboProductCategoriesFileter.DropDownWidth = 184;
            this.comboProductCategoriesFileter.Enabled = false;
            this.comboProductCategoriesFileter.Location = new System.Drawing.Point(234, 97);
            this.comboProductCategoriesFileter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboProductCategoriesFileter.Name = "comboProductCategoriesFileter";
            this.comboProductCategoriesFileter.Size = new System.Drawing.Size(152, 21);
            this.comboProductCategoriesFileter.TabIndex = 17;
            // 
            // comboProductObjectFilter
            // 
            this.comboProductObjectFilter.DropDownWidth = 203;
            this.comboProductObjectFilter.Location = new System.Drawing.Point(234, 35);
            this.comboProductObjectFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboProductObjectFilter.Name = "comboProductObjectFilter";
            this.comboProductObjectFilter.Size = new System.Drawing.Size(152, 21);
            this.comboProductObjectFilter.TabIndex = 16;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(236, 126);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(91, 20);
            this.kryptonLabel6.TabIndex = 21;
            this.kryptonLabel6.Values.Text = "Sub categories";
            // 
            // ComboSubCategoriesFilter
            // 
            this.ComboSubCategoriesFilter.DropDownWidth = 163;
            this.ComboSubCategoriesFilter.Enabled = false;
            this.ComboSubCategoriesFilter.Location = new System.Drawing.Point(236, 150);
            this.ComboSubCategoriesFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboSubCategoriesFilter.Name = "ComboSubCategoriesFilter";
            this.ComboSubCategoriesFilter.Size = new System.Drawing.Size(150, 21);
            this.ComboSubCategoriesFilter.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(325, 310);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 38);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Values.Text = "Add";
            // 
            // u_PictureBox
            // 
            this.u_PictureBox.Location = new System.Drawing.Point(44, 44);
            this.u_PictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.u_PictureBox.Name = "u_PictureBox";
            this.u_PictureBox.PathThumbail = null;
            this.u_PictureBox.Size = new System.Drawing.Size(137, 169);
            this.u_PictureBox.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // cancelButton1
            // 
            this.cancelButton1.Location = new System.Drawing.Point(208, 312);
            this.cancelButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton1.Name = "cancelButton1";
            this.cancelButton1.Size = new System.Drawing.Size(93, 36);
            this.cancelButton1.TabIndex = 24;
            this.cancelButton1.Values.Text = "Cancel";
            // 
            // txPrice
            // 
            this.txPrice.Location = new System.Drawing.Point(234, 255);
            this.txPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(152, 23);
            this.txPrice.TabIndex = 25;
            // 
            // AddProductParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 427);
            this.Controls.Add(this.txPrice);
            this.Controls.Add(this.cancelButton1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.ComboSubCategoriesFilter);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.comboProductCategoriesFileter);
            this.Controls.Add(this.comboProductObjectFilter);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.u_PictureBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddProductParentForm";
            this.Text = "AddProductParentForm";
            ((System.ComponentModel.ISupportInitialize)(this.comboProductCategoriesFileter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboProductObjectFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboSubCategoriesFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private u_PictureBox u_PictureBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProductName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboProductCategoriesFileter;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboProductObjectFilter;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ComboSubCategoriesFilter;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CustomControl.CancelButton cancelButton1;
        private CustomControl.PriceTextBox txPrice;
    }
}