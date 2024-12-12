using LibBLL;
using Nike_Shop_Management.DAL;
using LibDTO;
using MappingLayer;
using LibDAL;
using LibConstants;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Nike_Shop_Management.GUI
{
    public partial class EditProductSizeForm : Form
    {
        List<SizeDTO> listInventory;
        List<int> listCurrentTemp = new List<int>();
        List<GetTheSizeProductCurrentResult> listCurrent;
        public int ProductID { get; set; }
        ProductSizeManager pzM;

        public EditProductSizeForm()
        {
            InitializeComponent();
            btnLeftToRight.Click += BtnLeftToRight_Click;
            btnRightToLeft.Click += BtnRightToLeft_Click;
            btnSave.Click += BtnSave_Click;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool flagT = true;
            foreach (var item in listCurrentTemp)
            {
                if (pzM.Delete(item) == 0)
                {
                    MessageBox.Show("Khong the xoa size", item.ToString());
                    return;
                }
            }

            for (int i = 0; i < ListSizeCurrent.RowCount - 1; i++)
            {
                if (ListSizeCurrent[2, i].Value != null)
                {
                    // bỏ qua nè
                    continue;
                }
                else
                {
                    // thêm vào nè
                    int flag =  pzM.Add(new ProductSizeDTO()
                    {
                        product_id = ProductID,
                        size_id = int.Parse(ListSizeCurrent[0, i].Value.ToString()),
                        soluong = 1
                    }) ;
                    if(flag==0)
                    {
                        flagT = false;
                        break;
                    }
                }
            }
            if(!flagT)
            {
                MessageBox.Show("Cap nhat Size that bai");
            }
            else
            {
                MessageBox.Show("Cap nhat size thanh cong!");
            }
            this.Close();
        }

        private void BtnRightToLeft_Click(object sender, EventArgs e)
        {
            if (ListSizeCurrent.SelectedRows != null)
            {
                var valueSelected = ListSizeCurrent.CurrentRow;
                if (valueSelected.Cells[2].Value != null)
                {
                    listCurrentTemp.Add(int.Parse(valueSelected.Cells[2].Value.ToString()));
                    Console.WriteLine(listCurrentTemp.Count);
                }

                ListSizeCurrent.Rows.Remove(valueSelected);
                ListSizeInventory.Rows.Add(new object[] { valueSelected.Cells[0].Value.ToString(), valueSelected.Cells[1].Value.ToString(), valueSelected.Cells[2].Value != null ? valueSelected.Cells[2].Value.ToString() : null });
            }
        }

        private void BtnLeftToRight_Click(object sender, EventArgs e)
        {
            if (ListSizeInventory.SelectedRows != null)
            {

                var valueSelected = ListSizeInventory.CurrentRow;
                if (valueSelected.Cells[2].Value != null)
                {
                    listCurrentTemp.Remove(int.Parse(valueSelected.Cells[2].Value.ToString()));
                }

                ListSizeInventory.Rows.Remove(valueSelected);
                ListSizeCurrent.Rows.Add(new object[] { valueSelected.Cells[0].Value.ToString(), valueSelected.Cells[1].Value.ToString(), valueSelected.Cells[2].Value != null ? valueSelected.Cells[2].Value.ToString() : null });
            }
        }

        public void InitData(int product_id, TypeSize typeSize)
        {
            pzM = new ProductSizeManager();
            ProductID = product_id;
            listInventory = pzM.GetProductSizeInventory(product_id, typeSize);
            ListSizeInventory.Columns.Clear();
            ListSizeInventory.Columns.Add("size_id", "Size ID");
            ListSizeInventory.Columns.Add("size_name", "Size Name");
            ListSizeInventory.Columns.Add("product_size_id", "Product_size_id");

            ListSizeCurrent.Columns.Clear();
            ListSizeCurrent.Columns.Add("size_id", "Size ID");
            ListSizeCurrent.Columns.Add("size_name", "Size Name");
            ListSizeCurrent.Columns.Add("product_size_id", "Product_size_id");
            //  ListSizeCurrent.Columns[2].Visible = false;
            foreach (var item in listInventory)
            {
                ListSizeInventory.Rows.Add(new object[] { item.size_id, item.size_name, null });
            }

            ProductColorManager pcM = new ProductColorManager();
            listCurrent = pcM.GetProductSizesByID(product_id);
            foreach (var item in listCurrent)
            {
                ListSizeCurrent.Rows.Add(new object[] { item.size_id, item.size_name, item.product_size_id });
            }


        }
        private void EditProductSizeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
