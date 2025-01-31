using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryShipmentManagementSystem.Interface
{
    public interface IShipmentService
    {
        DataTable GetShipmentTable();
        void CreateShipment(string productName, DateTime shipmentDate, string status);
        void UpdateShipmentStatus(int rowIndex, string status);
    }
}
