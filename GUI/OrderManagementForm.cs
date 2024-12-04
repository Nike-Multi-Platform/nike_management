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
using static System.Net.Mime.MediaTypeNames;
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
        private readonly List<object> statusDescriptions = new List<object>
        {
            new { Key = "ready_to_pick", Value = "Người bán đang chuẩn bị hàng" },
            new { Key = "picking", Value = "Đang lấy hàng" },
            new { Key = "cancel", Value = "Hủy đơn hàng" },
            new { Key = "money_collect_picking", Value = "Đang thu tiền người gửi" },
            new { Key = "picked", Value = "Đã lấy hàng" },
            new { Key = "storing", Value = "Hàng đang nằm ở kho" },
            new { Key = "transporting", Value = "Đang luân chuyển hàng" },
            new { Key = "sorting", Value = "Đang phân loại hàng hóa" },
            new { Key = "delivering", Value = "Nhân viên đang giao cho người nhận" },
            new { Key = "money_collect_delivering", Value = "Nhân viên đang thu tiền người nhận" },
            new { Key = "delivered", Value = "Giao hàng thành công" },
            new { Key = "delivery_fail", Value = "Giao hàng thất bại" },
            new { Key = "waiting_to_return", Value = "Đang đợi trả hàng về cho người gửi" },
            new { Key = "return", Value = "Trả hàng" },
            new { Key = "return_transporting", Value = "Đang luân chuyển hàng trả" },
            new { Key = "return_sorting", Value = "Đang phân loại hàng trả" },
            new { Key = "returning", Value = "Nhân viên đang đi trả hàng" },
            new { Key = "return_fail", Value = "Nhân viên trả hàng thất bại" },
            new { Key = "returned", Value = "Nhân viên trả hàng thành công" },
            new { Key = "exception", Value = "Đơn hàng ngoại lệ không nằm trong quy trình" },
            new { Key = "damage", Value = "Hàng bị hư hỏng" },
            new { Key = "lost", Value = "Hàng bị mất" }
        };

        private readonly List<string> statusEnableReturn = new List<string>
        {
            "ready_to_pick",
            "picking",
            "money_collect_picking",
            "picked",
            "storing",
            "transporting",
            "sorting",
            "delivering",
            "transporting",
            "transporting",
            "delivery_fail",
        };


        public OrderManagementForm()
        {
            InitializeComponent();
            LoadUserOrder(0);
            load_cbo_order_status();
            this.cbo_order_status.SelectedIndexChanged += Cbo_order_status_SelectedIndexChanged;
            this.grd_user_order.CellClick += Grd_user_order_CellClick;
            this.btn_Confirm_Order.Visible = false;
            this.btn_Confirm_Order.Click += Btn_Confirm_Order_Click;
            this.lb_status.AutoSize = true;
            this.lb_status.Visible = false;
            this.lb_status.Width = ScrollStateFullDrag;
            this.lb_status_title.Width = ScrollStateFullDrag;
            this.lb_status_title.Visible = false;
            this.lb_status_title.Text = "Trạng thái giao hàng";
            this.grd_user_order.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.grd_user_order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.panel_order_product.AutoScroll = true;
            this.btn_cancle_order.Visible = false;
            this.btn_cancle_order.Click += Btn_cancle_order_Click;
        }

        private async void Btn_cancle_order_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn hủy đơn hàng không?",
                                     "Xác nhận hủy đơn hàng",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
               
                if(selectedUserOrder.User_order_status_id == 1)
                {
                    userOrdersManagement.CancelOrder(selectedUserOrder.User_order_id);
                    MessageBox.Show("Hủy đơn hàng thành công");
                    LoadUserOrder(5);
                    this.cbo_order_status.SelectedValue = 5;
                }
                else
                {
                    List<string> order_code = new List<string>
                    {
                        selectedUserOrder.Order_code
                    };
                    var resCancle = await ghn.CancelOrderGHN(order_code);
                    if(resCancle.Code == "200")
                    {
                        userOrdersManagement.CancelOrder(selectedUserOrder.User_order_id);
                        MessageBox.Show("Hủy đơn hàng thành công");
                        LoadUserOrder(5);
                        this.cbo_order_status.SelectedValue = 5;
                    }
                    else
                    {
                        MessageBox.Show("Hủy đơn hàng thất bại");
                    }   
                }
            }
        }

        private async void enableCancleButton(int user_order_status_id, string order_code)
        {
            
            if (user_order_status_id == 1 || user_order_status_id == 2)
            {
                this.btn_cancle_order.Visible = true;
            }
            else if(user_order_status_id == 3)
            {
                var res = await ghn.GetOrderDetailGHN(order_code);
                var ghn_status = res.Data.status;
                if (statusEnableReturn.Contains(ghn_status))
                {
                    this.btn_cancle_order.Visible = true;
                }
            }
            else
            {
                this.btn_cancle_order.Visible = false;
            }
        }

        private async void Grd_user_order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 
            int user_order_id = int.Parse(grd_user_order.Rows[e.RowIndex].Cells["user_order_id"].Value.ToString());
            LoadDataPanel(user_order_id);
            User_order_status_id = int.Parse(grd_user_order.Rows[e.RowIndex].Cells["order_status_id"].Value.ToString());
            if(User_order_status_id == 1)
            {
                this.btn_Confirm_Order.Visible = true;
            }
            else
            {
                this.btn_Confirm_Order.Visible = false;
            }

            int rowIndex = e.RowIndex;
            selectedUserOrder = userOrders.ElementAt(rowIndex);
            var res = await ghn.GetOrderDetailGHN(selectedUserOrder.Order_code);
            if (res.Code == "200")
            {
                this.lb_status.Visible = true;


                foreach (var item in statusDescriptions)
                {
                    if (item.GetType().GetProperty("Key").GetValue(item).ToString() == res.Data.status)
                    {
                        this.lb_status.Text = item.GetType().GetProperty("Value").GetValue(item).ToString();
                        break;
                    }
                }
                //this.lb_status.Text = status.ToString();
                this.lb_status_title.Visible = true;
            }
            else
            {
                this.lb_status.Visible = false;
                this.lb_status_title.Visible = false;
            }
            enableCancleButton(User_order_status_id, selectedUserOrder.Order_code);
        }

        private async void Btn_Confirm_Order_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn tạo đơn hàng không?",
                                     "Xác nhận tạo đơn hàng",
                                     MessageBoxButtons.YesNo);
            if(confirmResult == DialogResult.Yes)
            {
                int sum_weight = 0;
                int sum_height = 0;
                int sum_width = 0;
                int sum_length = 0;

                List<UserOrderProductDTO> productsOrder = userOrdersManagement.GetProductOrder(selectedUserOrder.User_order_id);
                List<ProductParentDTO> listProductParent = new List<ProductParentDTO>();
                foreach (var item in productsOrder)
                {
                    ProductParentDTO productParent = userOrdersManagement.getProductParentBySize(item.product_size_id).FirstOrDefault();
                    listProductParent.Add(productParent);
                    sum_weight += productParent.Weight * item.amount;
                    sum_height += productParent.Height * item.amount;
                    sum_width += productParent.Width * item.amount;
                    sum_length += productParent.Length * item.amount;
                }
                var itemsOrder = new List<object>();
                foreach (var item in listProductParent)
                {
                    itemsOrder.Add(new
                    {
                        name = item.product_parent_name,
                        weight = item.Weight,
                        length = item.Length,
                        width = item.Width,
                        height = item.Height,
                        quantity = 1
                    });
                }

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
                    weight = sum_weight > 100 || sum_height < 1 ? 100 : sum_height,
                    length = sum_height > 100 || sum_height < 1 ? 100 : sum_height,
                    width = sum_width > 100 || sum_width < 1 ? 100 : sum_height,
                    height = sum_length > 100 || sum_height < 1 ? 100 : sum_height,
                    service_type_id = serviceType,
                    items = itemsOrder
                };

                var response = await ghn.CreateOrderGHN(orderData);
                if (response.Code == "200")
                {
                    string order_code = response.Data.order_code;
                    userOrdersManagement.UpdateOrderCode(selectedUserOrder.User_order_id, order_code);
                    MessageBox.Show("Tạo đơn hàng thành công");
                    LoadUserOrder(2);
                    this.cbo_order_status.SelectedValue = 2;
                }
                else
                {
                    MessageBox.Show("Tạo đơn hàng thất bại");
                }
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
            int checkUpdate = 0;
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
                if(res.Code == "200")
                {
                    var order_status = res.Data.status;
                    if(userOrdersManagement.UpdateOrderStatus(item.User_order_id, sorted, order_status) != null)
                        checkUpdate = 1;
                }
            }

            if(checkUpdate == 1)
            {
                if (sorted == 0)
                {
                    userOrders = userOrdersManagement.GetUserOrders();
                }
                else
                {
                    userOrders = userOrdersManagement.GetUserOrderByStatus(sorted);
                }
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
            this.grd_user_order.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Transaction_code",
                HeaderText = "Transaction code",
                Name = "Transaction_code",
            });
        }
        private void LoadDataPanel(int user_order_id)
        {
            List<UserOrderProductDTO> productsOrder = userOrdersManagement.GetProductOrder(user_order_id);
            if (panel_order_product.Controls.Count > 0)
            {
                panel_order_product.Controls.Clear();
            }
            if (productsOrder != null)
            {
                foreach (var item in productsOrder)
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
