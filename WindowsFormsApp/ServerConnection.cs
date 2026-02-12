using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class ServerConnection
    {
        private TcpClient _client;
        private StreamReader _reader;
        private StreamWriter _writer;

        public void connect()
        {
            _client = new TcpClient();
            _client.Connect("127.0.0.1", 2912);
            var stream = _client.GetStream();
            _reader = new StreamReader(stream);
            _writer = new StreamWriter(stream);
        }

        public string send(string message)
        {
            _writer.WriteLine(message);
            return _reader.ReadLine();
        }

        public void Close()
        {
            _reader.Close();
            _writer.Close();
            _client.Close();
        }
    }
}
