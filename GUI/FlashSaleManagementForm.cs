using LibDTO;
using LibBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Nike_Shop_Management.GUI
{
    public partial class FlashSaleManagementForm : Form
    {
        private FlashSaleManager flashSaleManager;

        public FlashSaleManagementForm()
        {
            InitializeComponent();
            flashSaleManager = new FlashSaleManager();
            LoadFlashSale();
        }

        private void LoadFlashSale()
        {
            try
            {
                // Fetch and bind flash sale data to the grid
                List<FlashSaleDTO> flashSales = flashSaleManager.GetAll();
                kryptonDataGridView1.DataSource = flashSales;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading flash sales: {ex.Message}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtFlashSaleName.Text))
            {
                MessageBox.Show("Please enter the flash sale name!");
                return;
            }

            if (txtFlashSaleName.Text.Length > 20)
            {
                MessageBox.Show("Flash sale name is too long!");
                return;
            }

            if (pickerStartAt.Value > pickerEndAt.Value)
            {
                MessageBox.Show("Start time must be earlier than the end time!");
                return;
            }

            // Disable the button to prevent duplicate submissions
            if (!backgroundWorker1.IsBusy)
            {
                btnAdd.Enabled = false;
                backgroundWorker1.RunWorkerAsync();
               
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                // Prepare the new flash sale data
                FlashSaleDTO flashSale = new FlashSaleDTO();
                flashSale.flash_sale_name = txtFlashSaleName.Text;
                flashSale.thumbnail = null;// Update if you plan to add thumbnail functionality
                flashSale.status = "waiting";
                flashSale.start_at = pickerStartAt.Value.ToUniversalTime();
                flashSale.end_at = pickerEndAt.Value.ToUniversalTime();
/*                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow*/


                // Save the flash sale via the manager
                int result = flashSaleManager.Add(flashSale);
                e.Result = result; // Pass the result to RunWorkerCompleted
            }
            catch (Exception ex)
            {
                e.Result = ex; // Pass the exception to RunWorkerCompleted
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Re-enable the button
            btnAdd.Enabled = true;

            if (e.Result is Exception ex)
            {
                MessageBox.Show($"Error adding flash sale: {ex.Message}");
                return;
            }

            int flag = (int)e.Result;

            if (flag == 0)
            {
                MessageBox.Show("Failed to add flash sale!");
            }
            else
            {
                MessageBox.Show("Flash sale added successfully!");
                LoadFlashSale(); // Refresh the grid
            }
        }
    }
}
