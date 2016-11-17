using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
    public class Server
    {   
        private string serverName;

        public Server()
        {

        }

        public Server(string TheServer)
        {
            this.serverName = TheServer;
        }

        public string TheServer
        {
            get { return serverName; }
            set { serverName = value; }
        }

        public override string ToString()
        {
            return TheServer;
        }
    }
}
