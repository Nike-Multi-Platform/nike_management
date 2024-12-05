using LibBLL;
using LibDTO;
using Nike_Shop_Management.CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nike_Shop_Management.GUI
{
    public partial class OrdersReturnForm : Form
    {
        ReturnRequestManager returnRequestManager = new ReturnRequestManager();
        UserOrdersManager userOrdersManagement = new UserOrdersManager();
        GHNService.GHNService ghn = new GHNService.GHNService();
        ReturnRequestDTO selectedRequest = null;
        List<ReturnRequestDTO> returnRequestDTOs = null;
        public OrdersReturnForm()
        {
            InitializeComponent();
            LoadData(1);
            this.btn_accept.Visible = false;
            this.btn_reject.Visible = false;
            this.grd_order_cancle.CellClick += Grd_order_cancle_CellClick;
            this.panel_user_order_details.AutoScroll = true;
            this.panel_user_order_details.BorderStyle = BorderStyle.FixedSingle;
            this.panel_return_imgs.AutoScroll = true;
            this.panel_return_imgs.BorderStyle = BorderStyle.FixedSingle;
            load_cbo_order_status();
            cbo_return_type.SelectedIndexChanged += Cbo_return_type_SelectedIndexChanged;
            this.btn_accept.Click += Btn_accept_Click;
            this.btn_reject.Click += Btn_reject_Click;
        }

        private void Btn_reject_Click(object sender, EventArgs e)
        {
            if(selectedRequest != null)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn từ chối yêu cầu trả hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var resReject = returnRequestManager.RejectRequest(selectedRequest.Return_request_id);
                    if (resReject != null)
                    {
                        MessageBox.Show("Từ chối yêu cầu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData((int)cbo_return_type.SelectedValue);
                    }
                    else
                    {
                        MessageBox.Show("Từ chối yêu cầu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn yêu cầu trả hàng cần từ chối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            HideProcessButton();
        }

        private void HideProcessButton()
        {
            this.btn_accept.Visible = false;
            this.btn_reject.Visible = false;
        }

        private async void Btn_accept_Click(object sender, EventArgs e)
        {
            var user_order = new UserOrderDTO();
            if (selectedRequest != null)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn chấp nhận yêu cầu trả hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (selectedRequest.Request_type_id == 1)
                    {
                        user_order = userOrdersManagement.GetUserOrderByID(selectedRequest.User_order_id);
                        var resDetail = await ghn.GetOrderDetailGHN(user_order.Order_code);
                        if (resDetail.Code == "200")
                        {
                            var status = resDetail.Data.status;
                            if (status == "ready_to_pick" || status == "picking")
                            {
                                List<string> order_code = new List<string>
                                {
                                    user_order.Order_code
                                };
                                var res = await ghn.CancelOrderGHN(order_code);
                                if (res.Code == "200")
                                {
                                    var resUpdate = returnRequestManager.AcceptReturn(selectedRequest.Return_request_id, selectedRequest.User_order_id, "", 5); // update cancel order
                                    if (resUpdate != null)
                                    {
                                        MessageBox.Show("Chấp nhận yêu cầu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        LoadData((int)cbo_return_type.SelectedValue);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Chấp nhận yêu cầu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Hủy đơn hàng trên GHN thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Đơn hàng đang vận chuyển không thể hủy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            var resUpdate = returnRequestManager.AcceptReturn(selectedRequest.Return_request_id, selectedRequest.User_order_id, "", 5);
                            if (resUpdate != null)
                            {
                                MessageBox.Show("Chấp nhận yêu cầu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData((int)cbo_return_type.SelectedValue);
                            }
                            else
                            {
                                MessageBox.Show("Chấp nhận yêu cầu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        // create new ghn
                        int sum_weight = 0;
                        int sum_height = 0;
                        int sum_width = 0;
                        int sum_length = 0;
                        user_order = userOrdersManagement.GetUserOrderByID(selectedRequest.User_order_id);
                        List<UserOrderProductDTO> productsOrder = userOrdersManagement.GetProductOrder(user_order.User_order_id);
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
                        int to_DistrictID = int.Parse(user_order.GHN_service.Split(',')[1]);
                        string to_WardID = user_order.GHN_service.Split(',')[2];
                        int serviceType = int.Parse(user_order.GHN_service.Split(',')[4]);
                        int codAmount = 0;
                        if (user_order.Payment_method == "VNPAY")
                        {
                            codAmount = (int)user_order.Final_price;
                        }
                        var orderData = new
                        {
                            payment_type_id = user_order.Shipping_fee > 0 ? 2 : 1,
                            note = "Hi HI HI",
                            required_note = "KHONGCHOXEMHANG",
                            from_name = user_order.First_name,
                            from_phone = user_order.Phone_number,
                            from_address = user_order.Address,
                            from_ward_name = "Tay Thanh",
                            from_district_name = "Tan Phu",
                            from_province_name = "Ho Chi Minh",
                            to_name = "Nike shop",
                            to_phone = "0939638911",
                            to_address = "140 Le Trong Tran",
                            to_ward_code = "90749",
                            to_district_id = 3695,
                            cod_amount = codAmount,
                            weight = sum_weight > 100 || sum_height < 1 ? 100 : sum_height,
                            length = sum_height > 100 || sum_height < 1 ? 100 : sum_height,
                            width = sum_width > 100 || sum_width < 1 ? 100 : sum_height,
                            height = sum_length > 100 || sum_height < 1 ? 100 : sum_height,
                            service_type_id = serviceType,
                            items = itemsOrder
                        };
                        var resNewOrderGHN = await ghn.CreateOrderGHN(orderData); // create ghn order return product to shop
                        if (resNewOrderGHN.Code == "200")
                        {
                            string order_code = resNewOrderGHN.Data.order_code;
                            var resUpdateReturnCode = returnRequestManager.UpdateReturnOrderCode(user_order.User_order_id, order_code);
                            if (resUpdateReturnCode != null)
                            {
                                var resUpdate = returnRequestManager.AcceptReturn(selectedRequest.Return_request_id, user_order.User_order_id, order_code, 6); // update refund
                                if (resUpdate != null)
                                {
                                    MessageBox.Show("Chấp nhận yêu cầu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadData((int)cbo_return_type.SelectedValue);
                                }
                                else
                                {
                                    MessageBox.Show("Chấp nhận yêu cầu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật mã đơn hàng trả hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tạo đơn hàng thất bại");
                        }
                    }
                }

            }
            HideProcessButton();

        }

        private void Cbo_return_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            int request_type_id = (int)cbo_return_type.SelectedValue;
            LoadData(request_type_id);
        }

        private void load_cbo_order_status()
        {
            var return_type = returnRequestManager.GetReturnRequestTypes();
            this.cbo_return_type.DataSource = return_type;
            this.cbo_return_type.DisplayMember = "request_type_name";
            this.cbo_return_type.ValueMember = "request_type_id";
        }


        private void Grd_order_cancle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grd_order_cancle.Rows[e.RowIndex];
                if ((int)row.Cells["Status_id"].Value == 0 || row.Cells["Status_id"].Value == "Chưa xử lý")
                {
                    this.btn_accept.Visible = true;
                    this.btn_reject.Visible = true;
                }
                else
                {
                    this.btn_accept.Visible = false;
                    this.btn_reject.Visible = false;
                }
            }
            int user_order_id = (int)this.grd_order_cancle.Rows[e.RowIndex].Cells["User_order_id"].Value;
            LoadDataPanel(user_order_id);
            int return_request_id = (int)this.grd_order_cancle.Rows[e.RowIndex].Cells["Return_request_id"].Value;
            LoadRequestImages(return_request_id);
            // get selected return request
            selectedRequest = returnRequestDTOs[e.RowIndex];

        }

        public void LoadData(int request_type_id)
        {
            this.grd_order_cancle.AutoGenerateColumns = false;
            this.grd_order_cancle.Columns.Clear();
            this.grd_order_cancle.ScrollBars = ScrollBars.Both;
            this.grd_order_cancle.ReadOnly = true;
            this.grd_order_cancle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            returnRequestDTOs = returnRequestManager.GetReturnRequest(request_type_id);
            grd_order_cancle.DataSource = returnRequestDTOs;

            this.grd_order_cancle.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Return_request_id",
                HeaderText = "Mã yêu cầu",
                Name = "Return_request_id"
            });

            this.grd_order_cancle.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "User_order_id",
                HeaderText = "Mã đơn hàng",
                Name = "User_order_id"
            });
            this.grd_order_cancle.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Return_request_reason",
                HeaderText = "Lý do",
                Name = "Return_request_reason"
            });

            this.grd_order_cancle.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status_id",
                HeaderText = "Trạng thái",
                Name = "Status_id"
            });
            this.grd_order_cancle.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Request_type_id",
                HeaderText = "Loại yêu cầu",
                Name = "Request_type_id",
                Visible = false
            });
            this.grd_order_cancle.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Created_at",
                HeaderText = "Ngày yêu cầu",
                Name = "Created_at"
            });

            this.grd_order_cancle.CellFormatting += Grd_order_cancle_CellFormatting;
        }

        private void Grd_order_cancle_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the column is "Status_id"
            if (this.grd_order_cancle.Columns[e.ColumnIndex].Name == "Status_id")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();
                    Console.WriteLine($"Status_id value: {status}"); // Debugging line to check the value

                    switch (status)
                    {
                        case "1":
                            e.Value = "Đã xử lý";
                            break;
                        case "0":
                            e.Value = "Chưa xử lý";
                            break;
                        case "2":
                            e.Value = "Đã từ chối";
                            break;
                        case "Chưa xử lý":
                            e.Value = "Chưa xử lý";
                            break;
                        case "Đã xử lý":
                            e.Value = "Đã xử lý";
                            break;
                        case "Đã từ chối":
                            e.Value = "Đã từ chối";
                            break;
                        default:
                            e.Value = "Invalid Status";
                            break;
                    }
                    e.FormattingApplied = true;
                }
            }
        }

        private void LoadDataPanel(int user_order_id)
        {
            List<UserOrderProductDTO> productsOrder = userOrdersManagement.GetProductOrder(user_order_id);
            if (panel_user_order_details.Controls.Count > 0)
            {
                panel_user_order_details.Controls.Clear();
            }
            if (productsOrder != null)
            {
                foreach (var item in productsOrder)
                {
                    U_ProductParentOrder u = new U_ProductParentOrder();
                    u.PaintData(item);
                    panel_user_order_details.Controls.Add(u);
                }
            }
        }

        private void LoadRequestImages(int return_request_id)
        {
            List<ReturnRequestImgDTO> images = returnRequestManager.GetReturnRequestImgs(return_request_id);
            if (images != null)
            {
                foreach (var item in images)
                {
                    U_Image u = new U_Image();
                    u.PaintData(item);
                    panel_return_imgs.Controls.Add(u);
                }
            }
        }
    }
}
