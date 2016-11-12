using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
    class Server
    {
        private string serverName;
        public static List<String> serverList = new List<String>();

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

        public void AddServer()
        {
            serverList.Add(TheServer);
        }

        public List<String> ShowList()
        {
            return serverList;
        }
    }
}
