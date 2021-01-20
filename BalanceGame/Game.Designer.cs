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
            //System.Windows.Forms.Panel panel_menu;
            this.button_exit = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_options = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
			this.panel_options = new System.Windows.Forms.Panel();
            this.reset_settings_button = new System.Windows.Forms.Button();
            this.color_combobox = new System.Windows.Forms.ComboBox();
            this.return_menu_button = new System.Windows.Forms.Button();
            this.background_color_label = new System.Windows.Forms.Label();
            this.range_to_label = new System.Windows.Forms.Label();
            this.range_from_label = new System.Windows.Forms.Label();
            this.weight_to = new System.Windows.Forms.NumericUpDown();
            this.weight_from = new System.Windows.Forms.NumericUpDown();
            this.weight_range_label = new System.Windows.Forms.Label();
            this.language_label = new System.Windows.Forms.Label();
            this.language_combobox = new System.Windows.Forms.ComboBox();
            this.panel_game = new System.Windows.Forms.Panel();
			this.weight_inc = new System.Windows.Forms.PictureBox();
            this.balance_rightplate = new System.Windows.Forms.PictureBox();
            this.balance_leftplate = new System.Windows.Forms.PictureBox();
            this.undo = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.new_weight = new System.Windows.Forms.Button();
            this.balance_body = new System.Windows.Forms.PictureBox();
			this.return_menu = new System.Windows.Forms.Button();
            //panel_menu = new System.Windows.Forms.Panel();
            this.panel_menu.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel_menu.SuspendLayout();
            //panel_menu.SuspendLayout();
            this.panel_options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_from)).BeginInit();
            this.panel_game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight_inc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance_rightplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance_leftplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance_body)).BeginInit();
            this.SuspendLayout();
            // 
            //
			// button_exit
            // 
            this.button_exit.BackgroundImage = global::BalanceGame.Properties.Resources.button_generic;
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_exit.Location = new System.Drawing.Point(157, 428);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(384, 77);
            this.button_exit.TabIndex = 3;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // button_start
            // 
            this.button_start.AllowDrop = true;
            this.button_start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_start.BackgroundImage = global::BalanceGame.Properties.Resources.button_generic;
            this.button_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_start.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_start.Location = new System.Drawing.Point(191, 130);
            this.button_start.Margin = new System.Windows.Forms.Padding(0);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(314, 123);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_click);
            // 
            // button_options
            // 
            this.button_options.BackgroundImage = global::BalanceGame.Properties.Resources.button_generic;
            this.button_options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_options.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_options.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_options.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_options.Location = new System.Drawing.Point(157, 308);
            this.button_options.Name = "button_options";
            this.button_options.Size = new System.Drawing.Size(384, 77);
            this.button_options.TabIndex = 2;
            this.button_options.Text = "Options";
            this.button_options.UseVisualStyleBackColor = true;
            this.button_options.Click += new System.EventHandler(this.button_options_Click);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel_main.Controls.Add(this.title_label);
			this.panel_main.Controls.Add(this.panel_options);
            this.panel_main.Controls.Add(this.panel_game);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1920, 1061);
            this.panel_main.TabIndex = 1;
            // 
            // panel_options
            // 

			// 
            // panel_menu
            // 
			panel_menu.Controls.Add(this.button_exit);
            panel_menu.Controls.Add(this.button_start);
            panel_menu.Controls.Add(this.button_options);
            panel_menu.Location = new System.Drawing.Point(713, 119);
            panel_menu.Name = "panel_menu";
            panel_menu.Size = new System.Drawing.Size(631, 686);
            panel_menu.TabIndex = 11;
            // 
            // panel_options
            // 
            this.panel_options.Controls.Add(this.reset_settings_button);
            this.panel_options.Controls.Add(this.color_combobox);
            this.panel_options.Controls.Add(this.return_menu_button);
            this.panel_options.Controls.Add(this.background_color_label);
            this.panel_options.Controls.Add(this.range_to_label);
            this.panel_options.Controls.Add(this.range_from_label);
            this.panel_options.Controls.Add(this.weight_to);
            this.panel_options.Controls.Add(this.weight_from);
            this.panel_options.Controls.Add(this.weight_range_label);
            this.panel_options.Controls.Add(this.language_label);
            this.panel_options.Controls.Add(this.language_combobox);
			this.panel_options.TabIndex = 4;
            this.panel_options.Visible = false;
            // 
            // reset_settings_button
            // 
            this.reset_settings_button.BackgroundImage = global::BalanceGame.Properties.Resources.button_generic;
            this.reset_settings_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reset_settings_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_settings_button.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_settings_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.reset_settings_button.Location = new System.Drawing.Point(240, 434);
            this.reset_settings_button.Name = "reset_settings_button";
            this.reset_settings_button.Size = new System.Drawing.Size(224, 86);
            this.reset_settings_button.TabIndex = 9;
            this.reset_settings_button.Text = "Reset Default Settings";
            this.reset_settings_button.UseVisualStyleBackColor = true;
            // 
            // color_combobox
            // 
            this.color_combobox.FormattingEnabled = true;
            this.color_combobox.Location = new System.Drawing.Point(396, 308);
            this.color_combobox.Name = "color_combobox";
            this.color_combobox.Size = new System.Drawing.Size(148, 21);
            this.color_combobox.TabIndex = 8;
            // 
            // return_menu_button
            // 
            this.return_menu_button.BackgroundImage = global::BalanceGame.Properties.Resources.button_generic;
            this.return_menu_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.return_menu_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.return_menu_button.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_menu_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.return_menu_button.Location = new System.Drawing.Point(29, 605);
            this.return_menu_button.Name = "return_menu_button";
            this.return_menu_button.Size = new System.Drawing.Size(75, 59);
            this.return_menu_button.TabIndex = 10;
            this.return_menu_button.Text = "<--";
            this.return_menu_button.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.return_menu_button.UseVisualStyleBackColor = true;
            this.return_menu_button.Click += new System.EventHandler(this.return_menu_button_Click);
            // 
            // background_color_label
            // 
            this.background_color_label.AutoSize = true;
            this.background_color_label.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.background_color_label.Location = new System.Drawing.Point(14, 290);
            this.background_color_label.Name = "background_color_label";
            this.background_color_label.Size = new System.Drawing.Size(364, 46);
            this.background_color_label.TabIndex = 7;
            this.background_color_label.Text = "Background Color";
            // 
            // range_to_label
            // 
            this.range_to_label.AutoSize = true;
            this.range_to_label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.range_to_label.Location = new System.Drawing.Point(478, 196);
            this.range_to_label.Name = "range_to_label";
            this.range_to_label.Size = new System.Drawing.Size(28, 19);
            this.range_to_label.TabIndex = 6;
            this.range_to_label.Text = "To";
            // 
            // range_from_label
            // 
            this.range_from_label.AutoSize = true;
            this.range_from_label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.range_from_label.Location = new System.Drawing.Point(392, 196);
            this.range_from_label.Name = "range_from_label";
            this.range_from_label.Size = new System.Drawing.Size(49, 19);
            this.range_from_label.TabIndex = 5;
            this.range_from_label.Text = "From";
            // 
            // weight_to
            // 
            this.weight_to.Location = new System.Drawing.Point(482, 222);
            this.weight_to.Name = "weight_to";
            this.weight_to.Size = new System.Drawing.Size(62, 20);
            this.weight_to.TabIndex = 4;
            // 
            // weight_from
            // 
            this.weight_from.Location = new System.Drawing.Point(396, 222);
            this.weight_from.Name = "weight_from";
            this.weight_from.Size = new System.Drawing.Size(68, 20);
            this.weight_from.TabIndex = 3;
            // 
            // weight_range_label
            // 
            this.weight_range_label.AutoSize = true;
            this.weight_range_label.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_range_label.Location = new System.Drawing.Point(101, 198);
            this.weight_range_label.Name = "weight_range_label";
            this.weight_range_label.Size = new System.Drawing.Size(269, 46);
            this.weight_range_label.TabIndex = 2;
            this.weight_range_label.Text = "Weight range";
            // 
            // language_label
            // 
            this.language_label.AutoSize = true;
            this.language_label.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.language_label.Location = new System.Drawing.Point(161, 119);
            this.language_label.Name = "language_label";
            this.language_label.Size = new System.Drawing.Size(204, 46);
            this.language_label.TabIndex = 1;
            this.language_label.Text = "Language";
            // 
            // language_combobox
            // 
            this.language_combobox.AllowDrop = true;
            this.language_combobox.FormattingEnabled = true;
            this.language_combobox.Location = new System.Drawing.Point(396, 142);
            this.language_combobox.Name = "language_combobox";
            this.language_combobox.Size = new System.Drawing.Size(148, 21);
            this.language_combobox.TabIndex = 0;
            // 
            // panel_game
            // 
            this.panel_game.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel_game.Controls.Add(this.weight_inc);
            this.panel_game.Controls.Add(this.balance_rightplate);
            this.panel_game.Controls.Add(this.balance_leftplate);
            this.panel_game.Controls.Add(this.undo);
            this.panel_game.Controls.Add(this.clear);
            this.panel_game.Controls.Add(this.new_weight);
            this.panel_game.Controls.Add(this.balance_body);
            this.panel_game.Controls.Add(this.return_menu);
            this.panel_game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_game.Location = new System.Drawing.Point(0, 0);
            this.panel_game.Name = "panel_game";
            this.panel_game.Size = new System.Drawing.Size(1920, 1061);
            this.panel_game.TabIndex = 1;
            this.panel_game.Visible = false;
            // 
			// 
            this.weight_inc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weight_inc.Image = global::BalanceGame.Properties.Resources.weight_inc;
            this.weight_inc.ImageLocation = "";
            this.weight_inc.InitialImage = null;
            this.weight_inc.Location = new System.Drawing.Point(268, 341);
            this.weight_inc.Name = "weight_inc";
            this.weight_inc.Size = new System.Drawing.Size(171, 96);
            this.weight_inc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weight_inc.TabIndex = 9;
            this.weight_inc.TabStop = false;
            // 
            // balance_rightplate
            // 
            this.balance_rightplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.balance_rightplate.Image = global::BalanceGame.Properties.Resources.balance_plate;
            this.balance_rightplate.ImageLocation = "";
            this.balance_rightplate.InitialImage = null;
            this.balance_rightplate.Location = new System.Drawing.Point(625, 325);
            this.balance_rightplate.Name = "balance_rightplate";
            this.balance_rightplate.Size = new System.Drawing.Size(307, 130);
            this.balance_rightplate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.balance_rightplate.TabIndex = 8;
            this.balance_rightplate.TabStop = false;
            // 
            // balance_leftplate
            // 
            this.balance_leftplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.balance_leftplate.Image = global::BalanceGame.Properties.Resources.balance_plate;
            this.balance_leftplate.ImageLocation = "";
            this.balance_leftplate.InitialImage = null;
            this.balance_leftplate.Location = new System.Drawing.Point(198, 325);
            this.balance_leftplate.Name = "balance_leftplate";
            this.balance_leftplate.Size = new System.Drawing.Size(307, 130);
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
            this.undo.Location = new System.Drawing.Point(989, 786);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(239, 95);
            this.undo.TabIndex = 6;
            this.undo.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.BackgroundImage = global::BalanceGame.Properties.Resources.button_generic;
            this.clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clear.Location = new System.Drawing.Point(713, 786);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(239, 95);
            this.clear.TabIndex = 5;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // new_weight
            // 
            this.new_weight.BackgroundImage = global::BalanceGame.Properties.Resources.button_generic;
            this.new_weight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.new_weight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_weight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_weight.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_weight.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.new_weight.Location = new System.Drawing.Point(439, 786);
            this.new_weight.Name = "new_weight";
            this.new_weight.Size = new System.Drawing.Size(239, 95);
            this.new_weight.TabIndex = 4;
            this.new_weight.Text = "NEW WEIGHT";
            this.new_weight.UseVisualStyleBackColor = true;
            // 
            // balance_body
            // 
            this.balance_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.balance_body.Image = global::BalanceGame.Properties.Resources.balance_body;
            this.balance_body.ImageLocation = "";
            this.balance_body.InitialImage = null;
            this.balance_body.Location = new System.Drawing.Point(145, 455);
            this.balance_body.Name = "balance_body";
            this.balance_body.Size = new System.Drawing.Size(840, 169);
            this.balance_body.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.balance_body.TabIndex = 2;
            this.balance_body.TabStop = false;
            // 
            // return_menu
            // 
            this.return_menu.BackgroundImage = global::BalanceGame.Properties.Resources.button_generic;
            this.return_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.return_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.return_menu.FlatAppearance.BorderSize = 0;
            this.return_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_menu.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_menu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.return_menu.Location = new System.Drawing.Point(145, 786);
            this.return_menu.Name = "return_menu";
            this.return_menu.Size = new System.Drawing.Size(239, 95);
            this.return_menu.TabIndex = 1;
            this.return_menu.Text = "MAIN MENU";
            this.return_menu.UseVisualStyleBackColor = true;
            this.return_menu.Click += new System.EventHandler(this.button_menu_click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.panel_main);
            this.MaximizeBox = false;
            this.Name = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Game_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            panel_menu.ResumeLayout(false);
            this.panel_options.ResumeLayout(false);
            this.panel_options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_from)).EndInit();
            this.panel_game.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weight_inc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance_rightplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance_leftplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance_body)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_start;
        private Panel panel_menu;
        private Panel panel_main;
        private Panel panel_menu;
        private Panel panel_game;
		private Button return_menu;
        private PictureBox balance_body;
        private Label title_label;
        private Button button_exit;
        private Button button_options;
        private Panel panel_options;
        private Button reset_settings_button;
        private ComboBox color_combobox;
        private Label background_color_label;
        private Label range_to_label;
        private Label range_from_label;
        private NumericUpDown weight_to;
        private NumericUpDown weight_from;
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
    }
}

