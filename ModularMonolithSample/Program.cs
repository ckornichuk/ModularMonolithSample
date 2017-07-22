using Nancy.Hosting.Self;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolithSample
{
    class Program
    {
        private const string location = "http://localhost:8080";

        static HostConfiguration hostConfigs = new HostConfiguration()
        {
            UrlReservations = new UrlReservations() { CreateAutomatically = true }
        };

        static void Main(string[] args)
        {
            using (var host = new NancyHost(hostConfigs, new Uri(location)))
            {
                host.Start();
                Console.WriteLine($"Running on {location}");
                Console.ReadLine();
            }
        }
        
    }

    
}
