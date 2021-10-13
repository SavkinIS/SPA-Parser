using Microsoft.AspNetCore.SignalR;
using SPAParser.Server.DataFolder;
using SPAParser.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPAParser.Server.Hubs
{
    public class CollectionHub : Hub
    {
        Data data = new Data();

        public async Task SendMessage(Product? product)
        {
            if (product != null)
            {
                data.AddProduct(product);

            }

            //data.GetProducts()
            var col = data.GetProducts().ToList<Product>();
            await Clients.All.SendAsync("ReceiveMessage", col);
        }
    }
}
