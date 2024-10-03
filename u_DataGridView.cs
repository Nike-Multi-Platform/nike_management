using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nike_Shop_Management
{
    public partial class u_DataGridView : UserControl
    {
        // đối tượng được chọn ở trong data gridview
        public object DataSelected { get; set; }

        /// <summary>
        /// <para>-1: không chọn gì</para>
        /// <para>0: chọn sự kiện sửa</para>
        /// <para>1: chọn sự kiện xóa</para>
        /// </summary>
        public int GetIndexSelected { get; set; }
        public IEnumerable<DataGridViewColumn> Columns { get; internal set; }

        //bắt sự kiện gửi ra ngoài
        public event EventHandler ClickChanged;
        public u_DataGridView()
        {
            InitializeComponent();
            dataGridView.MouseDown += DataGridView_MouseDown;
            dataGridView.CellClick += GetDataGridSelected;
        }
        // hàm xử lý mở context scipt
        private void DataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dataGridView.HitTest(e.X, e.Y);

                if (hitTestInfo.RowIndex >= 0)
                {
                    dataGridView.ClearSelection();
                    dataGridView.Rows[hitTestInfo.RowIndex].Selected = true;
                    DataSelected = dataGridView.Rows[hitTestInfo.RowIndex].DataBoundItem;

                    Point mousePosition = dataGridView.PointToClient(MousePosition);
                    cmsData.Show(dataGridView, mousePosition);

                }
            }
        }
        // hàm sự kiện click của datagridview nơi để gán dataselected và truyền ra bên ngoài thông qua invoke  clickchanged
        public void GetDataGridSelected(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GetIndexSelected = -1;
                DataSelected = dataGridView.Rows[e.RowIndex].DataBoundItem;
                ClickChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        // phương thức <T> chấp nhận mọi kiểu đối tượng 
        // mục đích có thể truyền nhiều loại dữ liệu vào mà không cần định nghĩa lại đối tượng trong list
        public void LoadData<T>(IList<T> list)
        {
            // khi data thay đổi liên tục thì sẽ xóa data cũ để update data mới
            if (this.dataGridView.RowCount > 0)
            {
                this.dataGridView.DataSource = null;
            }
            this.dataGridView.DataSource = list;
            Columns = dataGridView.Columns.Cast<DataGridViewColumn>().ToList();
        }


        public IList<T> GetSource<T>()
        {
            if (dataGridView.DataSource is List<T> list)
            {
                return list; // Nếu DataSource là List<T>, trả về ngay
            }
            return new List<T>(); // Trả về danh sách trống nếu không phải loại mong muốn
        }

        // trả ra indexselected là 0 để container bắt sự kiện mở form SỬA 
        // và trả ra 1 object để form container xử lý
        private void suaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataSelected != null)
            {
                GetIndexSelected = 0;
                ClickChanged?.Invoke(this, EventArgs.Empty);
            }
        }


        // như trên nhưng indexselected 1 là xóa
        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataSelected != null)
            {
                GetIndexSelected = 1;
                ClickChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataSelected != null)
            {
                GetIndexSelected = 2;
                ClickChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
