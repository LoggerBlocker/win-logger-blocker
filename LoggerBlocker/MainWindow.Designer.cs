namespace WindowsFormsApp1
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.cmb_words_count = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_seed_words = new System.Windows.Forms.TextBox();
            this.lb_info_2 = new System.Windows.Forms.Label();
            this.lb_info_3 = new System.Windows.Forms.Label();
            this.lb_info_1 = new System.Windows.Forms.Label();
            this.wp_12_words = new System.Windows.Forms.Panel();
            this.txt_seed_12 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_seed_11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_seed_10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_seed_09 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_seed_08 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_seed_07 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_seed_06 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_seed_05 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_seed_04 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_seed_03 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_seed_02 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_seed_01 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wp_24_words = new System.Windows.Forms.Panel();
            this.txt_seed_24 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_seed_23 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_seed_22 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_seed_21 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_seed_20 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_seed_19 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_seed_18 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_seed_17 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_seed_16 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_seed_15 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_seed_14 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_seed_13 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_seeds = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.wp_12_words.SuspendLayout();
            this.wp_24_words.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_words_count
            // 
            this.cmb_words_count.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_words_count.FormattingEnabled = true;
            this.cmb_words_count.Location = new System.Drawing.Point(18, 27);
            this.cmb_words_count.Name = "cmb_words_count";
            this.cmb_words_count.Size = new System.Drawing.Size(100, 21);
            this.cmb_words_count.TabIndex = 0;
            this.cmb_words_count.SelectedIndexChanged += new System.EventHandler(this.cmb_words_count_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seed word";
            // 
            // txt_seed_words
            // 
            this.txt_seed_words.Location = new System.Drawing.Point(188, 27);
            this.txt_seed_words.Name = "txt_seed_words";
            this.txt_seed_words.Size = new System.Drawing.Size(200, 20);
            this.txt_seed_words.TabIndex = 2;
            this.txt_seed_words.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_words.TextChanged += new System.EventHandler(this.txt_seed_words_TextChanged);
            // 
            // lb_info_2
            // 
            this.lb_info_2.AutoSize = true;
            this.lb_info_2.ForeColor = System.Drawing.Color.Red;
            this.lb_info_2.Location = new System.Drawing.Point(12, 276);
            this.lb_info_2.Name = "lb_info_2";
            this.lb_info_2.Size = new System.Drawing.Size(523, 13);
            this.lb_info_2.TabIndex = 3;
            this.lb_info_2.Text = "Now, select the text below. Hold down the left mouse button and release it where " +
    "you want to place the seed.";
            this.lb_info_2.Visible = false;
            // 
            // lb_info_3
            // 
            this.lb_info_3.AutoSize = true;
            this.lb_info_3.ForeColor = System.Drawing.Color.Red;
            this.lb_info_3.Location = new System.Drawing.Point(506, 309);
            this.lb_info_3.Name = "lb_info_3";
            this.lb_info_3.Size = new System.Drawing.Size(196, 13);
            this.lb_info_3.TabIndex = 4;
            this.lb_info_3.Text = "The dragging has failed, please repeat it";
            this.lb_info_3.Visible = false;
            // 
            // lb_info_1
            // 
            this.lb_info_1.AutoSize = true;
            this.lb_info_1.ForeColor = System.Drawing.Color.Red;
            this.lb_info_1.Location = new System.Drawing.Point(394, 30);
            this.lb_info_1.Name = "lb_info_1";
            this.lb_info_1.Size = new System.Drawing.Size(297, 13);
            this.lb_info_1.TabIndex = 5;
            this.lb_info_1.Text = "First, write a seed word, you can use any character or symbol.";
            // 
            // wp_12_words
            // 
            this.wp_12_words.Controls.Add(this.txt_seed_12);
            this.wp_12_words.Controls.Add(this.label10);
            this.wp_12_words.Controls.Add(this.txt_seed_11);
            this.wp_12_words.Controls.Add(this.label11);
            this.wp_12_words.Controls.Add(this.txt_seed_10);
            this.wp_12_words.Controls.Add(this.label12);
            this.wp_12_words.Controls.Add(this.txt_seed_09);
            this.wp_12_words.Controls.Add(this.label13);
            this.wp_12_words.Controls.Add(this.txt_seed_08);
            this.wp_12_words.Controls.Add(this.label6);
            this.wp_12_words.Controls.Add(this.txt_seed_07);
            this.wp_12_words.Controls.Add(this.label7);
            this.wp_12_words.Controls.Add(this.txt_seed_06);
            this.wp_12_words.Controls.Add(this.label8);
            this.wp_12_words.Controls.Add(this.txt_seed_05);
            this.wp_12_words.Controls.Add(this.label9);
            this.wp_12_words.Controls.Add(this.txt_seed_04);
            this.wp_12_words.Controls.Add(this.label5);
            this.wp_12_words.Controls.Add(this.txt_seed_03);
            this.wp_12_words.Controls.Add(this.label4);
            this.wp_12_words.Controls.Add(this.txt_seed_02);
            this.wp_12_words.Controls.Add(this.label3);
            this.wp_12_words.Controls.Add(this.txt_seed_01);
            this.wp_12_words.Controls.Add(this.label2);
            this.wp_12_words.Location = new System.Drawing.Point(18, 85);
            this.wp_12_words.Name = "wp_12_words";
            this.wp_12_words.Size = new System.Drawing.Size(728, 85);
            this.wp_12_words.TabIndex = 6;
            // 
            // txt_seed_12
            // 
            this.txt_seed_12.Location = new System.Drawing.Point(575, 56);
            this.txt_seed_12.Name = "txt_seed_12";
            this.txt_seed_12.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_12.TabIndex = 23;
            this.txt_seed_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_12.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_12.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(547, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "12.";
            // 
            // txt_seed_11
            // 
            this.txt_seed_11.Location = new System.Drawing.Point(393, 57);
            this.txt_seed_11.Name = "txt_seed_11";
            this.txt_seed_11.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_11.TabIndex = 21;
            this.txt_seed_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_11.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_11.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(365, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "11.";
            // 
            // txt_seed_10
            // 
            this.txt_seed_10.Location = new System.Drawing.Point(212, 58);
            this.txt_seed_10.Name = "txt_seed_10";
            this.txt_seed_10.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_10.TabIndex = 19;
            this.txt_seed_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_10.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_10.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(184, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "10.";
            // 
            // txt_seed_09
            // 
            this.txt_seed_09.Location = new System.Drawing.Point(27, 58);
            this.txt_seed_09.Name = "txt_seed_09";
            this.txt_seed_09.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_09.TabIndex = 17;
            this.txt_seed_09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_09.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_09.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "9.";
            // 
            // txt_seed_08
            // 
            this.txt_seed_08.Location = new System.Drawing.Point(575, 30);
            this.txt_seed_08.Name = "txt_seed_08";
            this.txt_seed_08.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_08.TabIndex = 15;
            this.txt_seed_08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_08.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_08.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "8.";
            // 
            // txt_seed_07
            // 
            this.txt_seed_07.Location = new System.Drawing.Point(393, 31);
            this.txt_seed_07.Name = "txt_seed_07";
            this.txt_seed_07.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_07.TabIndex = 13;
            this.txt_seed_07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_07.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_07.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "7.";
            // 
            // txt_seed_06
            // 
            this.txt_seed_06.Location = new System.Drawing.Point(212, 32);
            this.txt_seed_06.Name = "txt_seed_06";
            this.txt_seed_06.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_06.TabIndex = 11;
            this.txt_seed_06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_06.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_06.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "6.";
            // 
            // txt_seed_05
            // 
            this.txt_seed_05.Location = new System.Drawing.Point(27, 32);
            this.txt_seed_05.Name = "txt_seed_05";
            this.txt_seed_05.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_05.TabIndex = 9;
            this.txt_seed_05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_05.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_05.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "5.";
            // 
            // txt_seed_04
            // 
            this.txt_seed_04.Location = new System.Drawing.Point(575, 4);
            this.txt_seed_04.Name = "txt_seed_04";
            this.txt_seed_04.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_04.TabIndex = 7;
            this.txt_seed_04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_04.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_04.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(553, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "4.";
            // 
            // txt_seed_03
            // 
            this.txt_seed_03.Location = new System.Drawing.Point(393, 5);
            this.txt_seed_03.Name = "txt_seed_03";
            this.txt_seed_03.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_03.TabIndex = 5;
            this.txt_seed_03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_03.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_03.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "3.";
            // 
            // txt_seed_02
            // 
            this.txt_seed_02.Location = new System.Drawing.Point(212, 6);
            this.txt_seed_02.Name = "txt_seed_02";
            this.txt_seed_02.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_02.TabIndex = 3;
            this.txt_seed_02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_02.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_02.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "2.";
            // 
            // txt_seed_01
            // 
            this.txt_seed_01.BackColor = System.Drawing.SystemColors.Window;
            this.txt_seed_01.Location = new System.Drawing.Point(27, 6);
            this.txt_seed_01.Name = "txt_seed_01";
            this.txt_seed_01.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_01.TabIndex = 1;
            this.txt_seed_01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_01.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_01.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "1.";
            // 
            // wp_24_words
            // 
            this.wp_24_words.Controls.Add(this.txt_seed_24);
            this.wp_24_words.Controls.Add(this.label14);
            this.wp_24_words.Controls.Add(this.txt_seed_23);
            this.wp_24_words.Controls.Add(this.label15);
            this.wp_24_words.Controls.Add(this.txt_seed_22);
            this.wp_24_words.Controls.Add(this.label16);
            this.wp_24_words.Controls.Add(this.txt_seed_21);
            this.wp_24_words.Controls.Add(this.label17);
            this.wp_24_words.Controls.Add(this.txt_seed_20);
            this.wp_24_words.Controls.Add(this.label18);
            this.wp_24_words.Controls.Add(this.txt_seed_19);
            this.wp_24_words.Controls.Add(this.label19);
            this.wp_24_words.Controls.Add(this.txt_seed_18);
            this.wp_24_words.Controls.Add(this.label20);
            this.wp_24_words.Controls.Add(this.txt_seed_17);
            this.wp_24_words.Controls.Add(this.label21);
            this.wp_24_words.Controls.Add(this.txt_seed_16);
            this.wp_24_words.Controls.Add(this.label22);
            this.wp_24_words.Controls.Add(this.txt_seed_15);
            this.wp_24_words.Controls.Add(this.label23);
            this.wp_24_words.Controls.Add(this.txt_seed_14);
            this.wp_24_words.Controls.Add(this.label24);
            this.wp_24_words.Controls.Add(this.txt_seed_13);
            this.wp_24_words.Controls.Add(this.label25);
            this.wp_24_words.Location = new System.Drawing.Point(18, 176);
            this.wp_24_words.Name = "wp_24_words";
            this.wp_24_words.Size = new System.Drawing.Size(728, 85);
            this.wp_24_words.TabIndex = 24;
            // 
            // txt_seed_24
            // 
            this.txt_seed_24.Location = new System.Drawing.Point(575, 56);
            this.txt_seed_24.Name = "txt_seed_24";
            this.txt_seed_24.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_24.TabIndex = 23;
            this.txt_seed_24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_24.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_24.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(547, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "24.";
            // 
            // txt_seed_23
            // 
            this.txt_seed_23.Location = new System.Drawing.Point(393, 57);
            this.txt_seed_23.Name = "txt_seed_23";
            this.txt_seed_23.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_23.TabIndex = 21;
            this.txt_seed_23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_23.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_23.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(366, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "23.";
            // 
            // txt_seed_22
            // 
            this.txt_seed_22.Location = new System.Drawing.Point(212, 58);
            this.txt_seed_22.Name = "txt_seed_22";
            this.txt_seed_22.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_22.TabIndex = 19;
            this.txt_seed_22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_22.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_22.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(184, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "22.";
            // 
            // txt_seed_21
            // 
            this.txt_seed_21.Location = new System.Drawing.Point(27, 58);
            this.txt_seed_21.Name = "txt_seed_21";
            this.txt_seed_21.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_21.TabIndex = 17;
            this.txt_seed_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_21.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_21.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(2, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "21.";
            // 
            // txt_seed_20
            // 
            this.txt_seed_20.Location = new System.Drawing.Point(575, 30);
            this.txt_seed_20.Name = "txt_seed_20";
            this.txt_seed_20.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_20.TabIndex = 15;
            this.txt_seed_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_20.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_20.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(547, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "20.";
            // 
            // txt_seed_19
            // 
            this.txt_seed_19.Location = new System.Drawing.Point(393, 31);
            this.txt_seed_19.Name = "txt_seed_19";
            this.txt_seed_19.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_19.TabIndex = 13;
            this.txt_seed_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_19.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_19.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(365, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(22, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "19.";
            // 
            // txt_seed_18
            // 
            this.txt_seed_18.Location = new System.Drawing.Point(212, 32);
            this.txt_seed_18.Name = "txt_seed_18";
            this.txt_seed_18.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_18.TabIndex = 11;
            this.txt_seed_18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_18.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_18.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(184, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "18.";
            // 
            // txt_seed_17
            // 
            this.txt_seed_17.Location = new System.Drawing.Point(27, 32);
            this.txt_seed_17.Name = "txt_seed_17";
            this.txt_seed_17.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_17.TabIndex = 9;
            this.txt_seed_17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_17.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_17.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(2, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(22, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "17.";
            // 
            // txt_seed_16
            // 
            this.txt_seed_16.Location = new System.Drawing.Point(575, 4);
            this.txt_seed_16.Name = "txt_seed_16";
            this.txt_seed_16.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_16.TabIndex = 7;
            this.txt_seed_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_16.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_16.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(547, 7);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "16.";
            // 
            // txt_seed_15
            // 
            this.txt_seed_15.Location = new System.Drawing.Point(393, 5);
            this.txt_seed_15.Name = "txt_seed_15";
            this.txt_seed_15.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_15.TabIndex = 5;
            this.txt_seed_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_15.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_15.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(365, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(22, 13);
            this.label23.TabIndex = 4;
            this.label23.Text = "15.";
            // 
            // txt_seed_14
            // 
            this.txt_seed_14.Location = new System.Drawing.Point(212, 6);
            this.txt_seed_14.Name = "txt_seed_14";
            this.txt_seed_14.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_14.TabIndex = 3;
            this.txt_seed_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_14.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_14.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(184, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(22, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "14.";
            // 
            // txt_seed_13
            // 
            this.txt_seed_13.Location = new System.Drawing.Point(27, 6);
            this.txt_seed_13.Name = "txt_seed_13";
            this.txt_seed_13.Size = new System.Drawing.Size(150, 20);
            this.txt_seed_13.TabIndex = 1;
            this.txt_seed_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seed_13.MouseEnter += new System.EventHandler(this.txt_seed_MouseEnter);
            this.txt_seed_13.MouseLeave += new System.EventHandler(this.txt_seed_MouseLeave);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(2, 10);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(22, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "13.";
            // 
            // txt_seeds
            // 
            this.txt_seeds.AllowDrop = true;
            this.txt_seeds.Location = new System.Drawing.Point(18, 306);
            this.txt_seeds.Name = "txt_seeds";
            this.txt_seeds.Size = new System.Drawing.Size(479, 20);
            this.txt_seeds.TabIndex = 25;
            this.txt_seeds.Text = "Click and hold left mouse button, and then drop into text field";
            this.txt_seeds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seeds.TextChanged += new System.EventHandler(this.txt_seeds_TextChanged);
            this.txt_seeds.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_seeds_MouseDown);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(537, 335);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(215, 23);
            this.btn_update.TabIndex = 26;
            this.btn_update.Text = "Available update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 361);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_seeds);
            this.Controls.Add(this.wp_24_words);
            this.Controls.Add(this.wp_12_words);
            this.Controls.Add(this.lb_info_1);
            this.Controls.Add(this.lb_info_3);
            this.Controls.Add(this.lb_info_2);
            this.Controls.Add(this.txt_seed_words);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_words_count);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoggerBlocker Version";
            this.TopMost = true;
            this.wp_12_words.ResumeLayout(false);
            this.wp_12_words.PerformLayout();
            this.wp_24_words.ResumeLayout(false);
            this.wp_24_words.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_words_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_seed_words;
        private System.Windows.Forms.Label lb_info_2;
        private System.Windows.Forms.Label lb_info_3;
        private System.Windows.Forms.Label lb_info_1;
        private System.Windows.Forms.Panel wp_12_words;
        private System.Windows.Forms.TextBox txt_seed_01;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_seed_04;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_seed_03;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_seed_02;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_seed_12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_seed_11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_seed_10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_seed_09;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_seed_08;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_seed_07;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_seed_06;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_seed_05;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel wp_24_words;
        private System.Windows.Forms.TextBox txt_seed_24;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_seed_23;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_seed_22;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_seed_21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_seed_20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_seed_19;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_seed_18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_seed_17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_seed_16;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_seed_15;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_seed_14;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txt_seed_13;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txt_seeds;
        private System.Windows.Forms.Button btn_update;
    }
}

