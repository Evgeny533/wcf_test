using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ConsoleApp4
{
    class Server
    {
        static void Main(string[] args)
        {
            Uri addres = new Uri("http://localhost:4000/IContract");
            BasicHttpBinding binding = new BasicHttpBinding();
            Type contract = typeof(IContract);

            ServiceHost host = new ServiceHost(typeof(Service));

            host.AddServiceEndpoint(contract, binding, addres);

            host.Open();

            //бесконечная работа
            while(true)
            {

            }
            //host.Close();
        }
    }
}
