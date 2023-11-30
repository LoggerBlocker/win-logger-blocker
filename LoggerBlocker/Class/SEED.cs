using Bitcoin.BIP39;
using Bitcoin.BitcoinUtilities;
using System;
using System.Collections.Generic;

namespace main
{
    internal class SEED
    {
        public List<string> _words { get; set; }

        public SEED()
        {
            _words = new List<string>();
        }

        public void Generate_seed(string seed_words, int words_count)
        {
            string hexString = string.Empty;
            string hexString_32 = "0000000000000000000000000000000000000000000000000000000000000000";

            int text_seed = 0;
            foreach (char c in seed_words)
                text_seed += ((int)c) + 256;

            Random r = new Random(text_seed);
            for (int i = 0; i < hexString_32.Length; i++)
            {
                int A = r.Next(0, 10000);
                string hexValue1 = A.ToString("X");

                hexString += hexValue1[0];
            }

            if (words_count == 12)
                hexString = hexString.Substring(0, 32);


            byte[] entropyBytes = Utilities.HexStringToBytes(hexString);
            string entropy = string.Empty; //For next version
            BIP39 bip39 = new BIP39(entropyBytes, entropy);

            string[] words = bip39.MnemonicSentence.Split(' ');

            _words = new List<string>();
            for (int i = 0; i < words.Length; i++)
                _words.Add(words[i]);

        }
    }
}