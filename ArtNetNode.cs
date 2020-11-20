using System;
using System.Collections.Generic;

namespace ArtNetManager
{
    public class ArtNetNode
    {
        public int Net { get; set; } //A group of 16 consecutive universes is referred to as a sub-net. (Not to be confused with the subnet mask)
        public int Subnet { get; set; } //A group of 16 consecutive Sub-Nets or 256 consecutive Universes isreferred to as a net.There are 128Nets in total            
        public List<ArtNetPort> Ports { get; set; } //List of DMX512 ports (port -> equivalent of single 512 channels frame)

        public ArtNetNode(int net, int subnet, int portCount)
        {
            this.Net = net;
            this.Subnet = subnet;

            Ports = new List<ArtNetPort>();

            for (int i = 0; i < portCount; i++)
            {
                Ports.Add(new ArtNetPort());
            }
        }

        public ArtNetNode(int net, int subnet) : this(net, subnet, 1)
        {
        }

        public ArtNetNode() : this(0, 0, 1)
        {
        }

        public Boolean AddressValid(int net, int subnet, int universe)
        {
            return ((this.Net == net) && (this.Subnet == subnet) && (Ports.Count > universe));
        }
        public Boolean PortValid(int universe)
        {
            return (Ports.Count > universe);
        }

        public override string ToString()
        {
            return string.Format("{0}.{1}.{2}", Net, Subnet, Ports.Count);
        }
    }
}
