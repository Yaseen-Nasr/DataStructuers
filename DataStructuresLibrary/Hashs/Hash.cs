 
using System.Text;
 

namespace DataStructuresLibrary.Hashs
{
    public  class Hash
    {

        /// <summary>
        /// hash function FNV-1a 
        /// </summary>
        /// <param name="str">string to hash</param>
        /// <returns>uint represent hash 32 bit</returns>
        public static uint Hash32(string str)
        {
            uint offsetBasis = 2166136261;
            uint fnvPrime = 16777619;
            uint hash = offsetBasis;
            byte[] data = Encoding.ASCII.GetBytes(str); 
            for (int i = 0; i < data.Length; i++)
            {
                hash = hash ^ data[i];
                hash = hash * fnvPrime;
            }
            Console.WriteLine(str + ", " + hash + ", " + hash.ToString("x"));
            return hash ;
        }
        /// <summary>
        /// hash function FNV-1a 
        /// </summary>
        /// <param name="str">string to hash</param>
        /// <returns>ulong represent hash 64 bit</returns>
        public static ulong Hash64(string str)
        { 
            ulong offsetBasis = 14695981039346656037;
            ulong fnvPrime = 1099511628211;
            ulong hash = offsetBasis;
            byte[] data = Encoding.ASCII.GetBytes(str);
            for (int i = 0; i < data.Length; i++)
            {
                hash = hash ^ data[i];
                hash = hash * fnvPrime;
            }
            Console.WriteLine(str + ", " + hash + ", " + hash.ToString("x"));
            return hash;
        }

    }
}
