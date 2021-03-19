namespace BalanceGame
{
    partial class Tutorial_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.skip_button = new System.Windows.Forms.Button();
            this.next_tutorial_button = new System.Windows.Forms.Button();
            this.title_tutorial_label = new System.Windows.Forms.Label();
            this.tutorial_textbox = new System.Windows.Forms.RichTextBox();
            this.prev_tutorial_button = new System.Windows.Forms.Button();
            this.page_counter_label = new System.Windows.Forms.Label();
            this.panel_tutorial001 = new System.Windows.Forms.Panel();
            this.tutorial_image001 = new System.Windows.Forms.PictureBox();
            this.panel_tutorial002 = new System.Windows.Forms.Panel();
            this.tutorial_image002 = new System.Windows.Forms.PictureBox();
            this.panel_tutorial004 = new System.Windows.Forms.Panel();
            this.tutorial_image004 = new System.Windows.Forms.PictureBox();
            this.panel_tutorial003 = new System.Windows.Forms.Panel();
            this.tutorial_image003 = new System.Windows.Forms.PictureBox();
            this.panel_tutorial005 = new System.Windows.Forms.Panel();
            this.tutorial_image005 = new System.Windows.Forms.PictureBox();
            this.panel_tutorial001.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tutorial_image001)).BeginInit();
            this.panel_tutorial002.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tutorial_image002)).BeginInit();
            this.panel_tutorial004.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tutorial_image004)).BeginInit();
            this.panel_tutorial003.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tutorial_image003)).BeginInit();
            this.panel_tutorial005.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tutorial_image005)).BeginInit();
            this.SuspendLayout();
            // 
            // skip_button
            // 
            this.skip_button.Location = new System.Drawing.Point(252, 511);
            this.skip_button.Name = "skip_button";
            this.skip_button.Size = new System.Drawing.Size(97, 25);
            this.skip_button.TabIndex = 0;
            this.skip_button.Text = "Skip tutorial";
            this.skip_button.UseVisualStyleBackColor = true;
            this.skip_button.Click += new System.EventHandler(this.skip_button_Click);
            // 
            // next_tutorial_button
            // 
            this.next_tutorial_button.Location = new System.Drawing.Point(507, 478);
            this.next_tutorial_button.Name = "next_tutorial_button";
            this.next_tutorial_button.Size = new System.Drawing.Size(91, 47);
            this.next_tutorial_button.TabIndex = 1;
            this.next_tutorial_button.Text = "Next";
            this.next_tutorial_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.next_tutorial_button.UseVisualStyleBackColor = true;
            this.next_tutorial_button.Click += new System.EventHandler(this.next_tutorial_button_Click);
            // 
            // title_tutorial_label
            // 
            this.title_tutorial_label.AutoSize = true;
            this.title_tutorial_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_tutorial_label.Location = new System.Drawing.Point(187, -4);
            this.title_tutorial_label.Name = "title_tutorial_label";
            this.title_tutorial_label.Size = new System.Drawing.Size(254, 73);
            this.title_tutorial_label.TabIndex = 2;
            this.title_tutorial_label.Text = "Tutorial";
            // 
            // tutorial_textbox
            // 
            this.tutorial_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorial_textbox.Location = new System.Drawing.Point(9, 72);
            this.tutorial_textbox.Name = "tutorial_textbox";
            this.tutorial_textbox.ReadOnly = true;
            this.tutorial_textbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tutorial_textbox.Size = new System.Drawing.Size(590, 402);
            this.tutorial_textbox.TabIndex = 0;
            this.tutorial_textbox.Text = "";
            // 
            // prev_tutorial_button
            // 
            this.prev_tutorial_button.Location = new System.Drawing.Point(9, 478);
            this.prev_tutorial_button.Margin = new System.Windows.Forms.Padding(2);
            this.prev_tutorial_button.Name = "prev_tutorial_button";
            this.prev_tutorial_button.Size = new System.Drawing.Size(91, 47);
            this.prev_tutorial_button.TabIndex = 3;
            this.prev_tutorial_button.Text = "Prev";
            this.prev_tutorial_button.UseVisualStyleBackColor = true;
            this.prev_tutorial_button.Click += new System.EventHandler(this.prev_tutorial_button_Click);
            // 
            // page_counter_label
            // 
            this.page_counter_label.AutoSize = true;
            this.page_counter_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page_counter_label.Location = new System.Drawing.Point(273, 477);
            this.page_counter_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.page_counter_label.Name = "page_counter_label";
            this.page_counter_label.Size = new System.Drawing.Size(52, 31);
            this.page_counter_label.TabIndex = 4;
            this.page_counter_label.Text = "0/0";
            this.page_counter_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_tutorial001
            // 
            this.panel_tutorial001.Controls.Add(this.tutorial_image001);
            this.panel_tutorial001.Location = new System.Drawing.Point(146, 215);
            this.panel_tutorial001.Name = "panel_tutorial001";
            this.panel_tutorial001.Size = new System.Drawing.Size(315, 143);
            this.panel_tutorial001.TabIndex = 5;
            // 
            // tutorial_image001
            // 
            this.tutorial_image001.BackgroundImage = global::BalanceGame.Properties.Resources._0011;
            this.tutorial_image001.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tutorial_image001.Location = new System.Drawing.Point(6, 5);
            this.tutorial_image001.Name = "tutorial_image001";
            this.tutorial_image001.Size = new System.Drawing.Size(309, 138);
            this.tutorial_image001.TabIndex = 0;
            this.tutorial_image001.TabStop = false;
            // 
            // panel_tutorial002
            // 
            this.panel_tutorial002.Controls.Add(this.tutorial_image002);
            this.panel_tutorial002.Location = new System.Drawing.Point(379, 112);
            this.panel_tutorial002.Name = "panel_tutorial002";
            this.panel_tutorial002.Size = new System.Drawing.Size(215, 349);
            this.panel_tutorial002.TabIndex = 6;
            // 
            // tutorial_image002
            // 
            this.tutorial_image002.BackgroundImage = global::BalanceGame.Properties.Resources._002;
            this.tutorial_image002.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tutorial_image002.Location = new System.Drawing.Point(17, 32);
            this.tutorial_image002.Name = "tutorial_image002";
            this.tutorial_image002.Size = new System.Drawing.Size(195, 314);
            this.tutorial_image002.TabIndex = 0;
            this.tutorial_image002.TabStop = false;
            // 
            // panel_tutorial004
            // 
            this.panel_tutorial004.Controls.Add(this.tutorial_image004);
            this.panel_tutorial004.Location = new System.Drawing.Point(24, 400);
            this.panel_tutorial004.Name = "panel_tutorial004";
            this.panel_tutorial004.Size = new System.Drawing.Size(565, 51);
            this.panel_tutorial004.TabIndex = 8;
            // 
            // tutorial_image004
            // 
            this.tutorial_image004.BackgroundImage = global::BalanceGame.Properties.Resources._004;
            this.tutorial_image004.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tutorial_image004.Location = new System.Drawing.Point(-3, 3);
            this.tutorial_image004.Name = "tutorial_image004";
            this.tutorial_image004.Size = new System.Drawing.Size(565, 50);
            this.tutorial_image004.TabIndex = 0;
            this.tutorial_image004.TabStop = false;
            // 
            // panel_tutorial003
            // 
            this.panel_tutorial003.Controls.Add(this.tutorial_image003);
            this.panel_tutorial003.Location = new System.Drawing.Point(23, 297);
            this.panel_tutorial003.Name = "panel_tutorial003";
            this.panel_tutorial003.Size = new System.Drawing.Size(570, 163);
            this.panel_tutorial003.TabIndex = 7;
            // 
            // tutorial_image003
            // 
            this.tutorial_image003.BackgroundImage = global::BalanceGame.Properties.Resources._003;
            this.tutorial_image003.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tutorial_image003.Location = new System.Drawing.Point(0, 3);
            this.tutorial_image003.Name = "tutorial_image003";
            this.tutorial_image003.Size = new System.Drawing.Size(567, 157);
            this.tutorial_image003.TabIndex = 0;
            this.tutorial_image003.TabStop = false;
            // 
            // panel_tutorial005
            // 
            this.panel_tutorial005.Controls.Add(this.tutorial_image005);
            this.panel_tutorial005.Location = new System.Drawing.Point(25, 292);
            this.panel_tutorial005.Name = "panel_tutorial005";
            this.panel_tutorial005.Size = new System.Drawing.Size(565, 180);
            this.panel_tutorial005.TabIndex = 9;
            // 
            // tutorial_image005
            // 
            this.tutorial_image005.BackgroundImage = global::BalanceGame.Properties.Resources._005;
            this.tutorial_image005.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tutorial_image005.Location = new System.Drawing.Point(141, 3);
            this.tutorial_image005.Name = "tutorial_image005";
            this.tutorial_image005.Size = new System.Drawing.Size(275, 97);
            this.tutorial_image005.TabIndex = 0;
            this.tutorial_image005.TabStop = false;
            // 
            // Tutorial_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(606, 543);
            this.Controls.Add(this.panel_tutorial004);
            this.Controls.Add(this.panel_tutorial005);
            this.Controls.Add(this.panel_tutorial003);
            this.Controls.Add(this.panel_tutorial002);
            this.Controls.Add(this.panel_tutorial001);
            this.Controls.Add(this.page_counter_label);
            this.Controls.Add(this.prev_tutorial_button);
            this.Controls.Add(this.tutorial_textbox);
            this.Controls.Add(this.title_tutorial_label);
            this.Controls.Add(this.next_tutorial_button);
            this.Controls.Add(this.skip_button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tutorial_form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutorial";
            this.panel_tutorial001.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tutorial_image001)).EndInit();
            this.panel_tutorial002.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tutorial_image002)).EndInit();
            this.panel_tutorial004.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tutorial_image004)).EndInit();
            this.panel_tutorial003.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tutorial_image003)).EndInit();
            this.panel_tutorial005.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tutorial_image005)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button skip_button;
        private System.Windows.Forms.Button next_tutorial_button;
        private System.Windows.Forms.Label title_tutorial_label;
        private System.Windows.Forms.RichTextBox tutorial_textbox;
        private System.Windows.Forms.Button prev_tutorial_button;
        private System.Windows.Forms.Label page_counter_label;
        private System.Windows.Forms.Panel panel_tutorial001;
        private System.Windows.Forms.PictureBox tutorial_image001;
        private System.Windows.Forms.Panel panel_tutorial002;
        private System.Windows.Forms.PictureBox tutorial_image002;
        private System.Windows.Forms.Panel panel_tutorial004;
        private System.Windows.Forms.PictureBox tutorial_image004;
        private System.Windows.Forms.Panel panel_tutorial003;
        private System.Windows.Forms.PictureBox tutorial_image003;
        private System.Windows.Forms.Panel panel_tutorial005;
        private System.Windows.Forms.PictureBox tutorial_image005;
    }
}