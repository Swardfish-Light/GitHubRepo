using System;

namespace ArtNetManager
{
    class ArtDmxPacket
    {
        public byte[] DmxData { get; set; }

        public ArtDmxPacket(byte[] rawData)
        {
            DmxData = new byte[530];

            Buffer.BlockCopy(ArtNetPacket.ARTNETID, 0, DmxData, 0, ArtNetPacket.ARTNETID.Length); //ArtNet ID
            DmxData.SetInt16LE(8, ArtNetPacket.OP_DMX); // OppCode
            DmxData.SetInt16(10, 14); // Version
            DmxData[12] = 0x00; // Sequence
            DmxData[13] = 0x00; // Port
            DmxData[14] = 0x00; // Subnet
            DmxData[15] = 0x00; // Net
            DmxData.SetInt16(16, rawData.Length); // Data array length

            Buffer.BlockCopy(rawData, 0, DmxData, 18, rawData.Length); // Data


        }
    }
}
