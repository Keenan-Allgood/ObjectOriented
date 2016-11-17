using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
    public class Server
    {   //FIX THIS
        //The restaurant objects would hold the list of servers (as well as the table and waitlistgroup lists) and not the server object.  The server object
        //for iteration one will only hold the serverName (for now) --Darrin
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


        public override string ToString()
        {
            return TheServer;
        }
    }
}
