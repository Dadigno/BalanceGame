namespace BalanceGame
{
    partial class Information_form
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
            this.info_text1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.repo_link = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // info_text1
            // 
            this.info_text1.AutoSize = true;
            this.info_text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_text1.Location = new System.Drawing.Point(24, 86);
            this.info_text1.Name = "info_text1";
            this.info_text1.Size = new System.Drawing.Size(627, 50);
            this.info_text1.TabIndex = 1;
            this.info_text1.Text = "This game was created by Davide Orengo and Giorgio Demarzi. \n A.A. 20-21 Human Co" +
    "mputer Interaction course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contact us if you have encountered problem with the game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Share the project, It\'s free!!";
            // 
            // repo_link
            // 
            this.repo_link.AutoSize = true;
            this.repo_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repo_link.Location = new System.Drawing.Point(24, 251);
            this.repo_link.Name = "repo_link";
            this.repo_link.Size = new System.Drawing.Size(366, 25);
            this.repo_link.TabIndex = 5;
            this.repo_link.TabStop = true;
            this.repo_link.Text = "www.github.it/Dadigno/BalanceGame";
            this.repo_link.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contacts";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 45);
            this.label4.TabIndex = 7;
            this.label4.Text = "Balance Game, V1.1.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "umbrellacorp@cinqueggi.gov";
            // 
            // Information_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.repo_link);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.info_text1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Information_form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About the Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label info_text1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel repo_link;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}