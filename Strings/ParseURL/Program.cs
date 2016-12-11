using System;

namespace ParseURL
{
    class Program
    {
        static void Main()
        {
            string address = Console.ReadLine();

            int indexOfProtocol = address.IndexOf("://");
            
            string protocol = address.Substring(0, indexOfProtocol);
            
            int indexEndServer = address.IndexOf("/", indexOfProtocol + 3);
            
            string server = address.Substring(indexOfProtocol + 3, indexEndServer - indexOfProtocol - 3);
            
            string resource = address.Substring(indexEndServer);

            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
