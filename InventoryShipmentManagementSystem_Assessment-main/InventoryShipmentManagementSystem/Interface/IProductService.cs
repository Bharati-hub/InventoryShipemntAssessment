using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryShipmentManagementSystem.Interface
{
    public interface IProductService
    {
        DataTable GetProductTable();
        void InsertRecord(string name, int quantity, double price);
        void UpdateRecord(int rowIndex,string name, int quantity, double price);
        void DeleteRecord(int rowIndex, DataGridView dataGridViewInventory = null);
    }
}
