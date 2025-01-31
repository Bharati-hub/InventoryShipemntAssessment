using InventoryShipmentManagementSystem.Interface;
using InventoryShipmentManagementSystem.Services;
using System;
using System.Windows.Forms;
//using InventoryShipmentManagementSystem.Forms;

namespace InventoryShipmentManagementSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IProductService productService = new ProductService();
            IShipmentService shipmentService = new ShipmentService();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new InventoryShipment(productService, shipmentService));
        }
    }
}