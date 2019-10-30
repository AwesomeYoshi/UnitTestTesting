using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Colour
    {
        public UInt32 colour;

        public Colour()
        {
            colour = 0;
        }
        public byte GetAlpha()
        {
            return (byte)(colour >> 24);
        }
        public byte GetRed()
        {
            return (byte)(colour >> 16);
        }
        public byte GetGreen()
        {
            return (byte)(colour >> 8);
        }
        public byte GetBlue()
        {
            return (byte)colour;
        }
        public void GetAlpha(uint val)
        {
            colour = colour & (uint)0x00FFFFFF;
            colour = colour | (val << 24);
        }
    }
}
