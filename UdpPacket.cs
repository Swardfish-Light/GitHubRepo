using System.Net;

namespace ArtNetManager
{
    public class UdpPacket
    {
        public IPEndPoint EndPoint { get; set; }
        public byte[] RawData { get; set; }
        public long Index { get; set; }
        public long ElapsedMiliseconds { get; set; }

        public UdpPacket(IPEndPoint endPoint, byte[] data, long index, long elapsedMiliseconds)
        {
            EndPoint = endPoint;
            RawData = data;
            this.Index = index;
            this.ElapsedMiliseconds = elapsedMiliseconds;
        }

        public UdpPacket(IPEndPoint endPoint, byte[] data) : this(endPoint, data, 0, 0)
        {
        }
        public UdpPacket(UdpPacket packet) : this(packet.EndPoint, packet.RawData, packet.Index, packet.ElapsedMiliseconds)
        {
        }
    }
}
