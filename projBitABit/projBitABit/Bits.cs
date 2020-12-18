using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projBitABit
{
    class Bits
    {
        private byte osBits;

        public Bits()
        {
            this.osBits = 0;
        }

        public Bits(byte osBits)
        {
            this.osBits = osBits;
        }

        public void setBits(byte osBits)
        {
            this.osBits = osBits;
        }

        public byte getBits()
        {
            return this.osBits;
        }

        public bool getBits(int bit)
        {
            byte novoDado;
            int valor;
            valor = (int)Math.Pow(2, bit - 1);
            novoDado = (byte)((int)this.osBits & valor);
            return (novoDado > 0);
        }
    }
}
