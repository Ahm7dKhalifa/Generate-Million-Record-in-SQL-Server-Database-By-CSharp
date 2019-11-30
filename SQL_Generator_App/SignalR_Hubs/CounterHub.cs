using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SQL_Generator_App.SignalR_Hubs
{
    public class CounterHub : Hub
    {
        public void DisplayCounter(int counter)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<CounterHub>();
            context.Clients.All.displayCounter(counter);
        }

        public override Task OnConnected()
        {
           

            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
          

            return base.OnDisconnected(stopCalled);
        }

        public override Task OnReconnected()
        {
           

            return base.OnReconnected();
        }
    }
}