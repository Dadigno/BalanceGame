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
            this.SuspendLayout();
            // 
            // skip_button
            // 
            this.skip_button.Location = new System.Drawing.Point(377, 778);
            this.skip_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.skip_button.Name = "skip_button";
            this.skip_button.Size = new System.Drawing.Size(147, 30);
            this.skip_button.TabIndex = 0;
            this.skip_button.Text = "Skip tutorial";
            this.skip_button.UseVisualStyleBackColor = true;
            this.skip_button.Click += new System.EventHandler(this.skip_button_Click);
            // 
            // next_tutorial_button
            // 
            this.next_tutorial_button.Location = new System.Drawing.Point(760, 736);
            this.next_tutorial_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.next_tutorial_button.Name = "next_tutorial_button";
            this.next_tutorial_button.Size = new System.Drawing.Size(136, 72);
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
            this.title_tutorial_label.Location = new System.Drawing.Point(294, 9);
            this.title_tutorial_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_tutorial_label.Name = "title_tutorial_label";
            this.title_tutorial_label.Size = new System.Drawing.Size(254, 73);
            this.title_tutorial_label.TabIndex = 2;
            this.title_tutorial_label.Text = "Tutorial";
            // 
            // tutorial_textbox
            // 
            this.tutorial_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorial_textbox.Location = new System.Drawing.Point(13, 87);
            this.tutorial_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tutorial_textbox.Name = "tutorial_textbox";
            this.tutorial_textbox.ReadOnly = true;
            this.tutorial_textbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tutorial_textbox.Size = new System.Drawing.Size(883, 639);
            this.tutorial_textbox.TabIndex = 0;
            this.tutorial_textbox.Text = "";
            // 
            // prev_tutorial_button
            // 
            this.prev_tutorial_button.Location = new System.Drawing.Point(13, 736);
            this.prev_tutorial_button.Name = "prev_tutorial_button";
            this.prev_tutorial_button.Size = new System.Drawing.Size(136, 72);
            this.prev_tutorial_button.TabIndex = 3;
            this.prev_tutorial_button.Text = "Prev";
            this.prev_tutorial_button.UseVisualStyleBackColor = true;
            this.prev_tutorial_button.Click += new System.EventHandler(this.prev_tutorial_button_Click);
            // 
            // page_counter_label
            // 
            this.page_counter_label.AutoSize = true;
            this.page_counter_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page_counter_label.Location = new System.Drawing.Point(424, 731);
            this.page_counter_label.Name = "page_counter_label";
            this.page_counter_label.Size = new System.Drawing.Size(52, 31);
            this.page_counter_label.TabIndex = 4;
            this.page_counter_label.Text = "0/0";
            this.page_counter_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tutorial_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(909, 835);
            this.Controls.Add(this.page_counter_label);
            this.Controls.Add(this.prev_tutorial_button);
            this.Controls.Add(this.tutorial_textbox);
            this.Controls.Add(this.title_tutorial_label);
            this.Controls.Add(this.next_tutorial_button);
            this.Controls.Add(this.skip_button);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tutorial_form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutorial";
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
    }
}