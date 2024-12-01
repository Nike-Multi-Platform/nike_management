using LibBLL;
using LibDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Nike_Shop_Management.GUI
{
    public partial class AddProductParentForm : Form
    {
        public AddProductParentForm()
        {
            InitializeComponent();
            InitData();
            comboProductObjectFilter.SelectedIndexChanged += ComboProductObjectFilter_SelectedIndexChanged;
            comboProductCategoriesFileter.SelectedIndexChanged += ComboProductCategoriesFileter_SelectedValueChanged;
            ComboSubCategoriesFilter.SelectedIndexChanged += ComboSubCategoriesFilter_SelectedIndexChanged;
            btnAdd.Click += BtnAdd_Click;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txPrice.Text.Length == 0 || txtProductName.Text.Length == 0)
            {
                MessageBox.Show("Don't leave blank!");
                return;
            }

            SubCategoryDTO selectedSubcategory = (SubCategoryDTO)ComboSubCategoriesFilter.SelectedItem;
            if (selectedSubcategory != null)
            {
                backgroundWorker1.RunWorkerAsync();
            }

        }

        public void InitData()
        {
            ProductObjectManager poM = new ProductObjectManager();
            List<ProductObjectDTO> list = (List<ProductObjectDTO>)poM.GetAll();
            comboProductObjectFilter.DataSource = list;
            comboProductObjectFilter.DisplayMember = "product_object_name";
            comboProductObjectFilter.ValueMember = "product_object_id";
        }
        private void ComboProductObjectFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            var selectedValue = comboProductObjectFilter.SelectedValue?.ToString();
            ProductCategoriesManager pcM = new ProductCategoriesManager();
            List<ProductCategoriesDTO> list = new List<ProductCategoriesDTO>();

            if (selectedValue != "0")
            {
                if (!comboProductCategoriesFileter.Enabled)
                {
                    comboProductCategoriesFileter.Enabled = true;
                }
                list = (List<ProductCategoriesDTO>)pcM.GetProductCategoriesByID(int.Parse(selectedValue));
            }
            else
            {
                list = (List<ProductCategoriesDTO>)pcM.GetAll();
            }
            if (list.Count != 0)
            {
                comboProductCategoriesFileter.DataSource = list;
                comboProductCategoriesFileter.DisplayMember = "categories_name";
                comboProductCategoriesFileter.ValueMember = "categories_id";

            }
            else
            {
                comboProductCategoriesFileter.DataSource = null;
                comboProductCategoriesFileter.Enabled = false;
            }


        }
        private void ComboProductCategoriesFileter_SelectedValueChanged(object sender, EventArgs e)
        {
            ProductCategoriesDTO selectedValue = (ProductCategoriesDTO)comboProductCategoriesFileter.SelectedItem;
            if (selectedValue != null)
            {
                SubCategoryManager sbM = new SubCategoryManager();
                List<SubCategoryDTO> list = (List<SubCategoryDTO>)sbM.GetAllByID(selectedValue.categories_id);
                ComboSubCategoriesFilter.DataSource = list;
                ComboSubCategoriesFilter.DisplayMember = "sub_categories_name";
                ComboSubCategoriesFilter.ValueMember = "sub_categories_id";
                ComboSubCategoriesFilter.Enabled = true;
            }
            else
            {
                ComboSubCategoriesFilter.Enabled = false;

            }

        }

        private void ComboSubCategoriesFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

           u_PictureBox.UploadImage(u_PictureBox.PathThumbail);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(u_PictureBox.PathThumbail);
            string linkHolder = "Nike-application/" + fileNameWithoutExtension;
            SubCategoryDTO selectedSubcategory = (SubCategoryDTO)ComboSubCategoriesFilter.SelectedItem;
            ProductParentManager ppM = new ProductParentManager();
            ProductParentDTO productParentDTO = new ProductParentDTO();
            productParentDTO.product_parent_name = txtProductName.Text;
            productParentDTO.product_price = txPrice.Text;
            productParentDTO.is_new_release = true;
            productParentDTO.sub_categories_id = selectedSubcategory.sub_categories_id;
            productParentDTO.product_icons_id = 1;
            productParentDTO.thumbnail = linkHolder;
            int flag = ppM.InsertProductParents(productParentDTO);
            if (flag == 1)
            {
                MessageBox.Show("Add Product secssfull");
                this.Close();

            }
            else
            {
                MessageBox.Show("hehe failed");
            }
        }

        private void u_PictureBox_Load(object sender, EventArgs e)
        {

        }
    }
}
