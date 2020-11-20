using System.Drawing;

namespace ArtNetManager
{
    public class ArtNetPort
    {
        public Color[] RgbData { get; set; }

        public ArtNetPort()
        {
            RgbData = new Color[170];
        }
    }
}
