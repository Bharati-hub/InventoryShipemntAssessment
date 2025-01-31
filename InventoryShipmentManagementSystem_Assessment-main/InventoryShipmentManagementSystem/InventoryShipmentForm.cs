using InventoryShipmentManagementSystem.Interface;
using InventoryShipmentManagementSystem.Services;
using System;
using System.Data;
using System.Windows.Forms;
using static InventoryShipmentManagementSystem.Services.ProductAPIdata;

namespace InventoryShipmentManagementSystem
{
    public partial class InventoryShipment : Form
    {
        private readonly IProductService productService;
        private readonly IShipmentService shipmentService;
        private int index;
        DataTable dataTableLoad;
        public InventoryShipment(IProductService productService, IShipmentService shipmentService)
        {
            InitializeComponent();
            this.productService = productService;
            this.shipmentService = shipmentService;
            comboBoxShipment.DataSource = productService.GetProductTable();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadInventoryData();
            LoadShipmentData();
        }

        private void LoadInventoryData()
        {
            dataGridviewProduct.DataSource = productService.GetProductTable();
        }

        private void LoadShipmentData()
        {
            dataGridViewShipment.DataSource = shipmentService.GetShipmentTable();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                productService.InsertRecord(txtName.Text, int.Parse(txtQuantity.Text), double.Parse(txtPrice.Text));


                LoadInventoryData();
                MessageBox.Show(" Product record inserted successfully.");
                ClearProductFields();
            }

            catch (Exception)
            {
                MessageBox.Show("An error occurred: Invalid input");
            }
        }




        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearProductFields();
        }


        private void ClearProductFields()
        {
            txtName.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridviewProduct.SelectedRows.Count > 0)
                {
                    productService.UpdateRecord(dataGridviewProduct.SelectedRows[0].Index, txtName.Text, int.Parse(txtQuantity.Text), double.Parse(txtPrice.Text));
                    LoadInventoryData();
                    MessageBox.Show(" Prouct records updated");
                    ClearProductFields();
                }



            }
            catch (Exception)
            {
                MessageBox.Show("No records found");
            }
        }

        private void dataGridviewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            index = e.RowIndex;
            if (index >= 0 && index < dataGridviewProduct.Rows.Count)
            {
                DataGridViewRow row = dataGridviewProduct.Rows[index];

                txtName.Text = row.Cells[0].Value.ToString();
                txtQuantity.Text = row.Cells.Count > 1 ? row.Cells[1].Value.ToString() : "";
                txtPrice.Text = row.Cells.Count > 2 ? row.Cells[2].Value.ToString() : "";
            }
            else
            {
                MessageBox.Show("Invalid row index.");
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridviewProduct.CurrentCell != null)
                {
                    index = dataGridviewProduct.CurrentCell.RowIndex;

                    productService.DeleteRecord(index, dataGridviewProduct);

                    MessageBox.Show("Successfully removed");
                }
                else
                {
                    MessageBox.Show("No cell is currently selected.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No records found");
            }
        }

        private void btnCreateShipment_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxShipment.SelectedItem != null)
                {
                    string selectedProductName = ((DataRowView)comboBoxShipment.SelectedItem).Row.ItemArray[1].ToString();
                    shipmentService.CreateShipment(selectedProductName, DateTime.Parse(txtShipmentDate.Text), txtShipmentStatus.Text);
                }
                else
                {
                    shipmentService.CreateShipment(txtProductName.Text, DateTime.Parse(txtShipmentDate.Text), txtShipmentStatus.Text);
                }
                LoadShipmentData();
                MessageBox.Show("Shipment created successfully.");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred: Invalid input");
            }
        }

        private void txtShipmentStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateShipmentStatus_Click(object sender, EventArgs e)
        {
            try
            {
                shipmentService.UpdateShipmentStatus(
                    index,
                    txtShipmentStatus.Text
                );
                MessageBox.Show("Shipment status updated successfully.");
            }
            catch (Exception)
            {
                MessageBox.Show("No shipment records found");
            }

        }

        private void dataGridviewShipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0 && index < dataGridViewShipment.Rows.Count)
            {
                DataGridViewRow row = dataGridViewShipment.Rows[index];

                txtProductName.Text = row.Cells[0].Value.ToString();
                txtShipmentDate.Text = row.Cells[1].Value.ToString();
                txtShipmentStatus.Text = row.Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("Invalid row index.");
            }

        }

        private void  btnLoad_Click(object sender, EventArgs e)
        {


            ProductShipmentLoad apiload = new ProductShipmentLoad();
            dataTableLoad = apiload.LoadAPIs().Result;
            dataGridviewProduct.DataSource = dataTableLoad;


   
        }

        private void comboBoxShipment_Click(object sender, EventArgs e)
        {


            ProductShipmentLoad apiload = new ProductShipmentLoad();
            dataTableLoad = apiload.LoadAPIs().Result;
            comboBoxShipment.DataSource = dataTableLoad;
            comboBoxShipment.DisplayMember = "Name";
            comboBoxShipment.ValueMember = "Name";
        }
    }
}
