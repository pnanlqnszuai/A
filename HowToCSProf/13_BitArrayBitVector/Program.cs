using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_BitArrayBitVector
{
    class Program
    {
        static void Main(string[] args)
        {
            var bits = new BitArray(3);
            bits[0] = false;
            bits[1] = true;
            bits[2] = false;

            var moreBits = new BitArray(3);
            moreBits[0] = true;
            moreBits[1] = true;
            moreBits[2] = false;

            var xorBits = bits.Xor(moreBits);

            foreach (bool bit in xorBits)
            {
                Console.WriteLine(bit);
            }

            // ---------------------------------------------------------------------------------------------------------

            BitVector32.Section firstSection = BitVector32.CreateSection(10); // 0xA Hex - 1010 Bin 
            BitVector32.Section secondSection = BitVector32.CreateSection(50, firstSection); // 0x32 Hex - 110010 Bin
            BitVector32.Section thirdSection = BitVector32.CreateSection(500, secondSection); // 0x1F4 Hex - 111110100 Bin
            BitVector32.Section fourthSection = BitVector32.CreateSection(500, thirdSection);
            var packedBits = new BitVector32(0);

            packedBits[firstSection] = 10;
            packedBits[secondSection] = 50;
            packedBits[thirdSection] = 500;
            packedBits[fourthSection] = 499;

            Console.WriteLine(packedBits[firstSection]);
            Console.WriteLine(packedBits[secondSection]);
            Console.WriteLine(packedBits[thirdSection]);
            Console.WriteLine(packedBits[fourthSection]);

            Console.WriteLine(packedBits);  // packedBits = {BitVector32{0000000000000 111110100 110010 1010}}


            Console.WriteLine(packedBits.Data);
            // packedBits.Data = 512 810

            // Delay.
            Console.ReadKey();
        }
    }
}
