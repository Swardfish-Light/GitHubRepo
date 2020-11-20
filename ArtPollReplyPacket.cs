using System;
using System.Net;

namespace ArtNetManager
{
    class ArtPollReplyPacket
    {
        private readonly byte RC_POWER_OK = 0x0001;
        //private readonly byte RC_DMX_ERROR = 0x0008;
        public byte[] RawData { get; set; }

        public ArtPollReplyPacket(IPEndPoint localIPEndPoint, ArtNetNode node, int port)
        {
            RawData = new byte[239];

            Buffer.BlockCopy(ArtNetPacket.ARTNETID, 0, RawData, 0, ArtNetPacket.ARTNETID.Length); //ArtNet ID
            RawData.SetInt16LE(8, ArtNetPacket.OP_POLL_REPLY); // OppCode

            byte[] ip = localIPEndPoint.Address.GetAddressBytes();
            Buffer.BlockCopy(ip, 0, RawData, 10, 4); // IP Address

            RawData.SetInt16LE(14, 0x1936); // Port
            RawData.SetInt16LE(16, 0x0100); // Version
            RawData[18] = Convert.ToByte(node.Net); // Net
            RawData[19] = Convert.ToByte(node.Subnet); // Subnet
            RawData.SetInt16(20, 0x0000); // Oem
            RawData[22] = 0x00; // Ubea
            RawData[23] = 0b11110000; // Status1
            RawData[24] = (byte)'P'; // ESTA Mano Lo
            RawData[25] = (byte)'O'; // ESTA Mano Hi

            byte[] buf;
            buf = new byte[18];
            String shortName = "ArtNet Manager";
            Buffer.BlockCopy(shortName.ToCharArray(), 0, buf, 0, shortName.Length);
            Buffer.BlockCopy(buf, 0, RawData, 26, buf.Length); // Short Name

            buf = new byte[64];
            String longName = "ArtNet Manager";
            Buffer.BlockCopy(longName.ToCharArray(), 0, buf, 0, longName.Length);
            Buffer.BlockCopy(buf, 0, RawData, 44, buf.Length); // Short Name

            buf = new byte[64];
            String nodeReport = System.String.Format("#{0:X}[{1}] {2}", RC_POWER_OK, 0, "Node OK");
            Buffer.BlockCopy(nodeReport.ToCharArray(), 0, buf, 0, nodeReport.Length);
            Buffer.BlockCopy(buf, 0, RawData, 108, buf.Length); // Node report

            RawData.SetInt16(172, node.Ports.Count); // Num ports

            for (int i = 0; i < 4; i++)
                RawData[174 + i] = 0b10000101; // Port types

            for (int i = 0; i < 4; i++)
                RawData[178 + i] = 0b10000000; // Good input

            for (int i = 0; i < 4; i++)
                RawData[182 + i] = 0b10000000; // Good output

            for (int i = 0; i < 4; i++)
                RawData[186 + i] = 0x00; // SwIn

            for (int i = 0; i < 4; i++)
                RawData[190 + i] = 0x00; // SwOut

            RawData[194] = 0x00; // SW video
            RawData[195] = 0x00; // SW macro
            RawData[196] = 0x00; // SW remote

            for (int i = 0; i < 3; i++)
                RawData[197 + i] = 0x00; // Spare

            RawData[200] = 0x00; // Style

            for (int i = 0; i < 6; i++)
                RawData[201 + i] = 0x00; // MAC

            for (int i = 0; i < 4; i++)
                RawData[207] = 0x00; // BindIp

            RawData[211] = 0x00; // Bind index

            RawData[212] = 0b00000110; // Status2

            for (int i = 0; i < 26; i++)
                RawData[213] = 0x00; // Filter
        }
    }
}
