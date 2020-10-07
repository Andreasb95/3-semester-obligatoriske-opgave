using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using FanLibrary;
using Newtonsoft.Json;

namespace Opgave6
{
    class Program
    {

        static void Main(string[] args)
        {
            Server newServer = new Server();

            newServer.ServerStart();
        }

    }
}
