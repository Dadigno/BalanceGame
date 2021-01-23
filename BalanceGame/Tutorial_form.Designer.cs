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
            this.next_button = new System.Windows.Forms.Button();
            this.title_tutorial_label = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // skip_button
            // 
            this.skip_button.Location = new System.Drawing.Point(12, 484);
            this.skip_button.Name = "skip_button";
            this.skip_button.Size = new System.Drawing.Size(98, 47);
            this.skip_button.TabIndex = 0;
            this.skip_button.Text = "Skip tutorial";
            this.skip_button.UseVisualStyleBackColor = true;
            this.skip_button.Click += new System.EventHandler(this.skip_button_Click);
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(461, 484);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(104, 47);
            this.next_button.TabIndex = 1;
            this.next_button.Text = "Next tip";
            this.next_button.UseVisualStyleBackColor = true;
            // 
            // title_tutorial_label
            // 
            this.title_tutorial_label.AutoSize = true;
            this.title_tutorial_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_tutorial_label.Location = new System.Drawing.Point(204, 9);
            this.title_tutorial_label.Name = "title_tutorial_label";
            this.title_tutorial_label.Size = new System.Drawing.Size(150, 42);
            this.title_tutorial_label.TabIndex = 2;
            this.title_tutorial_label.Text = "Tutorial";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 84);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(553, 386);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Benvenuto in questo tutorial in cui imparerare come giocare a Balance Game.\n\nSe vu" +
    "oi puoi chiudere questa finestra cliccando sul tasto Skip in basso a sinistra, altrimenti continua su Next";
            // 
            // Tutorial_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 543);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.title_tutorial_label);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.skip_button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tutorial_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button skip_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Label title_tutorial_label;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}