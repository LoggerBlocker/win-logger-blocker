using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace main
{
    public partial class MainWindow : Window
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
            txt_seeds.Visibility = Visibility.Hidden;
            lb_info_3.Visibility = Visibility.Collapsed;
        }

        private void Initialize()
        {
            cmb_words_count.ItemsSource = new List<string> { "12 Words", "24 Words" };
            cmb_words_count.SelectedIndex = 0;
        }


        private void txt_seeds_PreviewDragLeave(object sender, DragEventArgs e)
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

                e.Data.SetData(DataFormats.UnicodeText, seed);
                ok = true;
            }
            if (!ok)
            {
                lb_info_3.Visibility = Visibility.Visible;
            }
        }

        private void cmb_words_count_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            wp_12_words.Visibility = Visibility.Collapsed;
            wp_24_words.Visibility = Visibility.Collapsed;

            if (cmb_words_count.SelectedIndex == 0)
            {
                wp_12_words.Visibility = Visibility.Visible;
                wp_24_words.Visibility = Visibility.Collapsed;
            }

            if (cmb_words_count.SelectedIndex == 1)
            {
                wp_12_words.Visibility = Visibility.Visible;
                wp_24_words.Visibility = Visibility.Visible;
                if (txt_seed_words.Text.Length > 0)
                    _seed.Generate_seed(txt_seed_words.Text, _words_count);
            }
        }

        private void txt_seed_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
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
                    txt.Background = new SolidColorBrush(Colors.White);
                    txt.FontWeight = FontWeights.Bold;
                }
            }
        }

        private void txt_seed_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                TextBox txt = (TextBox)sender;
                txt.Text = string.Empty;
                txt.Background = new SolidColorBrush(Colors.Gray);
            }
        }

        private void txt_seed_words_TextChanged(object sender, TextChangedEventArgs e)
        {
            _seed.Generate_seed(txt_seed_words.Text, _words_count);
            if (_seed._words.Count > 11)
            {
                lb_info_1.Foreground = new SolidColorBrush(Colors.Green);
                lb_info_1.Content = "Seed generated, you can move the cursor to see the words";
                lb_info_2.Content = "Now, select the text below. Hold down the left mouse button and release it where you want to place the seed.";
                txt_seeds.Visibility = Visibility.Visible;
            }
        }

        private void txt_seeds_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_seeds.Text != "Select any part of this text, then drag me and drop me into a text box.")
                txt_seeds.Text = "Select any part of this text, then drag me and drop me into a text box.";
        }
    }
}