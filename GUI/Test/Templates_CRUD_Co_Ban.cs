using LibBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Nike_Shop_Management.GUI.Test
{
    public partial class Templates_CRUD_Co_Ban<T> : UserControl where T : class
    {
        private GenericService<T> _service;
        public Templates_CRUD_Co_Ban(GenericService<T> service)
        {
            InitializeComponent();
            _service = service;
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            btn_Search.Click += Btn_Search_Click;
            u_DataGridView1.ClickChanged += U_DataGridView1_ClickChanged;
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            txt_user_search.Text = txt_user_search.Text.Trim();
            if (txt_user_search.Text.Length == 0)
            {
                u_DataGridView1.LoadData(_service.GetAll().ToList());
                return;
            }
            string user_search = txt_user_search.Text;
            u_DataGridView1.LoadData(_service.Search(user_search).ToList());

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            T DataSelected = (T)u_DataGridView1.DataSelected;
            if (DataSelected != null)
            {
                var id = typeof(T).GetProperties().ElementAt(0).GetValue(DataSelected).ToString();
                if (id != null)
                {
                    int flag = _service.Delete((Int32.Parse(id)));
                    if (flag == 1)
                    {

                        MessageBox.Show("DELETE SUCCESSFULLY");
                    }
                    else
                    {
                        MessageBox.Show("FAILD TO DELETE");
                    }
                }
            }
            u_DataGridView1.LoadData(_service.GetAll().ToList());

        }

        // 
        private void U_DataGridView1_ClickChanged(object sender, EventArgs e)
        {
            T DataSelected = (T)u_DataGridView1.DataSelected;
            var Properties = typeof(T).GetProperties();

            Dictionary<string, string> dic = new Dictionary<string, string>();

            for (int i = 0; i < Properties.Length; i++)
            {
                if (Properties.ElementAt(i).GetValue(DataSelected) == null)
                {
                    Properties.ElementAt(i).SetValue(DataSelected, " ");
                }
                dic.Add(Properties.ElementAt(i).Name, Properties.ElementAt(i).GetValue(DataSelected).ToString());

            }

            if (dic != null)
            {
                foreach (var item in tableLayoutPanel_Show.Controls)
                {
                    if (item is TextBox textbox)
                    {
                        string values = dic[textbox.Name];
                        textbox.Text = values;
                    }
                }
            }

        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            T newItem = GetTypeForUpdate();
            int flag = _service.Update(newItem);
            if (flag == 1)
            {
                MessageBox.Show("UPDATE SUCCESSFULLY");
            }
            else
            {
                MessageBox.Show("UPDATE FAIELD");
            }
            u_DataGridView1.LoadData(_service.GetAll().ToList());

        }

        private new T GetType()
        {
            var list = u_DataGridView1.GetSource<T>();
            T newItem = Activator.CreateInstance<T>();
            if (list != null)
            {
                foreach (var item in tableLayoutPanel_Show.Controls)
                {
                    if (item.GetType() != typeof(Label))
                    {
                        TextBox textBox = (TextBox)item;
                        if (textBox.Enabled != false)
                        {
                            var property = typeof(T).GetProperty(textBox.Name);
                            if (property != null)
                            {
                                object value = Convert.ChangeType(textBox.Text, property.PropertyType);
                                property.SetValue(newItem, value);
                            }
                        }

                    }
                }
            }
            return newItem;
        }
        public T GetTypeForUpdate()
        {
            var list = u_DataGridView1.GetSource<T>();
            T newItem = Activator.CreateInstance<T>();
            if (list != null)
            {
                foreach (var item in tableLayoutPanel_Show.Controls)
                {
                    if (item.GetType() != typeof(Label))
                    {
                        TextBox textBox = (TextBox)item;

                        var property = typeof(T).GetProperty(textBox.Name);
                        if (property != null)
                        {
                            object value = Convert.ChangeType(textBox.Text, property.PropertyType);
                            property.SetValue(newItem, value);
                        }
                    }
                }
            }
            return newItem;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            T newItem = GetType();
            int flag = _service.Add(newItem);
            if (flag == 1)
            {
                MessageBox.Show("SUCCSECFULL");
            }
            else
            {
                MessageBox.Show("FAILED");
            }

            u_DataGridView1.LoadData(_service.GetAll().ToList());
        }

        /// <summary>
        /// đây là hàm được sử dụng với mục đích truyền vào các control để khởi tạo ra các component tự động ở trong panel
        /// bên trong chứa các đối tượng textbox,... để cho việc thêm, xóa, sửa,...
        /// </summary>
        /// <param name="controls"></param>
        public void PaintTheInputText(params Control[] controls)
        {
            tableLayoutPanel_Show.ColumnCount = 2;
            tableLayoutPanel_Show.RowCount = controls.Length;

            tableLayoutPanel_Show.ColumnStyles.Clear();
            tableLayoutPanel_Show.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel_Show.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));

            tableLayoutPanel_Show.RowStyles.Clear();
            for (int i = 0; i < tableLayoutPanel_Show.RowCount; i++)
            {
                tableLayoutPanel_Show.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            tableLayoutPanel_Show.Controls.Clear();

            int row = 0;

            foreach (var control in controls)
            {
                // Tạo một Label tương ứng với mỗi Control
                Label label = new Label
                {
                    Margin = new Padding(10, 8, 0, 0),
                    Text = control.Name,
                    AutoSize = true
                };

                tableLayoutPanel_Show.Controls.Add(label, 0, row);
                tableLayoutPanel_Show.Controls.Add(control, 1, row);

                row++;
            }
        }
        /// <summary>
        /// hàm được gọi ra để truyền danh sách biến về bên trong datagirdview
        /// cũng như cho việc setup component
        /// </summary>
        /// <param name="list"></param>
        public void SetForm(IList<T> list)
        {
            u_DataGridView1.LoadData(list);
            List<Control> controls = new List<Control>();

            foreach (DataGridViewColumn column in u_DataGridView1.Columns)
            {
                Type columnType = column.ValueType;
                if (columnType == typeof(string) || columnType == typeof(int))
                {
                    if (column == u_DataGridView1.Columns.ElementAt(0))
                    {
                        TextBox txReadonly = new TextBox
                        {
                            Name = column.HeaderText
                        };
                        txReadonly.Enabled = false;
                        controls.Add(txReadonly);
                        continue;
                    }
                    TextBox tx = new TextBox
                    {
                        Name = column.HeaderText
                    };
                    controls.Add(tx);
                }
            }

            PaintTheInputText(controls.ToArray());
        }
        public void SetTitle(string nameTitle)
        {
            Label_Name_of_Bussiness.Text = nameTitle;
        }

        private void u_DataGridView1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
