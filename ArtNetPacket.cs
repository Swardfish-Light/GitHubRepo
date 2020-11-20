using System.Linq;

namespace ArtNetManager
{
    public class ArtNetPacket : UdpPacket
    {
        public const ushort OP_POLL = 0x2000; //This is an ArtPoll packet, no other data is contained in this UDP packet
        public const ushort OP_POLL_REPLY = 0x2100; //This is an ArtPollReply Packet. It contains device status information.
        public const ushort OP_DMX = 0x5000; //This is an ArtDmx data packet.It contains zero start code DMX512 information for a single Universe.

        static public readonly byte[] ARTNETID = { 0x41, 0x72, 0x74, 0x2d, 0x4e, 0x65, 0x74, 0 };

        public ArtNetPacket(UdpPacket packet) : base(packet) { }

        public int OpCode { get { return RawData.GetInt16LE(8); } }

        public int ProtocolVersion { get { return RawData.GetInt16(10); } }

        public bool IsValid { get { return ARTNETID.SequenceEqual(RawData.Block(0, ARTNETID.Length)); } }

        public bool IsDMXPacket { get { return (OpCode == OP_DMX ? true : false); } }

        public bool IsPollPacket { get { return (OpCode == OP_POLL ? true : false); } }

        public int Universe { get { return RawData[14] % 16; } }

        public int Net { get { return RawData[15]; } }

        public int SubNet { get { return RawData[14] / 16; } }
    }
}