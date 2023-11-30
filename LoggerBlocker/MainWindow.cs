using BitcoinTools;
using Crypto.security;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();


            //Check_update();
        }

        private void Check_update()
        {
            List<int> arr = new List<int>();
            for (int j = 0; j < 14000; j++)
                arr.Add(j);

            Update_security update = new Update_security();
            update.Check_for_update(BaseSeeds.Get_entropy(arr, 20000));
        }

        private void cmb_words_count_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
