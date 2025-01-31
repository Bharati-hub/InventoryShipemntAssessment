using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryShipmentManagementSystem.Services
{
    public class ProductShipmentLoad
    {

        public async Task<DataTable> LoadAPIs()
        {



            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7156/api/Product");
            
            HttpResponseMessage response = await client.GetAsync("").ConfigureAwait(false);
            var data = await response.Content.ReadAsStringAsync();
            var dataSet = JsonConvert.DeserializeObject<ProductAPIdata[]>(data);

            DataTable dataTable = new DataTable();
           
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Quantity",typeof(string));
            dataTable.Columns.Add("Price", typeof(string));

            foreach (var item in dataSet)
            {
                dataTable.Rows.Add(item.Name, item.Quantity,item.Price);
            }

            return dataTable;
        }
    }
}

        
    

