using LibBLL;
using LibDAL;
using LibDTO;
using Nike_Shop_Management.CloudService;
using Nike_Shop_Management.CustomControl;
using Nike_Shop_Management.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nike_Shop_Management.GUI
{
    public partial class OrderManagementForm : Form
    {
        ProductParentManager ppM = new ProductParentManager();
        private readonly UserOrdersManager userOrdersManagement = new UserOrdersManager();
        private readonly UserOrderStatusManager userOrderStatusManager = new UserOrderStatusManager();
        List<ProductParentDTO> listProductParent;
        public OrderManagementForm()
        {
            InitializeComponent();
            LoadUserOrder(0);
            load_cbo_order_status();
            this.cbo_order_status.SelectedIndexChanged += Cbo_order_status_SelectedIndexChanged;
            this.grd_user_order.CellClick += Grd_user_order_CellClick;
        }

        private void Grd_user_order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 
            int user_order_id = int.Parse(grd_user_order.Rows[e.RowIndex].Cells["user_order_id"].Value.ToString());
            LoadDataPanel(user_order_id);
        }

        private void Cbo_order_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            int user_order_status_id = (int)this.cbo_order_status.SelectedValue;
            LoadUserOrder(user_order_status_id);
        }

        private void LoadUserOrder(int sorted)
        {
            this.grd_user_order.AutoGenerateColumns = false;
            IEnumerable<UserOrderDTO> userOrders = null;
            if (sorted == 0)
            {
                userOrders = userOrdersManagement.GetUserOrders();
            }
            else
            {
                userOrders = userOrdersManagement.GetUserOrderByStatus(sorted);
            }
            this.grd_user_order.ScrollBars = ScrollBars.Both;

            this.grd_user_order.DataSource = userOrders;

            this.grd_user_order.Columns.Clear();

            this.grd_user_order.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "user_order_id",
                HeaderText = "Mã đơn hàng",
                Name = "user_order_id"
            });

            this.grd_user_order.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "first_name",
                HeaderText = "Khách hàng",
                Name = "first_name"
            });

            this.grd_user_order.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "email",
                HeaderText = "Email",
                Name = "email"
            });

            this.grd_user_order.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "phone_number",
                HeaderText = "Số điện thoại",
                Name = "phone_number"
            });

            this.grd_user_order.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "payment_method",
                HeaderText = "Phương thức thanh toán",
                Name = "payment_method"
            });

            this.grd_user_order.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UserOrderStatusName",
                HeaderText = "Trạng thái",
                Name = "order_status"
            });

            this.grd_user_order.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "total_price",
                HeaderText = "Tổng tiền",
                Name = "total_price"
            });

            this.grd_user_order.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "shipping_fee",
                HeaderText = "Phí Ship",
                Name = "shipping_fee"
            });

            this.grd_user_order.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "final_price",
                HeaderText = "Thành tiền",
                Name = "final_price"
            });

            this.grd_user_order.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedAt",
                HeaderText = "Ngày đặt",
                Name = "created_at"
            });

            this.grd_user_order.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Return_expiration_date",
                HeaderText = "Ngày hết hạn trả hàng",
                Name = "return_expiration_date"
            });

            this.grd_user_order.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "order_code",
                HeaderText = "Mã vận đơn",
                Name = "order_code"
            });

            this.grd_user_order.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "order_code_return",
                HeaderText = "Mã trả hàng",
                Name = "order_code_return"
            });

            this.grd_user_order.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total_quantity",
                HeaderText = "Số lượng",
                Name = "total_quantity"
            });
        }
        private void LoadDataPanel(int user_order_id)
        {
            listProductParent = userOrdersManagement.getProductParentByUserOrder(user_order_id);
            if (panel_order_product.Controls.Count > 0)
            {
                panel_order_product.Controls.Clear();
            }
            if (listProductParent != null)
            {
                foreach (var item in listProductParent)
                {
                    U_ProductParentOrder u = new U_ProductParentOrder();
                    u.PaintData(item);
                    panel_order_product.Controls.Add(u);
                }
            }
        }
        private void load_cbo_order_status()
        {
            var userOrderStatus = userOrderStatusManager.GetUserOrderStatus();
            userOrderStatus.Insert(0, new UserOrderStatusDTO
            {
                user_order_status_id = 0,
                user_order_status_name = "Tất cả"
            });
            this.cbo_order_status.DataSource = userOrderStatus;
            this.cbo_order_status.DisplayMember = "user_order_status_name";
            this.cbo_order_status.ValueMember = "user_order_status_id";
        }



    }
}
