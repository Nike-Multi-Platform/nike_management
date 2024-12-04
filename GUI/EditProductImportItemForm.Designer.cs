﻿namespace Nike_Shop_Management.GUI.Test
{
    partial class EditProductImportItemForm
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
            this.kryptonNumericUpDown1 = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonNumericUpDown2 = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(7, 39);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(73, 24);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Số lượng";
            // 
            // kryptonNumericUpDown1
            // 
            this.kryptonNumericUpDown1.Location = new System.Drawing.Point(107, 37);
            this.kryptonNumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kryptonNumericUpDown1.Name = "kryptonNumericUpDown1";
            this.kryptonNumericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.kryptonNumericUpDown1.TabIndex = 1;
            this.kryptonNumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kryptonNumericUpDown1.ValueChanged += new System.EventHandler(this.kryptonNumericUpDown1_ValueChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(259, 39);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(72, 24);
            this.kryptonLabel2.TabIndex = 0;
            this.kryptonLabel2.Values.Text = "Giá nhập";
            // 
            // kryptonNumericUpDown2
            // 
            this.kryptonNumericUpDown2.Increment = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.kryptonNumericUpDown2.Location = new System.Drawing.Point(358, 37);
            this.kryptonNumericUpDown2.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.kryptonNumericUpDown2.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.kryptonNumericUpDown2.Name = "kryptonNumericUpDown2";
            this.kryptonNumericUpDown2.Size = new System.Drawing.Size(120, 26);
            this.kryptonNumericUpDown2.TabIndex = 1;
            this.kryptonNumericUpDown2.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.kryptonNumericUpDown2.ValueChanged += new System.EventHandler(this.kryptonNumericUpDown2_ValueChanged);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(246, 89);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(112, 35);
            this.kryptonButton1.TabIndex = 2;
            this.kryptonButton1.Values.Text = "Lưu";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(364, 89);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(112, 35);
            this.kryptonButton2.TabIndex = 2;
            this.kryptonButton2.Values.Text = "Hủy";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // EditProductImportItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 138);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.kryptonNumericUpDown2);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonNumericUpDown1);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "EditProductImportItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập nhật";
            this.Load += new System.EventHandler(this.EditProductImportItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown kryptonNumericUpDown1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown kryptonNumericUpDown2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
    }
}