using BitcoinTools;
using Crypto.security;
using main;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        private int _words_count
        {
            get
            {
                if (cmb_words_count.SelectedIndex == 0)
                    return 12;
                if (cmb_words_count.SelectedIndex == 1)
                    return 24;
                return 0;
            }
        }

        private SEED _seed { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Initialize();

            _seed = new SEED();
            txt_seeds.Visible = false;
            lb_info_3.Visible = false;
        }

        private void Initialize()
        {
            cmb_words_count.DataSource = new List<string> { "12 Words", "24 Words" };
            cmb_words_count.SelectedIndex = 0;


            //Update_security update = new Update_security();
            //update.Check_for_update();
            Reset();
        }

        private void Reset()
        {
            txt_seed_01.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_02.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_03.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_04.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_05.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_06.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_07.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_08.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_09.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_10.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_11.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_12.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_13.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_14.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_15.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_16.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_17.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_18.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_19.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_20.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_21.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_22.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_23.BackColor = System.Drawing.Color.WhiteSmoke;
            txt_seed_24.BackColor = System.Drawing.Color.WhiteSmoke;
        }

        private void cmb_words_count_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmb_words_count.SelectedIndex == 0)
            {
                wp_12_words.Visible = true;
                wp_24_words.Visible = false;
            }

            if (cmb_words_count.SelectedIndex == 1)
            {
                wp_12_words.Visible = true;
                wp_24_words.Visible = true;

            }
            if (txt_seed_words.Text.Length > 0)
                _seed.Generate_seed(txt_seed_words.Text, _words_count);
        }

        private void txt_seed_words_TextChanged(object sender, System.EventArgs e)
        {
            _seed.Generate_seed(txt_seed_words.Text, _words_count);
            if (_seed._words.Count > 11)
            {
                lb_info_1.ForeColor = System.Drawing.Color.Green;
                lb_info_1.Text = "Seed generated, you can move the cursor to see the words";
                lb_info_2.Text = "Now, select the text below. Hold down the left mouse button and release it where you want to place the seed.";
                txt_seeds.Visible = true;
            }
        }

        private void txt_seed_MouseEnter(object sender, System.EventArgs e)
        {
            if (_seed == null) return;
            if (_seed._words == null) return;
            if (_seed._words.Count == 0) return;


            if (sender.GetType() == typeof(TextBox))
            {
                TextBox txt = (TextBox)sender;

                string numbers = string.Empty;
                foreach (char c in txt.Name)
                    if (char.IsDigit(c))
                        numbers += int.Parse(c.ToString());

                int index = int.Parse(numbers) - 1;

                if (_seed._words.Count > index)
                {
                    txt.Text = _seed._words[index];
                    txt.BackColor = System.Drawing.Color.White;
                    txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void txt_seed_MouseLeave(object sender, System.EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                TextBox txt = (TextBox)sender;
                txt.Text = string.Empty;
                txt.BackColor = System.Drawing.Color.WhiteSmoke;
            }
        }

        private void txt_seeds_TextChanged(object sender, System.EventArgs e)
        {
            if (txt_seeds.Text != "Select any part of this text, then drag me and drop me into a text box.")
                txt_seeds.Text = "Select any part of this text, then drag me and drop me into a text box.";
        }

        private void txt_seeds_MouseDown(object sender, MouseEventArgs e)
        {
            bool ok = false;

            if (_seed == null) return;
            if (_seed._words == null) return;
            if (_seed._words.Count == 0) return;

            if (sender.GetType() == typeof(TextBox))
            {
                string seed = string.Empty;
                foreach (string word in _seed._words)
                    seed += word + " ";

                txt_seeds.DoDragDrop(seed, DragDropEffects.Copy | DragDropEffects.Move);

                ok = true;
            }
            if (!ok)
            {
                lb_info_3.Visible = true;
            }
        }
    }
}
