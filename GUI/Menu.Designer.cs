
namespace Nike_Shop_Management.GUI
{
    partial class Menu
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
            this.panelLogo = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panelMenu = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnCloseChildForm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelNavBar = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panelDesktop = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.panelLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNavBar)).BeginInit();
            this.panelNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDesktop)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.Location = new System.Drawing.Point(30, 12);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.panelLogo.Size = new System.Drawing.Size(246, 117);
            this.panelLogo.TabIndex = 3;
            // 
            // panelMenu
            // 
            this.panelMenu.Location = new System.Drawing.Point(30, 146);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.panelMenu.Size = new System.Drawing.Size(246, 494);
            this.panelMenu.TabIndex = 2;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Location = new System.Drawing.Point(830, 3);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(26, 25);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.Values.Text = "X";
            // 
            // panelNavBar
            // 
            this.panelNavBar.Controls.Add(this.btnCloseChildForm);
            this.panelNavBar.Location = new System.Drawing.Point(311, 12);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.panelNavBar.Size = new System.Drawing.Size(859, 57);
            this.panelNavBar.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Location = new System.Drawing.Point(311, 88);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.panelDesktop.Size = new System.Drawing.Size(859, 552);
            this.panelDesktop.TabIndex = 4;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 663);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelNavBar);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.panelLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNavBar)).EndInit();
            this.panelNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelDesktop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelLogo;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelMenu;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCloseChildForm;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelNavBar;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelDesktop;
    }
}