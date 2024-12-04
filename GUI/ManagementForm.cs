using LibBLL;
using LibDTO;
using System;
using System.Windows.Forms;

namespace Nike_Shop_Management.GUI
{
    public partial class ManagementForm : Form
    {
        Util util = new Util();
        public ManagementForm()
        {
            InitializeComponent();
            btn_order.Click += Btn_order_Click;
        }

        private void Btn_order_Click(object sender, EventArgs e)
        {
            util.OpenChildForm(new OrderManagementForm(), panelBody);
        }

        private void btn_flashsale_Click(object sender, EventArgs e)
        {
            util.OpenChildForm(new FlashSaleManagementForm(), panelBody);
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            menuTransition.Start();

        }
        bool sidebarExpland = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpland)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 60)
                {
                    sidebarExpland = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 200)
                {
                    sidebarExpland = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            util.OpenChildForm(new GUI.ProductForm(), panelBody);
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {

        }

        private void btn_ParentProduct_Click(object sender, EventArgs e)
        {
            util.OpenChildForm(new GUI.MangerProductForm(), panelBody);
        }

        private void btnProductObject_Click(object sender, EventArgs e)
        {
            ProductObjectManager p = new ProductObjectManager();
            GenericService<ProductObjectDTO> o = new GenericService<ProductObjectDTO>(p);
            util.OpenChildForm(new GUI.Test.test_templates_crud_co_ban<ProductObjectDTO>(o), panelBody);
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            //UserAccountManager p = new UserAccountManager(new DAL.UserAccountRepository(new DAL.DbContextDataContext()));
            //GenericService<UserAccountDTO> o = new GenericService<UserAccountDTO>(p);

            //util.OpenChildForm(new GUI.Test.test_templates_crud_co_ban<UserAccountDTO>(o), panelBody);
        }

        private void btnImportProduct_Click(object sender, EventArgs e)
        {
            util.OpenChildForm(new GUI.ImportProductManagementForm(), panelBody);

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            util.OpenChildForm(new GUI.BillImportProductManagement(), panelBody);
        }
    }
}
