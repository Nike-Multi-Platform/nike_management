
using System.Drawing;
using System.Windows.Forms;

namespace Nike_Shop_Management.GUI
{
    partial class ProductDetailsForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbl_ = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txTotalStock = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txSolds = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txColorShown = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tx_more_info = new System.Windows.Forms.RichTextBox();
            this.comboSupplier = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txSizeAndFit = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txStylecode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tx_description = new System.Windows.Forms.RichTextBox();
            this.tx_description2 = new System.Windows.Forms.RichTextBox();
            this.comboSize = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_quantity = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tx_price = new Nike_Shop_Management.CustomControl.PriceTextBox();
            this.cancelButton1 = new Nike_Shop_Management.CustomControl.CancelButton();
            this.u_PictureBox = new Nike_Shop_Management.u_PictureBox();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEditSize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.comboSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboSize)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(75, 457);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(834, 132);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_
            // 
            this.lbl_.Location = new System.Drawing.Point(203, 20);
            this.lbl_.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(64, 20);
            this.lbl_.TabIndex = 3;
            this.lbl_.Values.Text = "more info";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(209, 412);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "size and fit";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(209, 367);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(65, 20);
            this.kryptonLabel3.TabIndex = 5;
            this.kryptonLabel3.Values.Text = "style code";
            // 
            // txTotalStock
            // 
            this.txTotalStock.Location = new System.Drawing.Point(601, 412);
            this.txTotalStock.Margin = new System.Windows.Forms.Padding(2);
            this.txTotalStock.Name = "txTotalStock";
            this.txTotalStock.Size = new System.Drawing.Size(156, 23);
            this.txTotalStock.TabIndex = 13;
            // 
            // txSolds
            // 
            this.txSolds.Location = new System.Drawing.Point(601, 367);
            this.txSolds.Margin = new System.Windows.Forms.Padding(2);
            this.txSolds.Name = "txSolds";
            this.txSolds.Size = new System.Drawing.Size(156, 23);
            this.txSolds.TabIndex = 12;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(515, 412);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(67, 20);
            this.kryptonLabel4.TabIndex = 11;
            this.kryptonLabel4.Values.Text = "total stock";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(517, 366);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(33, 20);
            this.kryptonLabel5.TabIndex = 10;
            this.kryptonLabel5.Values.Text = "sold";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(517, 333);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(67, 20);
            this.kryptonLabel6.TabIndex = 9;
            this.kryptonLabel6.Values.Text = "sale prices";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(447, 142);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(78, 20);
            this.kryptonLabel7.TabIndex = 17;
            this.kryptonLabel7.Values.Text = "description2";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(203, 142);
            this.kryptonLabel8.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(71, 20);
            this.kryptonLabel8.TabIndex = 16;
            this.kryptonLabel8.Values.Text = "description";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(209, 326);
            this.kryptonLabel9.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(77, 20);
            this.kryptonLabel9.TabIndex = 15;
            this.kryptonLabel9.Values.Text = "color shown";
            // 
            // txColorShown
            // 
            this.txColorShown.Location = new System.Drawing.Point(293, 326);
            this.txColorShown.Margin = new System.Windows.Forms.Padding(2);
            this.txColorShown.Name = "txColorShown";
            this.txColorShown.Size = new System.Drawing.Size(158, 23);
            this.txColorShown.TabIndex = 14;
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(667, 45);
            this.kryptonLabel12.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel12.TabIndex = 21;
            this.kryptonLabel12.Values.Text = "supplier";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(184, 618);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 34);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Values.Text = "Add";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(362, 616);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 34);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Values.Text = "Edit";
            // 
            // tx_more_info
            // 
            this.tx_more_info.Location = new System.Drawing.Point(214, 45);
            this.tx_more_info.Margin = new System.Windows.Forms.Padding(2);
            this.tx_more_info.Name = "tx_more_info";
            this.tx_more_info.Size = new System.Drawing.Size(392, 79);
            this.tx_more_info.TabIndex = 35;
            this.tx_more_info.Text = "";
            // 
            // comboSupplier
            // 
            this.comboSupplier.DropDownWidth = 208;
            this.comboSupplier.Location = new System.Drawing.Point(753, 44);
            this.comboSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.comboSupplier.Name = "comboSupplier";
            this.comboSupplier.Size = new System.Drawing.Size(156, 21);
            this.comboSupplier.TabIndex = 36;
            // 
            // txSizeAndFit
            // 
            this.txSizeAndFit.Location = new System.Drawing.Point(293, 412);
            this.txSizeAndFit.Margin = new System.Windows.Forms.Padding(2);
            this.txSizeAndFit.Name = "txSizeAndFit";
            this.txSizeAndFit.Size = new System.Drawing.Size(158, 23);
            this.txSizeAndFit.TabIndex = 37;
            // 
            // txStylecode
            // 
            this.txStylecode.Location = new System.Drawing.Point(293, 367);
            this.txStylecode.Margin = new System.Windows.Forms.Padding(2);
            this.txStylecode.Name = "txStylecode";
            this.txStylecode.Size = new System.Drawing.Size(158, 23);
            this.txStylecode.TabIndex = 38;
            // 
            // tx_description
            // 
            this.tx_description.Location = new System.Drawing.Point(214, 167);
            this.tx_description.Margin = new System.Windows.Forms.Padding(2);
            this.tx_description.Name = "tx_description";
            this.tx_description.Size = new System.Drawing.Size(159, 138);
            this.tx_description.TabIndex = 39;
            this.tx_description.Text = "";
            // 
            // tx_description2
            // 
            this.tx_description2.Location = new System.Drawing.Point(447, 167);
            this.tx_description2.Margin = new System.Windows.Forms.Padding(2);
            this.tx_description2.Name = "tx_description2";
            this.tx_description2.Size = new System.Drawing.Size(159, 138);
            this.tx_description2.TabIndex = 40;
            this.tx_description2.Text = "";
            // 
            // comboSize
            // 
            this.comboSize.DropDownWidth = 211;
            this.comboSize.Location = new System.Drawing.Point(753, 87);
            this.comboSize.Margin = new System.Windows.Forms.Padding(2);
            this.comboSize.Name = "comboSize";
            this.comboSize.Size = new System.Drawing.Size(158, 21);
            this.comboSize.TabIndex = 41;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(667, 87);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(32, 20);
            this.kryptonLabel1.TabIndex = 42;
            this.kryptonLabel1.Values.Text = "Size";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(667, 126);
            this.kryptonLabel10.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(55, 20);
            this.kryptonLabel10.TabIndex = 43;
            this.kryptonLabel10.Values.Text = "quantity";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.Location = new System.Drawing.Point(753, 126);
            this.lbl_quantity.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(6, 2);
            this.lbl_quantity.TabIndex = 44;
            this.lbl_quantity.Values.Text = "";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // tx_price
            // 
            this.tx_price.Location = new System.Drawing.Point(601, 333);
            this.tx_price.Margin = new System.Windows.Forms.Padding(2);
            this.tx_price.Name = "tx_price";
            this.tx_price.Size = new System.Drawing.Size(158, 23);
            this.tx_price.TabIndex = 77;
            // 
            // cancelButton1
            // 
            this.cancelButton1.Location = new System.Drawing.Point(642, 618);
            this.cancelButton1.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton1.Name = "cancelButton1";
            this.cancelButton1.Size = new System.Drawing.Size(103, 32);
            this.cancelButton1.TabIndex = 76;
            this.cancelButton1.Values.Text = "Cancel";
            // 
            // u_PictureBox
            // 
            this.u_PictureBox.Location = new System.Drawing.Point(37, 81);
            this.u_PictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.u_PictureBox.Name = "u_PictureBox";
            this.u_PictureBox.PathThumbail = null;
            this.u_PictureBox.Size = new System.Drawing.Size(132, 168);
            this.u_PictureBox.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(513, 617);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 33);
            this.btnDelete.TabIndex = 78;
            this.btnDelete.Values.Text = "Delete";
            // 
            // btnEditSize
            // 
            this.btnEditSize.BackgroundImage = global::Nike_Shop_Management.Properties.Resources.edit_tool;
            this.btnEditSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditSize.Location = new System.Drawing.Point(916, 87);
            this.btnEditSize.Name = "btnEditSize";
            this.btnEditSize.Size = new System.Drawing.Size(23, 21);
            this.btnEditSize.TabIndex = 79;
            this.btnEditSize.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnEditSize.UseVisualStyleBackColor = true;
            // 
            // ProductDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 762);
            this.Controls.Add(this.btnEditSize);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tx_price);
            this.Controls.Add(this.cancelButton1);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.kryptonLabel10);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.comboSize);
            this.Controls.Add(this.tx_description2);
            this.Controls.Add(this.tx_description);
            this.Controls.Add(this.txStylecode);
            this.Controls.Add(this.txSizeAndFit);
            this.Controls.Add(this.comboSupplier);
            this.Controls.Add(this.tx_more_info);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.kryptonLabel12);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.txColorShown);
            this.Controls.Add(this.txTotalStock);
            this.Controls.Add(this.txSolds);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.u_PictureBox);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductDetailsForm";
            this.Text = "CRUD_ProductDetails";
            ((System.ComponentModel.ISupportInitialize)(this.comboSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private u_PictureBox u_PictureBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txTotalStock;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txSolds;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txColorShown;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEdit;
        private System.Windows.Forms.RichTextBox tx_more_info;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboSupplier;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txSizeAndFit;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txStylecode;
        private System.Windows.Forms.RichTextBox tx_description;
        private System.Windows.Forms.RichTextBox tx_description2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboSize;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_quantity;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CustomControl.CancelButton cancelButton1;
        private CustomControl.PriceTextBox tx_price;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private Button btnEditSize;
    }
}