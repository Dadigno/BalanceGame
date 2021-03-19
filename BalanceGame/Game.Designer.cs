using System.Windows.Forms;

namespace BalanceGame
{
    partial class Game
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_game = new System.Windows.Forms.Panel();
            this.panel_win_lost = new System.Windows.Forms.Panel();
            this.smile_sad = new System.Windows.Forms.PictureBox();
            this.smile_happy = new System.Windows.Forms.PictureBox();
            this.message_win_lost = new System.Windows.Forms.Label();
            this.moves_avaliable_value_label = new System.Windows.Forms.Label();
            this.moves_avaliable_label = new System.Windows.Forms.Label();
            this.debug_label3 = new System.Windows.Forms.Label();
            this.debug_label2 = new System.Windows.Forms.Label();
            this.debug_label1 = new System.Windows.Forms.Label();
            this.debug_label0 = new System.Windows.Forms.Label();
            this.balance_indicator = new System.Windows.Forms.PictureBox();
            this.balance_body = new System.Windows.Forms.PictureBox();
            this.panel_plate_right = new System.Windows.Forms.Panel();
            this.panel_plateweight_1 = new System.Windows.Forms.Panel();
            this.weight_1_label = new System.Windows.Forms.Label();
            this.weight_1 = new System.Windows.Forms.PictureBox();
            this.panel_plateweight_5 = new System.Windows.Forms.Panel();
            this.weight_5_label = new System.Windows.Forms.Label();
            this.weight_5 = new System.Windows.Forms.PictureBox();
            this.panel_plateweight_10 = new System.Windows.Forms.Panel();
            this.weight_10_label = new System.Windows.Forms.Label();
            this.weight_10 = new System.Windows.Forms.PictureBox();
            this.panel_plateweight_100 = new System.Windows.Forms.Panel();
            this.weight_100_label = new System.Windows.Forms.Label();
            this.weight_100 = new System.Windows.Forms.PictureBox();
            this.panel_plateweight_1000 = new System.Windows.Forms.Panel();
            this.weight_1000_label = new System.Windows.Forms.Label();
            this.weight_1000 = new System.Windows.Forms.PictureBox();
            this.panel_plateweight_500 = new System.Windows.Forms.Panel();
            this.weight_500_label = new System.Windows.Forms.Label();
            this.weight_500 = new System.Windows.Forms.PictureBox();
            this.balance_rightplate = new System.Windows.Forms.PictureBox();
            this.tutorial_button = new System.Windows.Forms.Button();
            this.debug_arrowX = new System.Windows.Forms.Label();
            this.debug_reached = new System.Windows.Forms.Label();
            this.debug_target = new System.Windows.Forms.Label();
            this.panel_onplate_1000 = new System.Windows.Forms.Panel();
            this.outplate_1000 = new System.Windows.Forms.Button();
            this.onplate_1000 = new System.Windows.Forms.Button();
            this.panel_onplate_500 = new System.Windows.Forms.Panel();
            this.outplate_500 = new System.Windows.Forms.Button();
            this.onplate_500 = new System.Windows.Forms.Button();
            this.panel_onplate_100 = new System.Windows.Forms.Panel();
            this.outplate_100 = new System.Windows.Forms.Button();
            this.onplate_100 = new System.Windows.Forms.Button();
            this.panel_onplate_10 = new System.Windows.Forms.Panel();
            this.outplate_10 = new System.Windows.Forms.Button();
            this.onplate_10 = new System.Windows.Forms.Button();
            this.panel_onplate_5 = new System.Windows.Forms.Panel();
            this.outplate_5 = new System.Windows.Forms.Button();
            this.onplate_5 = new System.Windows.Forms.Button();
            this.panel_onplate_1 = new System.Windows.Forms.Panel();
            this.outplate_1 = new System.Windows.Forms.Button();
            this.onplate_1 = new System.Windows.Forms.Button();
            this.weight_text = new System.Windows.Forms.TextBox();
            this.weight_1000_button = new System.Windows.Forms.Button();
            this.weight_500_button = new System.Windows.Forms.Button();
            this.weight_100_button = new System.Windows.Forms.Button();
            this.weight_10_button = new System.Windows.Forms.Button();
            this.weight_5_button = new System.Windows.Forms.Button();
            this.weight_1_button = new System.Windows.Forms.Button();
            this.panel_plate_left = new System.Windows.Forms.Panel();
            this.weight_result_label = new System.Windows.Forms.Label();
            this.weight_inc = new System.Windows.Forms.PictureBox();
            this.balance_leftplate = new System.Windows.Forms.PictureBox();
            this.undo = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.new_weight = new System.Windows.Forms.Button();
            this.return_menu = new System.Windows.Forms.Button();
            this.panel_options = new System.Windows.Forms.Panel();
            this.max_moves_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maximum_moves_label = new System.Windows.Forms.Label();
            this.save_options_button = new System.Windows.Forms.Button();
            this.title_options = new System.Windows.Forms.Label();
            this.reset_settings_button = new System.Windows.Forms.Button();
            this.color_combobox = new System.Windows.Forms.ComboBox();
            this.return_menu_button = new System.Windows.Forms.Button();
            this.background_color_label = new System.Windows.Forms.Label();
            this.range_to_label = new System.Windows.Forms.Label();
            this.range_from_label = new System.Windows.Forms.Label();
            this.weight_to_combobox = new System.Windows.Forms.NumericUpDown();
            this.weight_from_combobox = new System.Windows.Forms.NumericUpDown();
            this.weight_range_label = new System.Windows.Forms.Label();
            this.language_label = new System.Windows.Forms.Label();
            this.language_combobox = new System.Windows.Forms.ComboBox();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.info_label = new System.Windows.Forms.Label();
            this.info_button = new System.Windows.Forms.Button();
            this.title_label = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_options = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.panel_main.SuspendLayout();
            this.panel_game.SuspendLayout();
            this.panel_win_lost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smile_sad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smile_happy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance_indicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance_body)).BeginInit();
            this.panel_plate_right.SuspendLayout();
            this.panel_plateweight_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight_1)).BeginInit();
            this.panel_plateweight_5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight_5)).BeginInit();
            this.panel_plateweight_10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight_10)).BeginInit();
            this.panel_plateweight_100.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight_100)).BeginInit();
            this.panel_plateweight_1000.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight_1000)).BeginInit();
            this.panel_plateweight_500.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight_500)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance_rightplate)).BeginInit();
            this.panel_onplate_1000.SuspendLayout();
            this.panel_onplate_500.SuspendLayout();
            this.panel_onplate_100.SuspendLayout();
            this.panel_onplate_10.SuspendLayout();
            this.panel_onplate_5.SuspendLayout();
            this.panel_onplate_1.SuspendLayout();
            this.panel_plate_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight_inc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance_leftplate)).BeginInit();
            this.panel_options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_moves_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_to_combobox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_from_combobox)).BeginInit();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_main.Controls.Add(this.panel_game);
            this.panel_main.Controls.Add(this.panel_options);
            this.panel_main.Controls.Add(this.panel_menu);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1916, 881);
            this.panel_main.TabIndex = 1;
            // 
            // panel_game
            // 
            this.panel_game.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_game.Controls.Add(this.panel_win_lost);
            this.panel_game.Controls.Add(this.moves_avaliable_value_label);
            this.panel_game.Controls.Add(this.moves_avaliable_label);
            this.panel_game.Controls.Add(this.debug_label3);
            this.panel_game.Controls.Add(this.debug_label2);
            this.panel_game.Controls.Add(this.debug_label1);
            this.panel_game.Controls.Add(this.debug_label0);
            this.panel_game.Controls.Add(this.balance_indicator);
            this.panel_game.Controls.Add(this.balance_body);
            this.panel_game.Controls.Add(this.panel_plate_right);
            this.panel_game.Controls.Add(this.tutorial_button);
            this.panel_game.Controls.Add(this.debug_arrowX);
            this.panel_game.Controls.Add(this.debug_reached);
            this.panel_game.Controls.Add(this.debug_target);
            this.panel_game.Controls.Add(this.panel_onplate_1000);
            this.panel_game.Controls.Add(this.panel_onplate_500);
            this.panel_game.Controls.Add(this.panel_onplate_100);
            this.panel_game.Controls.Add(this.panel_onplate_10);
            this.panel_game.Controls.Add(this.panel_onplate_5);
            this.panel_game.Controls.Add(this.panel_onplate_1);
            this.panel_game.Controls.Add(this.weight_text);
            this.panel_game.Controls.Add(this.weight_1000_button);
            this.panel_game.Controls.Add(this.weight_500_button);
            this.panel_game.Controls.Add(this.weight_100_button);
            this.panel_game.Controls.Add(this.weight_10_button);
            this.panel_game.Controls.Add(this.weight_5_button);
            this.panel_game.Controls.Add(this.weight_1_button);
            this.panel_game.Controls.Add(this.panel_plate_left);
            this.panel_game.Controls.Add(this.undo);
            this.panel_game.Controls.Add(this.clear);
            this.panel_game.Controls.Add(this.new_weight);
            this.panel_game.Controls.Add(this.return_menu);
            this.panel_game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_game.ForeColor = System.Drawing.Color.White;
            this.panel_game.Location = new System.Drawing.Point(0, 0);
            this.panel_game.Name = "panel_game";
            this.panel_game.Size = new System.Drawing.Size(1916, 881);
            this.panel_game.TabIndex = 1;
            this.panel_game.Visible = false;
            // 
            // panel_win_lost
            // 
            this.panel_win_lost.Controls.Add(this.smile_sad);
            this.panel_win_lost.Controls.Add(this.smile_happy);
            this.panel_win_lost.Controls.Add(this.message_win_lost);
            this.panel_win_lost.Location = new System.Drawing.Point(112, 76);
            this.panel_win_lost.Name = "panel_win_lost";
            this.panel_win_lost.Size = new System.Drawing.Size(1082, 188);
            this.panel_win_lost.TabIndex = 48;
            // 
            // smile_sad
            // 
            this.smile_sad.BackgroundImage = global::BalanceGame.Properties.Resources.sad;
            this.smile_sad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.smile_sad.Location = new System.Drawing.Point(901, 3);
            this.smile_sad.Name = "smile_sad";
            this.smile_sad.Size = new System.Drawing.Size(177, 169);
            this.smile_sad.TabIndex = 2;
            this.smile_sad.TabStop = false;
            // 
            // smile_happy
            // 
            this.smile_happy.BackgroundImage = global::BalanceGame.Properties.Resources.happy;
            this.smile_happy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.smile_happy.Location = new System.Drawing.Point(901, 3);
            this.smile_happy.Name = "smile_happy";
            this.smile_happy.Size = new System.Drawing.Size(178, 171);
            this.smile_happy.TabIndex = 1;
            this.smile_happy.TabStop = false;
            // 
            // message_win_lost
            // 
            this.message_win_lost.AutoSize = true;
            this.message_win_lost.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_win_lost.Location = new System.Drawing.Point(7, 17);
            this.message_win_lost.Name = "message_win_lost";
            this.message_win_lost.Size = new System.Drawing.Size(304, 75);
            this.message_win_lost.TabIndex = 0;
            this.message_win_lost.Text = "Message";
            // 
            // moves_avaliable_value_label
            // 
            this.moves_avaliable_value_label.AutoSize = true;
            this.moves_avaliable_value_label.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moves_avaliable_value_label.Location = new System.Drawing.Point(1719, 36);
            this.moves_avaliable_value_label.Name = "moves_avaliable_value_label";
            this.moves_avaliable_value_label.Size = new System.Drawing.Size(115, 56);
            this.moves_avaliable_value_label.TabIndex = 47;
            this.moves_avaliable_value_label.Text = "Nan";
            // 
            // moves_avaliable_label
            // 
            this.moves_avaliable_label.AutoSize = true;
            this.moves_avaliable_label.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moves_avaliable_label.Location = new System.Drawing.Point(1459, 53);
            this.moves_avaliable_label.Name = "moves_avaliable_label";
            this.moves_avaliable_label.Size = new System.Drawing.Size(248, 34);
            this.moves_avaliable_label.TabIndex = 46;
            this.moves_avaliable_label.Text = "Moves avaliable:";
            // 
            // debug_label3
            // 
            this.debug_label3.AutoSize = true;
            this.debug_label3.Location = new System.Drawing.Point(12, 76);
            this.debug_label3.Name = "debug_label3";
            this.debug_label3.Size = new System.Drawing.Size(47, 13);
            this.debug_label3.TabIndex = 45;
            this.debug_label3.Text = "Arrow_X";
            this.debug_label3.Visible = false;
            // 
            // debug_label2
            // 
            this.debug_label2.AutoSize = true;
            this.debug_label2.Location = new System.Drawing.Point(13, 53);
            this.debug_label2.Name = "debug_label2";
            this.debug_label2.Size = new System.Drawing.Size(47, 13);
            this.debug_label2.TabIndex = 44;
            this.debug_label2.Text = "On plate";
            this.debug_label2.Visible = false;
            // 
            // debug_label1
            // 
            this.debug_label1.AutoSize = true;
            this.debug_label1.Location = new System.Drawing.Point(12, 31);
            this.debug_label1.Name = "debug_label1";
            this.debug_label1.Size = new System.Drawing.Size(38, 13);
            this.debug_label1.TabIndex = 43;
            this.debug_label1.Text = "Target";
            this.debug_label1.Visible = false;
            // 
            // debug_label0
            // 
            this.debug_label0.AutoSize = true;
            this.debug_label0.Location = new System.Drawing.Point(9, 9);
            this.debug_label0.Name = "debug_label0";
            this.debug_label0.Size = new System.Drawing.Size(85, 13);
            this.debug_label0.TabIndex = 42;
            this.debug_label0.Text = "Developer mode";
            this.debug_label0.Visible = false;
            // 
            // balance_indicator
            // 
            this.balance_indicator.BackColor = System.Drawing.Color.Transparent;
            this.balance_indicator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.balance_indicator.Image = global::BalanceGame.Properties.Resources.balance_indicator;
            this.balance_indicator.ImageLocation = "";
            this.balance_indicator.InitialImage = null;
            this.balance_indicator.Location = new System.Drawing.Point(673, 573);
            this.balance_indicator.Name = "balance_indicator";
            this.balance_indicator.Size = new System.Drawing.Size(10, 105);
            this.balance_indicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.balance_indicator.TabIndex = 10;
            this.balance_indicator.TabStop = false;
            // 
            // balance_body
            // 
            this.balance_body.BackColor = System.Drawing.Color.Transparent;
            this.balance_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.balance_body.Image = ((System.Drawing.Image)(resources.GetObject("balance_body.Image")));
            this.balance_body.ImageLocation = "";
            this.balance_body.InitialImage = null;
            this.balance_body.Location = new System.Drawing.Point(12, 519);
            this.balance_body.Name = "balance_body";
            this.balance_body.Size = new System.Drawing.Size(1330, 214);
            this.balance_body.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.balance_body.TabIndex = 2;
            this.balance_body.TabStop = false;
            // 
            // panel_plate_right
            // 
            this.panel_plate_right.Controls.Add(this.panel_plateweight_1);
            this.panel_plate_right.Controls.Add(this.panel_plateweight_5);
            this.panel_plate_right.Controls.Add(this.panel_plateweight_10);
            this.panel_plate_right.Controls.Add(this.panel_plateweight_100);
            this.panel_plate_right.Controls.Add(this.panel_plateweight_1000);
            this.panel_plate_right.Controls.Add(this.panel_plateweight_500);
            this.panel_plate_right.Controls.Add(this.balance_rightplate);
            this.panel_plate_right.Location = new System.Drawing.Point(710, 270);
            this.panel_plate_right.Name = "panel_plate_right";
            this.panel_plate_right.Size = new System.Drawing.Size(500, 300);
            this.panel_plate_right.TabIndex = 41;
            // 
            // panel_plateweight_1
            // 
            this.panel_plateweight_1.Controls.Add(this.weight_1_label);
            this.panel_plateweight_1.Controls.Add(this.weight_1);
            this.panel_plateweight_1.Location = new System.Drawing.Point(36, 5);
            this.panel_plateweight_1.Name = "panel_plateweight_1";
            this.panel_plateweight_1.Size = new System.Drawing.Size(55, 179);
            this.panel_plateweight_1.TabIndex = 30;
            // 
            // weight_1_label
            // 
            this.weight_1_label.AutoSize = true;
            this.weight_1_label.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_1_label.ForeColor = System.Drawing.Color.White;
            this.weight_1_label.Location = new System.Drawing.Point(-3, 20);
            this.weight_1_label.Name = "weight_1_label";
            this.weight_1_label.Size = new System.Drawing.Size(97, 34);
            this.weight_1_label.TabIndex = 37;
            this.weight_1_label.Text = "label1";
            // 
            // weight_1
            // 
            this.weight_1.BackColor = System.Drawing.Color.Transparent;
            this.weight_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weight_1.Image = global::BalanceGame.Properties.Resources.weight_1;
            this.weight_1.ImageLocation = "";
            this.weight_1.InitialImage = null;
            this.weight_1.Location = new System.Drawing.Point(12, 123);
            this.weight_1.Name = "weight_1";
            this.weight_1.Size = new System.Drawing.Size(36, 56);
            this.weight_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weight_1.TabIndex = 36;
            this.weight_1.TabStop = false;
            // 
            // panel_plateweight_5
            // 
            this.panel_plateweight_5.Controls.Add(this.weight_5_label);
            this.panel_plateweight_5.Controls.Add(this.weight_5);
            this.panel_plateweight_5.Location = new System.Drawing.Point(103, 5);
            this.panel_plateweight_5.Name = "panel_plateweight_5";
            this.panel_plateweight_5.Size = new System.Drawing.Size(55, 179);
            this.panel_plateweight_5.TabIndex = 31;
            // 
            // weight_5_label
            // 
            this.weight_5_label.AutoSize = true;
            this.weight_5_label.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_5_label.ForeColor = System.Drawing.Color.White;
            this.weight_5_label.Location = new System.Drawing.Point(-6, 20);
            this.weight_5_label.Name = "weight_5_label";
            this.weight_5_label.Size = new System.Drawing.Size(97, 34);
            this.weight_5_label.TabIndex = 37;
            this.weight_5_label.Text = "label2";
            // 
            // weight_5
            // 
            this.weight_5.BackColor = System.Drawing.Color.Transparent;
            this.weight_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weight_5.Image = global::BalanceGame.Properties.Resources.weight_5;
            this.weight_5.ImageLocation = "";
            this.weight_5.InitialImage = null;
            this.weight_5.Location = new System.Drawing.Point(3, 109);
            this.weight_5.Name = "weight_5";
            this.weight_5.Size = new System.Drawing.Size(49, 70);
            this.weight_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weight_5.TabIndex = 36;
            this.weight_5.TabStop = false;
            // 
            // panel_plateweight_10
            // 
            this.panel_plateweight_10.Controls.Add(this.weight_10_label);
            this.panel_plateweight_10.Controls.Add(this.weight_10);
            this.panel_plateweight_10.Location = new System.Drawing.Point(164, 5);
            this.panel_plateweight_10.Name = "panel_plateweight_10";
            this.panel_plateweight_10.Size = new System.Drawing.Size(57, 179);
            this.panel_plateweight_10.TabIndex = 32;
            // 
            // weight_10_label
            // 
            this.weight_10_label.AutoSize = true;
            this.weight_10_label.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_10_label.ForeColor = System.Drawing.Color.White;
            this.weight_10_label.Location = new System.Drawing.Point(0, 20);
            this.weight_10_label.Name = "weight_10_label";
            this.weight_10_label.Size = new System.Drawing.Size(97, 34);
            this.weight_10_label.TabIndex = 37;
            this.weight_10_label.Text = "label3";
            // 
            // weight_10
            // 
            this.weight_10.BackColor = System.Drawing.Color.Transparent;
            this.weight_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weight_10.Image = global::BalanceGame.Properties.Resources.weight_10;
            this.weight_10.ImageLocation = "";
            this.weight_10.InitialImage = null;
            this.weight_10.Location = new System.Drawing.Point(0, 96);
            this.weight_10.Name = "weight_10";
            this.weight_10.Size = new System.Drawing.Size(54, 83);
            this.weight_10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weight_10.TabIndex = 36;
            this.weight_10.TabStop = false;
            // 
            // panel_plateweight_100
            // 
            this.panel_plateweight_100.Controls.Add(this.weight_100_label);
            this.panel_plateweight_100.Controls.Add(this.weight_100);
            this.panel_plateweight_100.Location = new System.Drawing.Point(227, 5);
            this.panel_plateweight_100.Name = "panel_plateweight_100";
            this.panel_plateweight_100.Size = new System.Drawing.Size(70, 179);
            this.panel_plateweight_100.TabIndex = 33;
            // 
            // weight_100_label
            // 
            this.weight_100_label.AutoSize = true;
            this.weight_100_label.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_100_label.ForeColor = System.Drawing.Color.White;
            this.weight_100_label.Location = new System.Drawing.Point(10, 20);
            this.weight_100_label.Name = "weight_100_label";
            this.weight_100_label.Size = new System.Drawing.Size(97, 34);
            this.weight_100_label.TabIndex = 37;
            this.weight_100_label.Text = "label4";
            // 
            // weight_100
            // 
            this.weight_100.BackColor = System.Drawing.Color.Transparent;
            this.weight_100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weight_100.Image = global::BalanceGame.Properties.Resources.weight_100;
            this.weight_100.ImageLocation = "";
            this.weight_100.InitialImage = null;
            this.weight_100.Location = new System.Drawing.Point(3, 88);
            this.weight_100.Name = "weight_100";
            this.weight_100.Size = new System.Drawing.Size(64, 91);
            this.weight_100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weight_100.TabIndex = 36;
            this.weight_100.TabStop = false;
            // 
            // panel_plateweight_1000
            // 
            this.panel_plateweight_1000.Controls.Add(this.weight_1000_label);
            this.panel_plateweight_1000.Controls.Add(this.weight_1000);
            this.panel_plateweight_1000.Location = new System.Drawing.Point(387, 5);
            this.panel_plateweight_1000.Name = "panel_plateweight_1000";
            this.panel_plateweight_1000.Size = new System.Drawing.Size(81, 179);
            this.panel_plateweight_1000.TabIndex = 35;
            // 
            // weight_1000_label
            // 
            this.weight_1000_label.AutoSize = true;
            this.weight_1000_label.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_1000_label.ForeColor = System.Drawing.Color.White;
            this.weight_1000_label.Location = new System.Drawing.Point(12, 20);
            this.weight_1000_label.Name = "weight_1000_label";
            this.weight_1000_label.Size = new System.Drawing.Size(97, 34);
            this.weight_1000_label.TabIndex = 37;
            this.weight_1000_label.Text = "label6";
            // 
            // weight_1000
            // 
            this.weight_1000.BackColor = System.Drawing.Color.Transparent;
            this.weight_1000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weight_1000.Image = global::BalanceGame.Properties.Resources.weight_1000;
            this.weight_1000.ImageLocation = "";
            this.weight_1000.InitialImage = null;
            this.weight_1000.Location = new System.Drawing.Point(3, 56);
            this.weight_1000.Name = "weight_1000";
            this.weight_1000.Size = new System.Drawing.Size(78, 123);
            this.weight_1000.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weight_1000.TabIndex = 36;
            this.weight_1000.TabStop = false;
            // 
            // panel_plateweight_500
            // 
            this.panel_plateweight_500.Controls.Add(this.weight_500_label);
            this.panel_plateweight_500.Controls.Add(this.weight_500);
            this.panel_plateweight_500.Location = new System.Drawing.Point(303, 5);
            this.panel_plateweight_500.Name = "panel_plateweight_500";
            this.panel_plateweight_500.Size = new System.Drawing.Size(78, 179);
            this.panel_plateweight_500.TabIndex = 34;
            // 
            // weight_500_label
            // 
            this.weight_500_label.AutoSize = true;
            this.weight_500_label.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_500_label.ForeColor = System.Drawing.Color.White;
            this.weight_500_label.Location = new System.Drawing.Point(10, 19);
            this.weight_500_label.Name = "weight_500_label";
            this.weight_500_label.Size = new System.Drawing.Size(97, 34);
            this.weight_500_label.TabIndex = 37;
            this.weight_500_label.Text = "label5";
            // 
            // weight_500
            // 
            this.weight_500.BackColor = System.Drawing.Color.Transparent;
            this.weight_500.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weight_500.Image = global::BalanceGame.Properties.Resources.weight_500;
            this.weight_500.ImageLocation = "";
            this.weight_500.InitialImage = null;
            this.weight_500.Location = new System.Drawing.Point(3, 74);
            this.weight_500.Name = "weight_500";
            this.weight_500.Size = new System.Drawing.Size(72, 108);
            this.weight_500.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weight_500.TabIndex = 36;
            this.weight_500.TabStop = false;
            // 
            // balance_rightplate
            // 
            this.balance_rightplate.BackColor = System.Drawing.Color.Transparent;
            this.balance_rightplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.balance_rightplate.Image = ((System.Drawing.Image)(resources.GetObject("balance_rightplate.Image")));
            this.balance_rightplate.ImageLocation = "";
            this.balance_rightplate.InitialImage = null;
            this.balance_rightplate.Location = new System.Drawing.Point(8, 58);
            this.balance_rightplate.Name = "balance_rightplate";
            this.balance_rightplate.Size = new System.Drawing.Size(488, 242);
            this.balance_rightplate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.balance_rightplate.TabIndex = 8;
            this.balance_rightplate.TabStop = false;
            // 
            // tutorial_button
            // 
            this.tutorial_button.BackgroundImage = global::BalanceGame.Properties.Resources.button_generic;
            this.tutorial_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tutorial_button.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorial_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tutorial_button.Location = new System.Drawing.Point(57, 880);
            this.tutorial_button.Name = "tutorial_button";
            this.tutorial_button.Size = new System.Drawing.Size(239, 56);
            this.tutorial_button.TabIndex = 39;
            this.tutorial_button.Text = "Tutorial";
            this.tutorial_button.UseVisualStyleBackColor = true;
            this.tutorial_button.Click += new System.EventHandler(this.tutorial_button_Click);
            // 
            // debug_arrowX
            // 
            this.debug_arrowX.AutoSize = true;
            this.debug_arrowX.Location = new System.Drawing.Point(65, 76);
            this.debug_arrowX.Name = "debug_arrowX";
            this.debug_arrowX.Size = new System.Drawing.Size(27, 13);
            this.debug_arrowX.TabIndex = 38;
            this.debug_arrowX.Text = "Nan";
            this.debug_arrowX.Visible = false;
            // 
            // debug_reached
            // 
            this.debug_reached.AutoSize = true;
            this.debug_reached.Location = new System.Drawing.Point(65, 53);
            this.debug_reached.Name = "debug_reached";
            this.debug_reached.Size = new System.Drawing.Size(27, 13);
            this.debug_reached.TabIndex = 37;
            this.debug_reached.Text = "Nan";
            this.debug_reached.Visible = false;
            // 
            // debug_target
            // 
            this.debug_target.AutoSize = true;
            this.debug_target.Location = new System.Drawing.Point(65, 31);
            this.debug_target.Name = "debug_target";
            this.debug_target.Size = new System.Drawing.Size(27, 13);
            this.debug_target.TabIndex = 36;
            this.debug_target.Text = "Nan";
            this.debug_target.Visible = false;
            // 
            // panel_onplate_1000
            // 
            this.panel_onplate_1000.BackColor = System.Drawing.Color.Transparent;
            this.panel_onplate_1000.Controls.Add(this.outplate_1000);
            this.panel_onplate_1000.Controls.Add(this.onplate_1000);
            this.panel_onplate_1000.Location = new System.Drawing.Point(1358, 774);
            this.panel_onplate_1000.Name = "panel_onplate_1000";
            this.panel_onplate_1000.Size = new System.Drawing.Size(108, 90);
            this.panel_onplate_1000.TabIndex = 29;
            // 
            // outplate_1000
            // 
            this.outplate_1000.BackColor = System.Drawing.Color.Red;
            this.outplate_1000.BackgroundImage = global::BalanceGame.Properties.Resources.arrow_outplate;
            this.outplate_1000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.outplate_1000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outplate_1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outplate_1000.Location = new System.Drawing.Point(0, 43);
            this.outplate_1000.Name = "outplate_1000";
            this.outplate_1000.Size = new System.Drawing.Size(108, 47);
            this.outplate_1000.TabIndex = 1;
            this.outplate_1000.UseVisualStyleBackColor = false;
            this.outplate_1000.Click += new System.EventHandler(this.outplate_1000_click);
            // 
            // onplate_1000
            // 
            this.onplate_1000.BackColor = System.Drawing.Color.Green;
            this.onplate_1000.BackgroundImage = global::BalanceGame.Properties.Resources.arrow_onplate;
            this.onplate_1000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.onplate_1000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onplate_1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onplate_1000.Location = new System.Drawing.Point(0, 0);
            this.onplate_1000.Name = "onplate_1000";
            this.onplate_1000.Size = new System.Drawing.Size(108, 46);
            this.onplate_1000.TabIndex = 0;
            this.onplate_1000.UseVisualStyleBackColor = false;
            this.onplate_1000.Click += new System.EventHandler(this.onplate_1000_click);
            // 
            // panel_onplate_500
            // 
            this.panel_onplate_500.BackColor = System.Drawing.Color.Transparent;
            this.panel_onplate_500.Controls.Add(this.outplate_500);
            this.panel_onplate_500.Controls.Add(this.onplate_500);
            this.panel_onplate_500.Location = new System.Drawing.Point(1358, 653);
            this.panel_onplate_500.Name = "panel_onplate_500";
            this.panel_onplate_500.Size = new System.Drawing.Size(108, 90);
            this.panel_onplate_500.TabIndex = 28;
            // 
            // outplate_500
            // 
            this.outplate_500.BackColor = System.Drawing.Color.Red;
            this.outplate_500.BackgroundImage = global::BalanceGame.Properties.Resources.arrow_outplate;
            this.outplate_500.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.outplate_500.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outplate_500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outplate_500.Location = new System.Drawing.Point(0, 46);
            this.outplate_500.Name = "outplate_500";
            this.outplate_500.Size = new System.Drawing.Size(108, 44);
            this.outplate_500.TabIndex = 1;
            this.outplate_500.UseVisualStyleBackColor = false;
            this.outplate_500.Click += new System.EventHandler(this.outplate_500_click);
            // 
            // onplate_500
            // 
            this.onplate_500.BackColor = System.Drawing.Color.Green;
            this.onplate_500.BackgroundImage = global::BalanceGame.Properties.Resources.arrow_onplate;
            this.onplate_500.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.onplate_500.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onplate_500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onplate_500.Location = new System.Drawing.Point(0, 0);
            this.onplate_500.Name = "onplate_500";
            this.onplate_500.Size = new System.Drawing.Size(108, 48);
            this.onplate_500.TabIndex = 0;
            this.onplate_500.UseVisualStyleBackColor = false;
            this.onplate_500.Click += new System.EventHandler(this.onplate_500_click);
            // 
            // panel_onplate_100
            // 
            this.panel_onplate_100.BackColor = System.Drawing.Color.Transparent;
            this.panel_onplate_100.Controls.Add(this.outplate_100);
            this.panel_onplate_100.Controls.Add(this.onplate_100);
            this.panel_onplate_100.Location = new System.Drawing.Point(1358, 541);
            this.panel_onplate_100.Name = "panel_onplate_100";
            this.panel_onplate_100.Size = new System.Drawing.Size(108, 88);
            this.panel_onplate_100.TabIndex = 27;
            // 
            // outplate_100
            // 
            this.outplate_100.BackColor = System.Drawing.Color.Red;
            this.outplate_100.BackgroundImage = global::BalanceGame.Properties.Resources.arrow_outplate;
            this.outplate_100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.outplate_100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outplate_100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outplate_100.Location = new System.Drawing.Point(0, 41);
            this.outplate_100.Name = "outplate_100";
            this.outplate_100.Size = new System.Drawing.Size(108, 47);
            this.outplate_100.TabIndex = 1;
            this.outplate_100.UseVisualStyleBackColor = false;
            this.outplate_100.Click += new System.EventHandler(this.outplate_100_click);
            // 
            // onplate_100
            // 
            this.onplate_100.BackColor = System.Drawing.Color.Green;
            this.onplate_100.BackgroundImage = global::BalanceGame.Properties.Resources.arrow_onplate;
            this.onplate_100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.onplate_100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onplate_100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onplate_100.Location = new System.Drawing.Point(0, 0);
            this.onplate_100.Name = "onplate_100";
            this.onplate_100.Size = new System.Drawing.Size(108, 44);
            this.onplate_100.TabIndex = 0;
            this.onplate_100.UseVisualStyleBackColor = false;
            this.onplate_100.Click += new System.EventHandler(this.onplate_100_click);
            // 
            // panel_onplate_10
            // 
            this.panel_onplate_10.BackColor = System.Drawing.Color.Transparent;
            this.panel_onplate_10.Controls.Add(this.outplate_10);
            this.panel_onplate_10.Controls.Add(this.onplate_10);
            this.panel_onplate_10.Location = new System.Drawing.Point(1358, 427);
            this.panel_onplate_10.Name = "panel_onplate_10";
            this.panel_onplate_10.Size = new System.Drawing.Size(108, 86);
            this.panel_onplate_10.TabIndex = 26;
            // 
            // outplate_10
            // 
            this.outplate_10.BackColor = System.Drawing.Color.Red;
            this.outplate_10.BackgroundImage = global::BalanceGame.Properties.Resources.arrow_outplate;
            this.outplate_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.outplate_10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outplate_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outplate_10.Location = new System.Drawing.Point(0, 43);
            this.outplate_10.Name = "outplate_10";
            this.outplate_10.Size = new System.Drawing.Size(108, 43);
            this.outplate_10.TabIndex = 1;
            this.outplate_10.UseVisualStyleBackColor = false;
            this.outplate_10.Click += new System.EventHandler(this.outplate_10_click);
            // 
            // onplate_10
            // 
            this.onplate_10.BackColor = System.Drawing.Color.Green;
            this.onplate_10.BackgroundImage = global::BalanceGame.Properties.Resources.arrow_onplate;
            this.onplate_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.onplate_10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onplate_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onplate_10.Location = new System.Drawing.Point(0, 0);
            this.onplate_10.Name = "onplate_10";
            this.onplate_10.Size = new System.Drawing.Size(108, 45);
            this.onplate_10.TabIndex = 0;
            this.onplate_10.UseVisualStyleBackColor = false;
            this.onplate_10.Click += new System.EventHandler(this.onplate_10_click);
            // 
            // panel_onplate_5
            // 
            this.panel_onplate_5.BackColor = System.Drawing.Color.Transparent;
            this.panel_onplate_5.Controls.Add(this.outplate_5);
            this.panel_onplate_5.Controls.Add(this.onplate_5);
            this.panel_onplate_5.Location = new System.Drawing.Point(1358, 305);
            this.panel_onplate_5.Name = "panel_onplate_5";
            this.panel_onplate_5.Size = new System.Drawing.Size(108, 94);
            this.panel_onplate_5.TabIndex = 25;
            // 
            // outplate_5
            // 
            this.outplate_5.BackColor = System.Drawing.Color.Red;
            this.outplate_5.BackgroundImage = global::BalanceGame.Properties.Resources.arrow_outplate;
            this.outplate_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.outplate_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outplate_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outplate_5.Location = new System.Drawing.Point(0, 48);
            this.outplate_5.Name = "outplate_5";
            this.outplate_5.Size = new System.Drawing.Size(108, 46);
            this.outplate_5.TabIndex = 1;
            this.outplate_5.UseVisualStyleBackColor = false;
            this.outplate_5.Click += new System.EventHandler(this.outplate_5_click);
            // 
            // onplate_5
            // 
            this.onplate_5.BackColor = System.Drawing.Color.Green;
            this.onplate_5.BackgroundImage = global::BalanceGame.Properties.Resources.arrow_onplate;
            this.onplate_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.onplate_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onplate_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onplate_5.Location = new System.Drawing.Point(0, 0);
            this.onplate_5.Name = "onplate_5";
            this.onplate_5.Size = new System.Drawing.Size(108, 50);
            this.onplate_5.TabIndex = 0;
            this.onplate_5.UseVisualStyleBackColor = false;
            this.onplate_5.Click += new System.EventHandler(this.onplate_5_click);
            // 
            // panel_onplate_1
            // 
            this.panel_onplate_1.BackColor = System.Drawing.Color.Transparent;
            this.panel_onplate_1.Controls.Add(this.outplate_1);
            this.panel_onplate_1.Controls.Add(this.onplate_1);
            this.panel_onplate_1.Location = new System.Drawing.Point(1358, 202);
            this.panel_onplate_1.Name = "panel_onplate_1";
            this.panel_onplate_1.Size = new System.Drawing.Size(108, 89);
            this.panel_onplate_1.TabIndex = 24;
            // 
            // outplate_1
            // 
            this.outplate_1.BackColor = System.Drawing.Color.Red;
            this.outplate_1.BackgroundImage = global::BalanceGame.Properties.Resources.arrow_outplate;
            this.outplate_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.outplate_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outplate_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outplate_1.Location = new System.Drawing.Point(0, 46);
            this.outplate_1.Name = "outplate_1";
            this.outplate_1.Size = new System.Drawing.Size(108, 43);
            this.outplate_1.TabIndex = 1;
            this.outplate_1.UseVisualStyleBackColor = false;
            this.outplate_1.Click += new System.EventHandler(this.outplate_1_click);
            // 
            // onplate_1
            // 
            this.onplate_1.BackColor = System.Drawing.Color.Green;
            this.onplate_1.BackgroundImage = global::BalanceGame.Properties.Resources.arrow_onplate;
            this.onplate_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.onplate_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onplate_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onplate_1.Location = new System.Drawing.Point(0, 0);
            this.onplate_1.Name = "onplate_1";
            this.onplate_1.Size = new System.Drawing.Size(108, 47);
            this.onplate_1.TabIndex = 0;
            this.onplate_1.UseVisualStyleBackColor = false;
            this.onplate_1.Click += new System.EventHandler(this.onplate_1_click);
            // 
            // weight_text
            // 
            this.weight_text.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.weight_text.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_text.ForeColor = System.Drawing.SystemColors.Window;
            this.weight_text.Location = new System.Drawing.Point(1472, 131);
            this.weight_text.Name = "weight_text";
            this.weight_text.ReadOnly = true;
            this.weight_text.Size = new System.Drawing.Size(349, 48);
            this.weight_text.TabIndex = 17;
            this.weight_text.Text = "WEIGHTS (in grams)";
            // 
            // weight_1000_button
            // 
            this.weight_1000_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weight_1000_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.weight_1000_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weight_1000_button.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_1000_button.ForeColor = System.Drawing.SystemColors.Window;
            this.weight_1000_button.Image = global::BalanceGame.Properties.Resources.weight_1000;
            this.weight_1000_button.Location = new System.Drawing.Point(1472, 753);
            this.weight_1000_button.Name = "weight_1000_button";
            this.weight_1000_button.Size = new System.Drawing.Size(349, 120);
            this.weight_1000_button.TabIndex = 16;
            this.weight_1000_button.Text = "1000";
            this.weight_1000_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.weight_1000_button.UseVisualStyleBackColor = false;
            this.weight_1000_button.Click += new System.EventHandler(this.weight_1000_button_click);
            // 
            // weight_500_button
            // 
            this.weight_500_button.BackColor = System.Drawing.Color.Transparent;
            this.weight_500_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weight_500_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.weight_500_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weight_500_button.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_500_button.ForeColor = System.Drawing.SystemColors.Window;
            this.weight_500_button.Image = global::BalanceGame.Properties.Resources.weight_500;
            this.weight_500_button.Location = new System.Drawing.Point(1472, 635);
            this.weight_500_button.Name = "weight_500_button";
            this.weight_500_button.Size = new System.Drawing.Size(349, 120);
            this.weight_500_button.TabIndex = 15;
            this.weight_500_button.Text = "500";
            this.weight_500_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.weight_500_button.UseVisualStyleBackColor = false;
            this.weight_500_button.Click += new System.EventHandler(this.weight_500_button_click);
            // 
            // weight_100_button
            // 
            this.weight_100_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weight_100_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.weight_100_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weight_100_button.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_100_button.ForeColor = System.Drawing.SystemColors.Window;
            this.weight_100_button.Image = global::BalanceGame.Properties.Resources.weight_100;
            this.weight_100_button.Location = new System.Drawing.Point(1472, 519);
            this.weight_100_button.Name = "weight_100_button";
            this.weight_100_button.Size = new System.Drawing.Size(349, 120);
            this.weight_100_button.TabIndex = 14;
            this.weight_100_button.Text = "100";
            this.weight_100_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.weight_100_button.UseVisualStyleBackColor = true;
            this.weight_100_button.Click += new System.EventHandler(this.weight_100_button_click);
            // 
            // weight_10_button
            // 
            this.weight_10_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weight_10_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.weight_10_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weight_10_button.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_10_button.ForeColor = System.Drawing.SystemColors.Window;
            this.weight_10_button.Image = global::BalanceGame.Properties.Resources.weight_10;
            this.weight_10_button.Location = new System.Drawing.Point(1472, 406);
            this.weight_10_button.Name = "weight_10_button";
            this.weight_10_button.Size = new System.Drawing.Size(349, 120);
            this.weight_10_button.TabIndex = 13;
            this.weight_10_button.Text = "10";
            this.weight_10_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.weight_10_button.UseVisualStyleBackColor = true;
            this.weight_10_button.Click += new System.EventHandler(this.weight_10_button_click);
            // 
            // weight_5_button
            // 
            this.weight_5_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weight_5_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.weight_5_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weight_5_button.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_5_button.ForeColor = System.Drawing.SystemColors.Window;
            this.weight_5_button.Image = global::BalanceGame.Properties.Resources.weight_5;
            this.weight_5_button.Location = new System.Drawing.Point(1472, 299);
            this.weight_5_button.Name = "weight_5_button";
            this.weight_5_button.Size = new System.Drawing.Size(349, 120);
            this.weight_5_button.TabIndex = 12;
            this.weight_5_button.Text = "5";
            this.weight_5_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.weight_5_button.UseVisualStyleBackColor = true;
            this.weight_5_button.Click += new System.EventHandler(this.weight_5_button_click);
            // 
            // weight_1_button
            // 
            this.weight_1_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weight_1_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.weight_1_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weight_1_button.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_1_button.ForeColor = System.Drawing.SystemColors.Window;
            this.weight_1_button.Image = global::BalanceGame.Properties.Resources.weight_1;
            this.weight_1_button.Location = new System.Drawing.Point(1472, 185);
            this.weight_1_button.Name = "weight_1_button";
            this.weight_1_button.Size = new System.Drawing.Size(349, 120);
            this.weight_1_button.TabIndex = 11;
            this.weight_1_button.Text = "1";
            this.weight_1_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.weight_1_button.UseVisualStyleBackColor = true;
            this.weight_1_button.Click += new System.EventHandler(this.weight_1_button_click);
            // 
            // panel_plate_left
            // 
            this.panel_plate_left.Controls.Add(this.weight_result_label);
            this.panel_plate_left.Controls.Add(this.weight_inc);
            this.panel_plate_left.Controls.Add(this.balance_leftplate);
            this.panel_plate_left.Location = new System.Drawing.Point(112, 270);
            this.panel_plate_left.Name = "panel_plate_left";
            this.panel_plate_left.Size = new System.Drawing.Size(500, 300);
            this.panel_plate_left.TabIndex = 40;
            // 
            // weight_result_label
            // 
            this.weight_result_label.AutoSize = true;
            this.weight_result_label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.weight_result_label.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_result_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.weight_result_label.Location = new System.Drawing.Point(155, 83);
            this.weight_result_label.Name = "weight_result_label";
            this.weight_result_label.Size = new System.Drawing.Size(182, 93);
            this.weight_result_label.TabIndex = 10;
            this.weight_result_label.Text = "?  ?";
            // 
            // weight_inc
            // 
            this.weight_inc.BackColor = System.Drawing.Color.Transparent;
            this.weight_inc.BackgroundImage = global::BalanceGame.Properties.Resources.weight_inc02;
            this.weight_inc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weight_inc.ImageLocation = "";
            this.weight_inc.InitialImage = null;
            this.weight_inc.Location = new System.Drawing.Point(90, 61);
            this.weight_inc.Name = "weight_inc";
            this.weight_inc.Size = new System.Drawing.Size(333, 128);
            this.weight_inc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weight_inc.TabIndex = 9;
            this.weight_inc.TabStop = false;
            // 
            // balance_leftplate
            // 
            this.balance_leftplate.BackColor = System.Drawing.Color.Transparent;
            this.balance_leftplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.balance_leftplate.Image = ((System.Drawing.Image)(resources.GetObject("balance_leftplate.Image")));
            this.balance_leftplate.ImageLocation = "";
            this.balance_leftplate.InitialImage = null;
            this.balance_leftplate.Location = new System.Drawing.Point(13, 58);
            this.balance_leftplate.Name = "balance_leftplate";
            this.balance_leftplate.Size = new System.Drawing.Size(484, 250);
            this.balance_leftplate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.balance_leftplate.TabIndex = 7;
            this.balance_leftplate.TabStop = false;
            // 
            // undo
            // 
            this.undo.BackgroundImage = global::BalanceGame.Properties.Resources.button_undo;
            this.undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.undo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undo.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.undo.Location = new System.Drawing.Point(894, 761);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(239, 95);
            this.undo.TabIndex = 6;
            this.undo.UseVisualStyleBackColor = true;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // clear
            // 
            this.clear.BackgroundImage = global::BalanceGame.Properties.Resources.button_generic;
            this.clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clear.Location = new System.Drawing.Point(615, 761);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(239, 95);
            this.clear.TabIndex = 5;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_click);
            // 
            // new_weight
            // 
            this.new_weight.BackgroundImage = global::BalanceGame.Properties.Resources.button_generic;
            this.new_weight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.new_weight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_weight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_weight.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_weight.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.new_weight.Location = new System.Drawing.Point(335, 761);
            this.new_weight.Name = "new_weight";
            this.new_weight.Size = new System.Drawing.Size(239, 95);
            this.new_weight.TabIndex = 4;
            this.new_weight.Text = "NEW WEIGHT";
            this.new_weight.UseVisualStyleBackColor = true;
            this.new_weight.Click += new System.EventHandler(this.new_weight_click);
            // 
            // return_menu
            // 
            this.return_menu.BackgroundImage = global::BalanceGame.Properties.Resources.button_generic;
            this.return_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.return_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.return_menu.FlatAppearance.BorderSize = 0;
            this.return_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_menu.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_menu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.return_menu.Location = new System.Drawing.Point(57, 761);
            this.return_menu.Name = "return_menu";
            this.return_menu.Size = new System.Drawing.Size(239, 95);
            this.return_menu.TabIndex = 1;
            this.return_menu.Text = "MAIN MENU";
            this.return_menu.UseVisualStyleBackColor = true;
            this.return_menu.Click += new System.EventHandler(this.return_menu_click);
            // 
            // panel_options
            // 
            this.panel_options.Controls.Add(this.max_moves_numericUpDown);
            this.panel_options.Controls.Add(this.maximum_moves_label);
            this.panel_options.Controls.Add(this.save_options_button);
            this.panel_options.Controls.Add(this.title_options);
            this.panel_options.Controls.Add(this.reset_settings_button);
            this.panel_options.Controls.Add(this.color_combobox);
            this.panel_options.Controls.Add(this.return_menu_button);
            this.panel_options.Controls.Add(this.background_color_label);
            this.panel_options.Controls.Add(this.range_to_label);
            this.panel_options.Controls.Add(this.range_from_label);
            this.panel_options.Controls.Add(this.weight_to_combobox);
            this.panel_options.Controls.Add(this.weight_from_combobox);
            this.panel_options.Controls.Add(this.weight_range_label);
            this.panel_options.Controls.Add(this.language_label);
            this.panel_options.Controls.Add(this.language_combobox);
            this.panel_options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_options.ForeColor = System.Drawing.Color.Black;
            this.panel_options.Location = new System.Drawing.Point(0, 0);
            this.panel_options.Name = "panel_options";
            this.panel_options.Size = new System.Drawing.Size(1916, 881);
            this.panel_options.TabIndex = 4;
            // 
            // max_moves_numericUpDown
            // 
            this.max_moves_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_moves_numericUpDown.Location = new System.Drawing.Point(1010, 571);
            this.max_moves_numericUpDown.Name = "max_moves_numericUpDown";
            this.max_moves_numericUpDown.Size = new System.Drawing.Size(121, 53);
            this.max_moves_numericUpDown.TabIndex = 14;
            // 
            // maximum_moves_label
            // 
            this.maximum_moves_label.AutoSize = true;
            this.maximum_moves_label.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.maximum_moves_label.Location = new System.Drawing.Point(654, 578);
            this.maximum_moves_label.Name = "maximum_moves_label";
            this.maximum_moves_label.Size = new System.Drawing.Size(338, 46);
            this.maximum_moves_label.TabIndex = 13;
            this.maximum_moves_label.Text = "Maximum moves";
            // 
            // save_options_button
            // 
            this.save_options_button.BackgroundImage = global::BalanceGame.Properties.Resources.save;
            this.save_options_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save_options_button.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_options_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.save_options_button.Location = new System.Drawing.Point(1230, 675);
            this.save_options_button.Name = "save_options_button";
            this.save_options_button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.save_options_button.Size = new System.Drawing.Size(77, 80);
            this.save_options_button.TabIndex = 12;
            this.save_options_button.UseVisualStyleBackColor = true;
            this.save_options_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // title_options
            // 
            this.title_options.AutoSize = true;
            this.title_options.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_options.Location = new System.Drawing.Point(819, 156);
            this.title_options.Name = "title_options";
            this.title_options.Size = new System.Drawing.Size(312, 91);
            this.title_options.TabIndex = 11;
            this.title_options.Text = "Options";
            this.title_options.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reset_settings_button
            // 
            this.reset_settings_button.BackgroundImage = global::BalanceGame.Properties.Resources.button_generic;
            this.reset_settings_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reset_settings_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_settings_button.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_settings_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.reset_settings_button.Location = new System.Drawing.Point(866, 675);
            this.reset_settings_button.Name = "reset_settings_button";
            this.reset_settings_button.Size = new System.Drawing.Size(241, 80);
            this.reset_settings_button.TabIndex = 9;
            this.reset_settings_button.Text = "Default Settings";
            this.reset_settings_button.UseVisualStyleBackColor = true;
            this.reset_settings_button.Click += new System.EventHandler(this.reset_settings_button_Click);
            // 
            // color_combobox
            // 
            this.color_combobox.BackColor = System.Drawing.SystemColors.Window;
            this.color_combobox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.color_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_combobox.FormattingEnabled = true;
            this.color_combobox.Items.AddRange(new object[] {
            "MenuHighlight",
            "Red",
            "Blue",
            "Lime",
            "Yellow"});
            this.color_combobox.Location = new System.Drawing.Point(1011, 487);
            this.color_combobox.Name = "color_combobox";
            this.color_combobox.Size = new System.Drawing.Size(262, 54);
            this.color_combobox.TabIndex = 8;
            // 
            // return_menu_button
            // 
            this.return_menu_button.BackgroundImage = global::BalanceGame.Properties.Resources.button_generic;
            this.return_menu_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.return_menu_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.return_menu_button.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_menu_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.return_menu_button.Location = new System.Drawing.Point(604, 675);
            this.return_menu_button.Name = "return_menu_button";
            this.return_menu_button.Size = new System.Drawing.Size(190, 80);
            this.return_menu_button.TabIndex = 10;
            this.return_menu_button.Text = "MAIN MENU";
            this.return_menu_button.UseVisualStyleBackColor = true;
            this.return_menu_button.Click += new System.EventHandler(this.return_menu_button_Click);
            // 
            // background_color_label
            // 
            this.background_color_label.AutoSize = true;
            this.background_color_label.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.background_color_label.Location = new System.Drawing.Point(618, 495);
            this.background_color_label.Name = "background_color_label";
            this.background_color_label.Size = new System.Drawing.Size(364, 46);
            this.background_color_label.TabIndex = 7;
            this.background_color_label.Text = "Background Color";
            // 
            // range_to_label
            // 
            this.range_to_label.AutoSize = true;
            this.range_to_label.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.range_to_label.Location = new System.Drawing.Point(1153, 374);
            this.range_to_label.Name = "range_to_label";
            this.range_to_label.Size = new System.Drawing.Size(41, 29);
            this.range_to_label.TabIndex = 6;
            this.range_to_label.Text = "To";
            // 
            // range_from_label
            // 
            this.range_from_label.AutoSize = true;
            this.range_from_label.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.range_from_label.Location = new System.Drawing.Point(1008, 374);
            this.range_from_label.Name = "range_from_label";
            this.range_from_label.Size = new System.Drawing.Size(73, 29);
            this.range_from_label.TabIndex = 5;
            this.range_from_label.Text = "From";
            // 
            // weight_to_combobox
            // 
            this.weight_to_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_to_combobox.Location = new System.Drawing.Point(1156, 406);
            this.weight_to_combobox.Maximum = new decimal(new int[] {
            10001,
            0,
            0,
            0});
            this.weight_to_combobox.Name = "weight_to_combobox";
            this.weight_to_combobox.Size = new System.Drawing.Size(117, 53);
            this.weight_to_combobox.TabIndex = 4;
            // 
            // weight_from_combobox
            // 
            this.weight_from_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_from_combobox.Location = new System.Drawing.Point(1011, 406);
            this.weight_from_combobox.Name = "weight_from_combobox";
            this.weight_from_combobox.Size = new System.Drawing.Size(120, 53);
            this.weight_from_combobox.TabIndex = 3;
            // 
            // weight_range_label
            // 
            this.weight_range_label.AutoSize = true;
            this.weight_range_label.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_range_label.Location = new System.Drawing.Point(627, 403);
            this.weight_range_label.Name = "weight_range_label";
            this.weight_range_label.Size = new System.Drawing.Size(352, 46);
            this.weight_range_label.TabIndex = 2;
            this.weight_range_label.Text = "Weights range (g)";
            // 
            // language_label
            // 
            this.language_label.AutoSize = true;
            this.language_label.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.language_label.Location = new System.Drawing.Point(778, 324);
            this.language_label.Name = "language_label";
            this.language_label.Size = new System.Drawing.Size(204, 46);
            this.language_label.TabIndex = 1;
            this.language_label.Text = "Language";
            // 
            // language_combobox
            // 
            this.language_combobox.AllowDrop = true;
            this.language_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.language_combobox.FormattingEnabled = true;
            this.language_combobox.Items.AddRange(new object[] {
            "English",
            "Italiano"});
            this.language_combobox.Location = new System.Drawing.Point(1011, 313);
            this.language_combobox.Name = "language_combobox";
            this.language_combobox.Size = new System.Drawing.Size(210, 54);
            this.language_combobox.TabIndex = 0;
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_menu.Controls.Add(this.info_label);
            this.panel_menu.Controls.Add(this.info_button);
            this.panel_menu.Controls.Add(this.title_label);
            this.panel_menu.Controls.Add(this.button_exit);
            this.panel_menu.Controls.Add(this.button_options);
            this.panel_menu.Controls.Add(this.button_start);
            this.panel_menu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_menu.ForeColor = System.Drawing.Color.Black;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(1916, 881);
            this.panel_menu.TabIndex = 10;
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_label.Location = new System.Drawing.Point(105, 887);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(191, 39);
            this.info_label.TabIndex = 15;
            this.info_label.Text = "Information";
            this.info_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info_button
            // 
            this.info_button.BackgroundImage = global::BalanceGame.Properties.Resources.button_generic;
            this.info_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.info_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.info_button.FlatAppearance.BorderSize = 4;
            this.info_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_button.Location = new System.Drawing.Point(23, 862);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(69, 64);
            this.info_button.TabIndex = 14;
            this.info_button.Text = "?";
            this.info_button.UseVisualStyleBackColor = true;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(586, 202);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(707, 108);
            this.title_label.TabIndex = 5;
            this.title_label.Text = "Find the weight";
            // 
            // button_exit
            // 
            this.button_exit.BackgroundImage = global::BalanceGame.Properties.Resources.button_generic;
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.Location = new System.Drawing.Point(749, 659);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(365, 98);
            this.button_exit.TabIndex = 13;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_options
            // 
            this.button_options.BackgroundImage = global::BalanceGame.Properties.Resources.button_generic;
            this.button_options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_options.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_options.Location = new System.Drawing.Point(749, 530);
            this.button_options.Name = "button_options";
            this.button_options.Size = new System.Drawing.Size(365, 91);
            this.button_options.TabIndex = 12;
            this.button_options.Text = "Options";
            this.button_options.UseVisualStyleBackColor = true;
            this.button_options.Click += new System.EventHandler(this.button_options_Click);
            // 
            // button_start
            // 
            this.button_start.BackgroundImage = global::BalanceGame.Properties.Resources.button_generic;
            this.button_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(709, 389);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(443, 111);
            this.button_start.TabIndex = 11;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 881);
            this.Controls.Add(this.panel_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Game_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_game.ResumeLayout(false);
            this.panel_game.PerformLayout();
            this.panel_win_lost.ResumeLayout(false);
            this.panel_win_lost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smile_sad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smile_happy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance_indicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance_body)).EndInit();
            this.panel_plate_right.ResumeLayout(false);
            this.panel_plateweight_1.ResumeLayout(false);
            this.panel_plateweight_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight_1)).EndInit();
            this.panel_plateweight_5.ResumeLayout(false);
            this.panel_plateweight_5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight_5)).EndInit();
            this.panel_plateweight_10.ResumeLayout(false);
            this.panel_plateweight_10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight_10)).EndInit();
            this.panel_plateweight_100.ResumeLayout(false);
            this.panel_plateweight_100.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight_100)).EndInit();
            this.panel_plateweight_1000.ResumeLayout(false);
            this.panel_plateweight_1000.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight_1000)).EndInit();
            this.panel_plateweight_500.ResumeLayout(false);
            this.panel_plateweight_500.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight_500)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance_rightplate)).EndInit();
            this.panel_onplate_1000.ResumeLayout(false);
            this.panel_onplate_500.ResumeLayout(false);
            this.panel_onplate_100.ResumeLayout(false);
            this.panel_onplate_10.ResumeLayout(false);
            this.panel_onplate_5.ResumeLayout(false);
            this.panel_onplate_1.ResumeLayout(false);
            this.panel_plate_left.ResumeLayout(false);
            this.panel_plate_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight_inc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance_leftplate)).EndInit();
            this.panel_options.ResumeLayout(false);
            this.panel_options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_moves_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_to_combobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_from_combobox)).EndInit();
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        //private Button button_start;
        private Panel panel_main;
        private Panel panel_game;
		private Button return_menu;
        private PictureBox balance_body;
        private Panel panel_options;
        private Button reset_settings_button;
        private ComboBox color_combobox;
        private Label background_color_label;
        private Label range_to_label;
        private Label range_from_label;
        private NumericUpDown weight_to_combobox;
        private NumericUpDown weight_from_combobox;
        private Label weight_range_label;
        private Label language_label;
        private ComboBox language_combobox;
        private Button return_menu_button;
        private Button clear;
        private Button new_weight;
        private Button undo;
        private PictureBox weight_inc;
        private PictureBox balance_rightplate;
        private PictureBox balance_leftplate;
        private Panel panel_menu;
        private Label title_label;
        private Button button_exit;
        private Button button_options;
        private Button button_start;
        private Label title_options;
        private Label info_label;
        private Button info_button;
        private PictureBox balance_indicator;
        private TextBox weight_text;
        private Button weight_1000_button;
        private Button weight_500_button;
        private Button weight_100_button;
        private Button weight_10_button;
        private Button weight_5_button;
        private Button weight_1_button;
        private Panel panel_onplate_1;
        private Button onplate_1;
        private Panel panel_onplate_1000;
        private Button onplate_1000;
        private Panel panel_onplate_500;
        private Button onplate_500;
        private Panel panel_onplate_100;
        private Button onplate_100;
        private Panel panel_onplate_10;
        private Button onplate_10;
        private Panel panel_onplate_5;
        private Button onplate_5;
        private Panel panel_plateweight_1000;
        private PictureBox weight_1000;
        private Panel panel_plateweight_500;
        private PictureBox weight_500;
        private Panel panel_plateweight_100;
        private PictureBox weight_100;
        private Panel panel_plateweight_10;
        private PictureBox weight_10;
        private Panel panel_plateweight_5;
        private PictureBox weight_5;
        private Panel panel_plateweight_1;
        private PictureBox weight_1;
        private Button save_options_button;
        private Label weight_1000_label;
        private Label weight_500_label;
        private Label weight_100_label;
        private Label weight_10_label;
        private Label weight_5_label;
        private Label weight_1_label;
        private Label debug_reached;
        private Label debug_arrowX;
        private Button tutorial_button;
        private Button outplate_5;
        private Button outplate_1;
        private Button outplate_1000;
        private Button outplate_500;
        private Button outplate_100;
        private Button outplate_10;
        private Panel panel_plate_left;
        private Panel panel_plate_right;
        private Label debug_label3;
        private Label debug_label2;
        private Label debug_label1;
        private Label debug_label0;
        private Label debug_target;
        private NumericUpDown max_moves_numericUpDown;
        private Label maximum_moves_label;
        private Label moves_avaliable_value_label;
        private Label moves_avaliable_label;
        private Label weight_result_label;
        private Panel panel_win_lost;
        private Label message_win_lost;
        private PictureBox smile_happy;
        private PictureBox smile_sad;
    }
}

