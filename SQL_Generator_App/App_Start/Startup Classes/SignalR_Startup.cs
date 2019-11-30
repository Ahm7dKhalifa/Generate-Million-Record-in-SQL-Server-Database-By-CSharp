using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SQL_Generator_App.App_Start.Startup_Classes.SignalR_Startup))]

namespace SQL_Generator_App.App_Start.Startup_Classes
{
    public class SignalR_Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}
