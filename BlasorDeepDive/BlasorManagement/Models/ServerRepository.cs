namespace BlasorManagement.Models
{
    public static class ServerRepository
    {

        private static List<Server> servers = new List<Server>()
        {
            new Server {Id =1, Name="Server 1", City="Toronto" },
            new Server {Id =2, Name="Server 2", City="Trani" },
            new Server {Id =3, Name="Server 3", City="Bergamo" },
            new Server {Id =4, Name="Server 4", City="Sicilia" },
            new Server {Id =5, Name="Server 5", City="Lombardia" },
            new Server {Id =6, Name="Server 6", City="Ancona" },
            new Server {Id =7, Name="Server 7", City="Andria" },
            new Server {Id =8, Name="Server 8", City="Trani" },
            new Server {Id =9, Name="Server 9", City="Mola" },
            new Server {Id =10, Name="Server 10", City="Molfetta" },
            new Server {Id =11, Name="Server 11", City="Leuca" },
            new Server {Id =12, Name="Server 12", City="Taranto" },
            new Server {Id =13, Name="Server 13", City="Foggia" },
            new Server {Id =14, Name="Server 14", City="Cerignola" },
            new Server {Id =15, Name="Server 15", City="Andria" }

        };

        public static void AddServer(Server server) {
            // trovo il valore massimo all' interno della lista
            var maxId = servers.Max(s => s.Id);
            server.Id = maxId + 1;
            servers.Add(server);
        }


        public static List<Server> SearchServers(string serverFilter) {
            if (string.IsNullOrEmpty(serverFilter))
            {
                return new List<Server>();
            }
            else {
                // controlla che ogni server presente all' interno della lista serverFilter presentre nel nome non considerando le differenze di caratteri.
                return servers.Where(s => s.Name.Contains(serverFilter, StringComparison.OrdinalIgnoreCase)).ToList();
            }
           
        }

        public static List<Server> GetServers() {
            return servers;
        }

        public static List<Server> GetServersByCity(string cityName)
        {
            if (cityName != null)
            {
                return servers.Where(s => s.City!.Equals(cityName, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            return new List<Server>();
        }



        public static Server? GetServersById(int Id)
        {
            var server = servers.FirstOrDefault(s => s.Id == Id);
            
            if (server!= null){
                return server;
            }
            return null;
        }

        public static bool UpdateServer(Server server)
        {
            var index = servers.IndexOf(server);
            if (index != -1)
            {
                servers[index] = server;
                return true;
            }
            return false;
        }

        public static bool DelateServer (int id)
        {
            var server = servers.FirstOrDefault(s => s.Id == id);
            if (server != null)
            {
                servers.Remove(server);
                return true;
            }
            return false;
        }
    }
}
