using System.Windows.Forms;

namespace Nike_Shop_Management.GUI
{
    public partial class Util : Form
    {
        public Util()
        {
            InitializeComponent();
        }


        private Form currentFormChild;

        public void OpenChildForm(Form childForm, Panel panelBody)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            currentFormChild.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }
    }
}
