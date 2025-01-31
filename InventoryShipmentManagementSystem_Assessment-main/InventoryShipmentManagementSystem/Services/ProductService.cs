
using InventoryShipmentManagementSystem.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryShipmentManagementSystem.Services
{
    public class ProductService : IProductService
    {
        private DataTable table = new DataTable();

        public ProductService()
        {
            table.Columns.Add("Name");
            table.Columns.Add("Quantity");
            table.Columns.Add("Price");
        }
        
        public DataTable GetProductTable()
        {
            return table;
        }

        

        public void InsertRecord(string name, int quantity, double price)
        {


            if (name == null)
            {
                throw new ArgumentNullException(nameof(name), "Product name cannot be null.");
            }

            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity cannot be negative.");
            }

            if (price < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(price), "Price cannot be negative.");
            }
            table.Rows.Add(name, quantity, price);
        }

        public void UpdateRecord(int rowIndex,string name, int quantity, double price)
        {


            if (name == null)
            {
                throw new ArgumentNullException(nameof(name), "Name cannot be null.");
            }

            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity cannot be negative.");
            }

            if (price < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(price), "Price cannot be negative.");
            }

            if (rowIndex < 0 || rowIndex >= table.Rows.Count)
            {
                throw new IndexOutOfRangeException("Invalid row index.");
            }

            DataRow row = table.Rows[rowIndex];
                row["Name"] = name;
                row["Quantity"] = quantity;
                row["Price"] = price;
            
            
        }

        public void DeleteRecord(int rowIndex, DataGridView dataGridViewInventory = null)
        {
            if (dataGridViewInventory != null)
            {
                if (rowIndex >= 0 && rowIndex < dataGridViewInventory.Rows.Count)
                {
                    dataGridViewInventory.Rows.RemoveAt(rowIndex);
                }
            }
            else
            {
                if (rowIndex >= 0 && rowIndex < table.Rows.Count)
                {
                    table.Rows.RemoveAt(rowIndex);
                }

                else
                {
                    throw new InvalidOperationException("Both dataGridViewInventory and table are null.");
                }
            }


        }


    }
}
