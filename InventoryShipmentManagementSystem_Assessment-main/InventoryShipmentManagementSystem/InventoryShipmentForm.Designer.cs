

namespace InventoryShipmentManagementSystem
{
    partial class InventoryShipment
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlMain = new TabControl();
            tabProductInventory = new TabPage();
            btnLoad = new Button();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtName = new TextBox();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblName = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnInsert = new Button();
            dataGridviewProduct = new DataGridView();
            tabShipment = new TabPage();
            comboBoxShipment = new ComboBox();
            txtShipmentDate = new DateTimePicker();
            txtShipmentStatus = new TextBox();
            lblProductName = new Label();
            txtProductName = new TextBox();
            lblStatus = new Label();
            lblShipmentDate = new Label();
            btnUpdateShipmentStatus = new Button();
            btnCreateShipment = new Button();
            dataGridViewShipment = new DataGridView();
            tabControlMain.SuspendLayout();
            tabProductInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridviewProduct).BeginInit();
            tabShipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShipment).BeginInit();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabProductInventory);
            tabControlMain.Controls.Add(tabShipment);
            tabControlMain.Location = new Point(50, 43);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(665, 368);
            tabControlMain.TabIndex = 0;
            // 
            // tabProductInventory
            // 
            tabProductInventory.Controls.Add(btnLoad);
            tabProductInventory.Controls.Add(txtPrice);
            tabProductInventory.Controls.Add(txtQuantity);
            tabProductInventory.Controls.Add(txtName);
            tabProductInventory.Controls.Add(lblPrice);
            tabProductInventory.Controls.Add(lblQuantity);
            tabProductInventory.Controls.Add(lblName);
            tabProductInventory.Controls.Add(btnDelete);
            tabProductInventory.Controls.Add(btnUpdate);
            tabProductInventory.Controls.Add(btnClear);
            tabProductInventory.Controls.Add(btnInsert);
            tabProductInventory.Controls.Add(dataGridviewProduct);
            tabProductInventory.Location = new Point(4, 24);
            tabProductInventory.Name = "tabProductInventory";
            tabProductInventory.Padding = new Padding(3);
            tabProductInventory.Size = new Size(657, 340);
            tabProductInventory.TabIndex = 0;
            tabProductInventory.Text = "Product Inventory";
            tabProductInventory.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(457, 214);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 11;
            btnLoad.Text = "Get Data";
            btnLoad.UseVisualStyleBackColor = true;
           btnLoad.Click += btnLoad_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(74, 91);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 10;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(74, 57);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(74, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 8;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(6, 94);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(6, 60);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Quantity";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 5;
            lblName.Text = "Name";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(362, 123);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(281, 123);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(200, 123);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(119, 123);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // dataGridviewProduct
            // 
            dataGridviewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridviewProduct.Location = new Point(68, 172);
            dataGridviewProduct.Name = "dataGridviewProduct";
            dataGridviewProduct.Size = new Size(240, 150);
            dataGridviewProduct.TabIndex = 0;
            dataGridviewProduct.CellClick += dataGridviewProduct_CellClick;
            // 
            // tabShipment
            // 
            tabShipment.Controls.Add(comboBoxShipment);
            tabShipment.Controls.Add(txtShipmentDate);
            tabShipment.Controls.Add(txtShipmentStatus);
            tabShipment.Controls.Add(lblProductName);
            tabShipment.Controls.Add(txtProductName);
            tabShipment.Controls.Add(lblStatus);
            tabShipment.Controls.Add(lblShipmentDate);
            tabShipment.Controls.Add(btnUpdateShipmentStatus);
            tabShipment.Controls.Add(btnCreateShipment);
            tabShipment.Controls.Add(dataGridViewShipment);
            tabShipment.Location = new Point(4, 24);
            tabShipment.Name = "tabShipment";
            tabShipment.Padding = new Padding(3);
            tabShipment.Size = new Size(657, 340);
            tabShipment.TabIndex = 1;
            tabShipment.Text = "Shipment";
            tabShipment.UseVisualStyleBackColor = true;
            // 
            // comboBoxShipment
            // 
            comboBoxShipment.FormattingEnabled = true;
            comboBoxShipment.Location = new Point(115, 6);
            comboBoxShipment.Name = "comboBoxShipment";
            comboBoxShipment.Size = new Size(200, 23);
            comboBoxShipment.TabIndex = 12;
            comboBoxShipment.Click += comboBoxShipment_Click;
            // 
            // txtShipmentDate
            // 
            txtShipmentDate.Location = new Point(115, 40);
            txtShipmentDate.Name = "txtShipmentDate";
            txtShipmentDate.Size = new Size(200, 23);
            txtShipmentDate.TabIndex = 11;
            // 
            // txtShipmentStatus
            // 
            txtShipmentStatus.Location = new Point(115, 74);
            txtShipmentStatus.Name = "txtShipmentStatus";
            txtShipmentStatus.Size = new Size(200, 23);
            txtShipmentStatus.TabIndex = 10;
            txtShipmentStatus.TextChanged += txtShipmentStatus_TextChanged;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(25, 9);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(84, 15);
            lblProductName.TabIndex = 7;
            lblProductName.Text = "Product Name";
            lblProductName.Click += label1_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(442, 9);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(100, 23);
            txtProductName.TabIndex = 6;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(48, 77);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            // 
            // lblShipmentDate
            // 
            lblShipmentDate.AutoSize = true;
            lblShipmentDate.Location = new Point(24, 44);
            lblShipmentDate.Name = "lblShipmentDate";
            lblShipmentDate.Size = new Size(85, 15);
            lblShipmentDate.TabIndex = 3;
            lblShipmentDate.Text = "Shipment Date";
            // 
            // btnUpdateShipmentStatus
            // 
            btnUpdateShipmentStatus.Location = new Point(338, 116);
            btnUpdateShipmentStatus.Name = "btnUpdateShipmentStatus";
            btnUpdateShipmentStatus.Size = new Size(66, 23);
            btnUpdateShipmentStatus.TabIndex = 2;
            btnUpdateShipmentStatus.Text = "Update";
            btnUpdateShipmentStatus.UseVisualStyleBackColor = true;
            btnUpdateShipmentStatus.Click += btnUpdateShipmentStatus_Click;
            // 
            // btnCreateShipment
            // 
            btnCreateShipment.Location = new Point(211, 116);
            btnCreateShipment.Name = "btnCreateShipment";
            btnCreateShipment.Size = new Size(80, 23);
            btnCreateShipment.TabIndex = 1;
            btnCreateShipment.Text = "Insert";
            btnCreateShipment.UseVisualStyleBackColor = true;
            btnCreateShipment.Click += btnCreateShipment_Click;
            // 
            // dataGridViewShipment
            // 
            dataGridViewShipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewShipment.Location = new Point(72, 163);
            dataGridViewShipment.Name = "dataGridViewShipment";
            dataGridViewShipment.Size = new Size(240, 150);
            dataGridViewShipment.TabIndex = 0;
            dataGridViewShipment.CellClick += dataGridviewShipment_CellClick;
            // 
            // InventoryShipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlMain);
            Name = "InventoryShipment";
            Text = "InventoryShipment";
            Load += MainForm_Load;
            tabControlMain.ResumeLayout(false);
            tabProductInventory.ResumeLayout(false);
            tabProductInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridviewProduct).EndInit();
            tabShipment.ResumeLayout(false);
            tabShipment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShipment).EndInit();
            ResumeLayout(false);
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private TabControl tabControlMain;
        private TabPage tabProductInventory;
        private TabPage tabShipment;
        private DataGridView dataGridviewProduct;
        private Button btnUpdateShipmentStatus;
        private Button btnCreateShipment;
        private DataGridView dataGridViewShipment;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnInsert;
        private Label lblQuantity;
        private Label lblName;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtName;
        private Label lblPrice;
        private TextBox txtProductName;
        private Label lblStatus;
        private Label lblShipmentDate;
        private TextBox txtShipmentStatus;
        private Label lblProductName;
        private DateTimePicker txtShipmentDate;
        private Button btnLoad;
        private ComboBox comboBoxShipment;
    }
}
