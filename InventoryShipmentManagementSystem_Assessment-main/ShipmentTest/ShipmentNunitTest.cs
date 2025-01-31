using InventoryShipmentManagementSystem.Services;
using System.Data;

namespace ShipmentTest
{
    public class Tests
    {

        [TestFixture]
        public class ShipmentServiceTests
        {
            private ShipmentService shipmentService;

            [SetUp]
            public void Setup()
            {
                shipmentService = new ShipmentService();
            }

            [Test]
            public void CreateShipment_ShouldAddShipmentToTable()
            {
                // Arrange
                string expectedProductName = "Product1";
                DateTime expectedShipmentDate = DateTime.Now;
                string expectedStatus = "Shipped";

                // Act
                shipmentService.CreateShipment(expectedProductName, expectedShipmentDate, expectedStatus);
                DataTable table = shipmentService.GetShipmentTable();
                DataRow insertedRow = table.Rows[0];

                // Assert
                Assert.AreEqual(expectedProductName, insertedRow["Product Name"]);
                Assert.AreEqual(expectedShipmentDate.ToString("yyyy-MM-dd HH:mm:ss"), DateTime.Parse(insertedRow["Shipment Date"].ToString()).ToString("yyyy-MM-dd HH:mm:ss"));
                Assert.AreEqual(expectedStatus, insertedRow["Status"]);
            }

            [Test]
            public void UpdateShipmentStatus_ShouldModifyShipmentStatus()
            {
                // Arrange
                string initialProductName = "Product1";
                DateTime initialShipmentDate = DateTime.Now;
                string initialStatus = "Pending";
                string updatedStatus = "Delivered";

                // Act
                shipmentService.CreateShipment(initialProductName, initialShipmentDate, initialStatus);
                shipmentService.UpdateShipmentStatus(0, updatedStatus);

                DataTable table = shipmentService.GetShipmentTable();
                DataRow updatedRow = table.Rows[0];

                // Assert
                Assert.AreEqual(updatedStatus, updatedRow["Status"]);
            }

            [Test]
            public void CreateShipment_ShouldThrowException_WhenProductNameIsNull()
            {
                // Arrange
                string expectedProductName = null;
                DateTime expectedShipmentDate = DateTime.Now;
                string expectedStatus = "Shipped";

                // Act & Assert
                Assert.Throws<ArgumentNullException>(() => shipmentService.CreateShipment(expectedProductName, expectedShipmentDate, expectedStatus));
            }

            [Test]
            public void CreateShipment_ShouldThrowException_WhenStatusIsInvalid()
            {
                // Arrange
                string expectedProductName = "Product1";
                DateTime expectedShipmentDate = DateTime.Now;
                string expectedStatus = "InvalidStatus";

                // Act & Assert
                Assert.Throws<ArgumentException>(() => shipmentService.CreateShipment(expectedProductName, expectedShipmentDate, expectedStatus));
            }

            [Test]
            public void CreateShipment_ShouldAddShipmentWithCurrentDateTime()
            {
                // Arrange
                string expectedProductName = "Product1";
                DateTime expectedShipmentDate = DateTime.Now;
                string expectedStatus = "Shipped";
                DateTime beforeInsert = DateTime.Now;

                // Act
                shipmentService.CreateShipment(expectedProductName, expectedShipmentDate, expectedStatus);
                DataTable table = shipmentService.GetShipmentTable();
                DataRow insertedRow = table.Rows[0];
                DateTime recordDateTime = DateTime.Parse(insertedRow["Shipment Date"].ToString());

                // Assert
                Assert.AreEqual(expectedProductName, insertedRow["Product Name"]);
                Assert.AreEqual(expectedStatus, insertedRow["Status"]);
                Assert.IsTrue(recordDateTime >= beforeInsert.AddSeconds(-1) && recordDateTime <= DateTime.Now.AddSeconds(1));
            }
        }
        
    }
        
    }