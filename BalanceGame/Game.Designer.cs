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
            this.button_start = new System.Windows.Forms.Button();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_game = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.return_menu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_menu.SuspendLayout();
            this.panel_game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(350, 112);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(482, 155);
            this.button_start.TabIndex = 0;
            this.button_start.Text = BUTTON_START_TEXT;
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_click);
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.panel_game);
            this.panel_menu.Controls.Add(this.button_start);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(1920, 1061);
            this.panel_menu.TabIndex = 1;
            // 
            // panel_game
            // 
            this.panel_game.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel_game.Controls.Add(this.pictureBox1);
            this.panel_game.Controls.Add(this.return_menu);
            this.panel_game.Controls.Add(this.textBox1);
            this.panel_game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_game.Location = new System.Drawing.Point(0, 0);
            this.panel_game.Name = "panel_game";
            this.panel_game.Size = new System.Drawing.Size(1920, 1061);
            this.panel_game.TabIndex = 1;
            this.panel_game.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::BalanceGame.Properties.Resources.bilancia_prova1;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(130, 352);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(840, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // return_menu
            // 
            this.return_menu.BackgroundImage = global::BalanceGame.Properties.Resources.button_prova;
            this.return_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.return_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.return_menu.FlatAppearance.BorderSize = 0;
            this.return_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_menu.Location = new System.Drawing.Point(45, 600);
            this.return_menu.Name = "return_menu";
            this.return_menu.Size = new System.Drawing.Size(239, 95);
            this.return_menu.TabIndex = 1;
            this.return_menu.UseVisualStyleBackColor = true;
            this.return_menu.Click += new System.EventHandler(this.button_menu_click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(434, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(471, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Questo è il gioco";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.panel_menu);
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "Balance Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Game_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_game.ResumeLayout(false);
            this.panel_game.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_start;
        private Panel panel_menu;
        private Panel panel_game;
        private TextBox textBox1;
        private Button return_menu;
        private PictureBox pictureBox1;
    }
}

