using LibBLL;
using LibDAL;
using LibDTO;
using Newtonsoft.Json;
using Nike_Shop_Management.CloudService;
using Nike_Shop_Management.CustomControl;
using Nike_Shop_Management.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nike_Shop_Management.GUI
{
    public partial class OrderManagementForm : Form
    {
        private readonly UserOrdersManager userOrdersManagement = new UserOrdersManager();
        private readonly UserOrderStatusManager userOrderStatusManager = new UserOrderStatusManager();
        List<ProductParentDTO> listProductParent;
        GHNService.GHNService ghn = new GHNService.GHNService();
        public int User_order_status_id { get; set; }
        UserOrderDTO selectedUserOrder = null;
        List<UserOrderDTO> userOrders = null;
        public OrderManagementForm()
        {
            InitializeComponent();
            LoadUserOrder(0);
            load_cbo_order_status();
            this.cbo_order_status.SelectedIndexChanged += Cbo_order_status_SelectedIndexChanged;
            this.grd_user_order.CellClick += Grd_user_order_CellClick;
            this.btn_Confirm_Order.Visible = false;
            this.btn_Confirm_Order.Click += Btn_Confirm_Order_Click;
        }


        private void Grd_user_order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 
            int user_order_id = int.Parse(grd_user_order.Rows[e.RowIndex].Cells["user_order_id"].Value.ToString());
            LoadDataPanel(user_order_id);
            User_order_status_id = int.Parse(grd_user_order.Rows[e.RowIndex].Cells["order_status_id"].Value.ToString());
            if(User_order_status_id == 2)
            {
                this.btn_Confirm_Order.Visible = true;
            }
            else
            {
                this.btn_Confirm_Order.Visible = false;
            }

            int rowIndex = e.RowIndex;
            selectedUserOrder = userOrders.ElementAt(rowIndex);

        }

        private async void Btn_Confirm_Order_Click(object sender, EventArgs e)
        {
            int sum_weight = 10;
            int sum_height = 10;
            int sum_width = 10;
            int sum_length = 10;

            int to_DistrictID = int.Parse(selectedUserOrder.GHN_service.Split(',')[1]);
            string to_WardID = selectedUserOrder.GHN_service.Split(',')[2];
            int serviceType = int.Parse(selectedUserOrder.GHN_service.Split(',')[4]);
            int codAmount = 0;
            if (selectedUserOrder.Payment_method == "VNPAY")
            {
                codAmount = (int)selectedUserOrder.Final_price;
            }
            var orderData = new
            {
                payment_type_id = selectedUserOrder.Shipping_fee > 0 ? 2 : 1,
                note = "Hi HI HI",
                required_note = "KHONGCHOXEMHANG",
                from_name = "Nike Store",
                from_phone = "0939638911",
                from_address = "140 Le Trong Tran",
                from_ward_name = "Tay Thanh",
                from_district_name = "Tan Phu",
                from_province_name = "Ho Chi Minh",
                to_name = selectedUserOrder.First_name,
                to_phone = selectedUserOrder.Phone_number,
                to_address = selectedUserOrder.Address,
                to_ward_code = to_WardID,
                to_district_id = to_DistrictID,
                cod_amount = codAmount,
                weight = sum_weight,
                length = sum_height,
                width = sum_width,
                height = sum_length,
                service_type_id = serviceType,
                items = new List<object>()
                {
                    new
                    {
                        name = "Nike",
                        weight = sum_weight,
                        length = sum_height,
                        width = sum_width,
                        height = sum_length,
                        quantity = 1
                    }
                }
            };

            var response = await ghn.CreateOrderGHN(orderData);
            if (response.Code == "200")
            {
                string order_code = response.Data.order_code;
                userOrdersManagement.UpdateOrderCode(selectedUserOrder.User_order_id, order_code);
                MessageBox.Show("Tạo đơn hàng thành công");
                LoadUserOrder(3);
                // set selected combo box to 3
                this.cbo_order_status.SelectedValue = 3;
            }
            else
            {
                MessageBox.Show("Tạo đơn hàng thất bại");
            }


        }

        private void Cbo_order_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            int user_order_status_id = (int)this.cbo_order_status.SelectedValue;
            LoadUserOrder(user_order_status_id);
            this.btn_Confirm_Order.Visible = false;
            LoadDataPanel(0);
        }

        private async void LoadUserOrder(int sorted)
        {
            this.grd_user_order.AutoGenerateColumns = false;
           userOrders = null;
            if (sorted == 0)
            {
                userOrders = userOrdersManagement.GetUserOrders();
            }
            else
            {
                userOrders = userOrdersManagement.GetUserOrderByStatus(sorted);
            }

            // update user_order_status_id by GHN service

            foreach (var item in userOrders)
            {
                var order_code = item.Order_code;
                var res = await ghn.GetOrderDetailGHN(order_code);
                string status = res.Data.status;
                MessageBox.Show(status);
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
                DataPropertyName = "UserOrderStatusId",
                HeaderText = "UserOrderStatusId",
                Name = "order_status_id",
                Visible = false
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
                DataPropertyName = "Address",
                HeaderText = "Địa chỉ",
                Name = "Address"
            });

            this.grd_user_order.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total_quantity",
                HeaderText = "Số lượng",
                Name = "total_quantity"
            });
            this.grd_user_order.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "GHN_service",
                HeaderText = "GHN String",
                Name = "ghn_service",
                Visible = false
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
