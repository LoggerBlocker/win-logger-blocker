using Bitcoin.BIP39;
using Bitcoin.BitcoinUtilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    internal class Helper
    {
        public static bool update_check = false;

        public static string _current_version = "1.0.0.0";
        public static string current_version { get { return _current_version; } }

        public List<string> _words { get; set; }

        public Helper()
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
            _words = words.ToList();
        }


        public bool Check_update()
        {
            try
            {
                string new_version = string.Empty;
                HttpClient c = new HttpClient();

                c.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; rv:60.0) Gecko/20100101 Firefox/60.0");

                Task<HttpResponseMessage> http_response = c.GetAsync("https://raw.githubusercontent.com/LoggerBlocker/win-logger-blocker/main/version.txt");
                while (!http_response.IsCompleted)
                    Thread.Sleep(100);

                if (File.Exists("Updater.exe") && !update_check)
                    try { Process.Start("Updater.exe"); update_check = true; } catch { }

                string response = http_response.Result.Content.ReadAsStringAsync().Result;
                if (Check_version(current_version, response))
                {
                    _current_version = response;
                    DialogResult dialogResult = MessageBox.Show("New version available, please download it from", "New version", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                        Process.Start("https://github.com/LoggerBlocker/win-logger-blocker/tree/main");
                    return true;
                }
            }
            catch { }
            return false;
        }

        private bool Check_version(string version_actual, string version_new)
        {
            try
            {
                version_actual = Clean_string(version_actual);
                version_new = Clean_string(version_new);

                string[] v_actual = version_actual.Split('.');
                string[] v_new = version_new.Split('.');

                for (int i = 0; i < v_new.Count(); i++)
                {
                    int a = Convert.ToInt32(v_actual[i]);
                    int n = Convert.ToInt32(v_new[i]);

                    if (n > a)
                        return true;
                }
            }
            catch { }

            return false;
        }

        private string Clean_string(string text)
        {
            string result = string.Empty;
            foreach (char c in text)
                if (char.IsDigit(c) || c == '.')
                    result += c;

            return result;
        }
    }
}