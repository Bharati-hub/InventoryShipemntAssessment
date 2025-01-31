
using InventoryShipmentManagementSystem.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InventoryShipmentManagementSystem.Services
{
    public class ShipmentService : IShipmentService 
    {
        private DataTable shipmentTable = new DataTable();

        public ShipmentService()
        {
            shipmentTable.Columns.Add("Product Name");
            shipmentTable.Columns.Add("Shipment Date");
            shipmentTable.Columns.Add("Status");
        }
        public DataTable GetShipmentTable()
        {
            return shipmentTable;
        }

        public void CreateShipment(string productName, DateTime shipmentDate, string status)
        {


            if (productName == null)
            {
                throw new ArgumentNullException(nameof(productName), "Product name cannot be null.");
            }

            if (string.IsNullOrEmpty(status) || (status != "Pending" && status != "Shipped" && status != "Delivered"))
            {
                throw new ArgumentException("Invalid status.", nameof(status));
            }
            shipmentTable.Rows.Add(productName, shipmentDate, status);

           
        }

        public void UpdateShipmentStatus(int rowIndex, string status)
        {
            if (rowIndex >= 0 && rowIndex < shipmentTable.Rows.Count)
            {
                DataRow row = shipmentTable.Rows[rowIndex];
                row["Status"] = status;
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid row index.");
            }



        }

    }
}
