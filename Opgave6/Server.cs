using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FanLibrary;
using Newtonsoft.Json;


namespace Opgave6
{
    public class Server
    {
        private static int totaltConnectionNo = 0;
        public void ServerStart()
        {
            int clientNo = 0;
            TcpClient connectionSocket;
            Thread.CurrentThread.Name = "Main";
            IPAddress localIpAddress = IPAddress.Parse("127.0.0.1");
            TcpListener serverSocket = new TcpListener(localIpAddress,4646);
            serverSocket.Start();
            TaskFactory taskFactory = new TaskFactory();
            Console.WriteLine("server activated");
            while (true)
            {
                connectionSocket = serverSocket.AcceptTcpClient();
                clientNo++;
                totaltConnectionNo++;
                taskFactory.StartNew(() => DoClient(connectionSocket, clientNo));
            }

        }



        private void DoClient(TcpClient connection, int clientno)
        {
            //TcpListener server = null;
            try
            {

                //Int32 port = 4646;
                //IPAddress localIpAddress = IPAddress.Parse("127.0.0.1");

                //server = new TcpListener(localIpAddress, port);

                //server.Start();

                Byte[] bytes = new byte[256];
                String Data = null;

                while (true)
                {
                    Console.WriteLine("Waiting for Connection....");

                    //TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");
                    
                    Data = null;
                    
                    NetworkStream stream = connection.GetStream();
                   
                    
                    int i;

                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                       
                        {
                        
                            
                        Data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        Console.WriteLine("Received: {0}", Data );
                        

                        Data = Data.ToUpper();
                        
                        string mystring = Data.Replace("\r\n", string.Empty);

                        string[] sArray = mystring.Split(" ");

                        string statement = sArray[0];

                        


                        switch (statement)
                        {

                            case "HENTALLE":
                                foreach (var fandata in FanList.datalist)
                                {
                                    byte[] message = System.Text.Encoding.ASCII.GetBytes(fandata.ToString() + "\n");
                                    stream.Write(message, 0, message.Length);
                                    Console.WriteLine("Sent: {0}", fandata);
                                    
                                }
                                break;

                            case "HENT":
                                
                                int id = int.Parse(sArray[1]);
                                foreach (var fandata in FanList.datalist)
                                {
                                    if (fandata.Id == id)
                                    {
                                        byte[] message = System.Text.Encoding.ASCII.GetBytes(fandata.ToString() + "\n");
                                        stream.Write(message, 0, message.Length);
                                        Console.WriteLine("Sent: {0}", fandata);
                                    }

                                    
                                    
                                }
                                break;

                            case "GEM":
                                double grader = double.Parse(sArray[2]);
                                double fugt = double.Parse(sArray[3]);
                                FanOutput addFanOutput = new FanOutput(navn: sArray[1], grader: grader, fugt: fugt);
                                FanList.datalist.Add(addFanOutput);
                                break;
                                
                                
                        }


                        
                    }


                    connection.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);

            }

            finally
            {
                connection.Close();
                totaltConnectionNo--;

            }

            Console.WriteLine("\nPress enter to continue");
            Console.Read();

        }
    }
}
