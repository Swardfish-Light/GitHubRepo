using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace ArtNetManager
{
    public class UdpCommunicator
    {
        public event EventHandler<UdpPacket> DataReceived;

        public IPAddress Address { get; set; }
        public int Port { get; set; }

        UdpClient socket;
        BackgroundWorker server;

        long PacketCount { get; set; }
        Stopwatch PacketClock { get; set; }

        public UdpCommunicator(IPAddress address, int port)
        {
            this.Address = address;
            this.Port = port;

            PacketCount = 0;
        }

        public void Start()
        {
            socket = new UdpClient();
            socket.EnableBroadcast = true;
            socket.ExclusiveAddressUse = false;
            socket.Client.SendTimeout = 100;
            socket.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            socket.Client.Bind(new IPEndPoint(Address, Port));

            server = new BackgroundWorker();
            server.DoWork += Server_DoWork;
            server.RunWorkerAsync();
        }

        public void Stop()
        {
            server.CancelAsync();
            socket.Close();
        }

        public void Send(byte[] datagram, int bytes, IPEndPoint endPoint)
        {
            socket.SendAsync(datagram, bytes, endPoint);
        }

        void Server_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!server.CancellationPending)
            {
                var client = new IPEndPoint(IPAddress.Any, 0);
                var data = socket.Receive(ref client);

                if (DataReceived != null)
                {
                    UdpPacket packet = new UdpPacket(client, data);

                    if (PacketCount++ == 0)
                    {
                        packet.Index = 0;
                        packet.ElapsedMiliseconds = 0;
                    }
                    else
                    {
                        PacketClock.Stop();
                        packet.ElapsedMiliseconds = PacketClock.ElapsedMilliseconds;
                        packet.Index = PacketCount;
                    }

                    DataReceived(this, packet);

                    PacketClock = Stopwatch.StartNew();
                }
            }
        }

        public static List<ArtNetInterface> GetNetworkInterfaces()
        {
            List<ArtNetInterface> nics;

            nics = new List<ArtNetInterface>();

            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                foreach (UnicastIPAddressInformation ip in adapterProperties.UnicastAddresses)
                {
                    if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        ArtNetInterface nic = new ArtNetInterface();
                        nic.name = adapter.Name;
                        nic.ip = ip.Address.ToString();
                        nic.status = adapter.NetworkInterfaceType.ToString();
                        nics.Add(nic);
                    }
                }
            }
            return nics;
        }
    }
}