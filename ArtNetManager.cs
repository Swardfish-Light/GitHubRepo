using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;

namespace ArtNetManager
{
    public class ArtNetManager
    {
        private String ShortName { get; set; }
        private String LongName { get; set; }
        private const String SHORT_NAME = "ArtNetManager";

        public UdpCommunicator communicator;
        private const int DEFAULT_PORT = 6454;

        public Boolean VerboseMode { get; set; }
        public Boolean RecordMode { get; set; }

        public Boolean PauseMode { get; set; }

        public List<ArtNetNode> Nodes { get; set; }

        public event EventHandler<ArtNetPacket> RecorderDataReceived;
        public event EventHandler<ArtNetPacket> DebugDataReceived;

        public ArtNetManager(String shortName, String longName)
        {
            this.ShortName = shortName.Substring(0, Math.Min(18, shortName.Length));
            this.LongName = shortName.Substring(0, Math.Min(64, shortName.Length));
            Nodes = new List<ArtNetNode>();
        }

        public ArtNetManager(String shortName) : this(shortName, shortName)
        {
        }
        public ArtNetManager() : this(SHORT_NAME, SHORT_NAME)
        {
        }

        public void Start(IPAddress address, int port)
        {
            communicator = new UdpCommunicator(address, port);
            communicator.DataReceived += Communicator_DataReceived;
            communicator.Start();

            SendArtPollReply();

            PauseMode = false;
        }

        public void Start(IPAddress address)
        {
            Start(address, DEFAULT_PORT);
        }

        public void Start()
        {
            Start(IPAddress.Any, DEFAULT_PORT);
        }

        void Communicator_DataReceived(object sender, UdpPacket packet)
        {

            if (PauseMode)
                return;

            var artNetPacket = new ArtNetPacket(packet);
            if (artNetPacket.IsValid)
            {
                if (artNetPacket.IsDMXPacket)
                {
                    int universe = artNetPacket.Universe;
                    int net = artNetPacket.Net;
                    int subnet = artNetPacket.SubNet;

                    if (Nodes.Count > 0)
                    {
                        foreach (ArtNetNode node in Nodes)
                        {
                            if (node.AddressValid(net, subnet, universe))
                            {
                                for (int i = 0; i < 170; i++)
                                {
                                    Color rgbColor = new Color();

                                    Byte R = artNetPacket.RawData[18 + i * 3];
                                    Byte G = artNetPacket.RawData[18 + i * 3 + 1];
                                    Byte B = artNetPacket.RawData[18 + i * 3 + 2];
                                    rgbColor = Color.FromArgb(R, G, B);

                                    (node.Ports[universe]).RgbData[i] = rgbColor;
                                }
                            }
                        }
                    }

                    if (RecordMode)
                        RecorderDataReceived(this, artNetPacket);
                }
                else
                {
                    if (artNetPacket.IsPollPacket)
                    {
                        SendArtPollReply();
                    }
                }
                if (VerboseMode)
                {
                    DebugDataReceived(this, artNetPacket);
                }
            }
        }
        private void SendArtPollReply()
        {
            IPEndPoint localEndPoint = new IPEndPoint(communicator.Address, communicator.Port);
            if (localEndPoint.Equals(new IPEndPoint(IPAddress.Any, communicator.Port)))
            {
                localEndPoint = new IPEndPoint(IPAddress.Parse("255.255.255.255"), communicator.Port);
            }

            IPEndPoint targetEndPoint = new IPEndPoint(IPAddress.Parse("255.255.255.255"), communicator.Port);

            foreach (ArtNetNode node in Nodes)
            {
                for (int i = 0; i < node.Ports.Count; i++)
                {
                    ArtPollReplyPacket pollReplyPacket = new ArtPollReplyPacket(localEndPoint, node, 0); // to change so response is sent per port
                    communicator.Send(pollReplyPacket.RawData, pollReplyPacket.RawData.Length, targetEndPoint);
                }
            }
        }
    }
}
