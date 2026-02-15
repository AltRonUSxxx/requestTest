using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace server
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 2912);
            listener.Start();

            Console.WriteLine("=== Server start ===");
            Console.WriteLine("Works on 127.0.0.1:2912");

            while(true)
            {
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine("New client");
                //Task.Run(() => HandleClient(client));
                _ = HandleClientAsync(client);
            }
        }

        static async Task HandleClientAsync(TcpClient client)
        {
            try
            {
                using (NetworkStream stream = client.GetStream())
                using (StreamReader reader = new StreamReader(stream))
                using (StreamWriter writer = new StreamWriter(stream) {AutoFlush = true})
                {
                    while (true)
                    {
                        string request = await reader.ReadLineAsync();
                        string[] arguments = request.Split('|');
                        Console.WriteLine($"READ: {request}");
                        if(request == null)
                        {
                            Console.WriteLine("Client disconnected");
                            break;
                        }
                        if (request.StartsWith("LOGIN"))
                        {
                            string result = await AuthService.loginAsync(arguments[1], arguments[2]);
                            await writer.WriteLineAsync(result);
                        }
                        else if(request.StartsWith("REG"))
                        {
                            string result = await AuthService.registerAsync(arguments[1], arguments[2], arguments[3]);
                            await writer.WriteLineAsync(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()); 
            }
            finally
            {
                client.Close();
            }
        }
    }
}
