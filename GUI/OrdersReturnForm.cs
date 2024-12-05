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
        UserOrderDTO selectedUserOrder = null;
        public OrdersReturnForm()
        {
            InitializeComponent();
            LoadData(1);
            this.btn_accept.Visible = false;
            this.btn_reject.Visible = false;
            this.grd_order_cancle.CellClick += Grd_order_cancle_CellClick;
            this.panel_user_order_details.AutoScroll = true;
            load_cbo_order_status();
            cbo_return_type.SelectedIndexChanged += Cbo_return_type_SelectedIndexChanged;
            this.btn_accept.Click += Btn_accept_Click;
        }

        private async void Btn_accept_Click(object sender, EventArgs e)
        {
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
                if ((int) row.Cells["Status_id"].Value == 0 || row.Cells["Status_id"].Value == "Chưa xử lý")
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
        }

        public void LoadData(int request_type_id)
        {
            this.grd_order_cancle.AutoGenerateColumns = false;
            this.grd_order_cancle.Columns.Clear();
            this.grd_order_cancle.ScrollBars = ScrollBars.Both;
            // fit size
            this.grd_order_cancle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grd_order_cancle.DataSource = returnRequestManager.GetReturnRequest(request_type_id);

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
                        case "Chưa xử lý":
                            e.Value = "Chưa xử lý";
                            break;
                        case "Đã xử lý":
                            e.Value = "Đã xử lý";
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
    }
}
