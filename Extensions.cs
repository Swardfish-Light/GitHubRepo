namespace ArtNetManager
{
    public static class Extensions
    {
        public static byte[] Block(this byte[] data, int offset, int length)
        {
            var tmp = new byte[length];

            for (int i = offset; i < length; i++)
                tmp[i - offset] = data[i];

            return tmp;
        }

        public static int GetInt16LE(this byte[] data, int offset)
        {
            return (data[offset + 1] << 8) | (data[offset]);
        }

        public static int GetInt16(this byte[] data, int offset)
        {
            return (data[offset] << 8 | data[offset + 1]);
        }

        public static void SetInt16LE(this byte[] data, int offset, int value)
        {
            data[offset] = (byte)value;
            data[offset + 1] = (byte)(value >> 8);


        }
        public static void SetInt16(this byte[] data, int offset, int value)
        {
            data[offset + 1] = (byte)value;
            data[offset] = (byte)(value >> 8);
        }
    }
}
