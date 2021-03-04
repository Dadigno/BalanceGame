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
            this.info_text_1 = new System.Windows.Forms.Label();
            this.info_text_2 = new System.Windows.Forms.Label();
            this.info_text_3 = new System.Windows.Forms.Label();
            this.repo_link = new System.Windows.Forms.LinkLabel();
            this.contacts_label = new System.Windows.Forms.Label();
            this.information_title = new System.Windows.Forms.Label();
            this.contact_email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // info_text_1
            // 
            this.info_text_1.AutoSize = true;
            this.info_text_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_text_1.Location = new System.Drawing.Point(24, 86);
            this.info_text_1.Name = "info_text_1";
            this.info_text_1.Size = new System.Drawing.Size(627, 50);
            this.info_text_1.TabIndex = 1;
            this.info_text_1.Text = "This game was created by Davide Orengo and Giorgio Demarzi. \n A.A. 20-21 Human Co" +
    "mputer Interaction course";
            // 
            // info_text_2
            // 
            this.info_text_2.AutoSize = true;
            this.info_text_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_text_2.Location = new System.Drawing.Point(24, 158);
            this.info_text_2.Name = "info_text_2";
            this.info_text_2.Size = new System.Drawing.Size(574, 25);
            this.info_text_2.TabIndex = 2;
            this.info_text_2.Text = "Contact us if you have encountered problem with the game";
            // 
            // info_text_3
            // 
            this.info_text_3.AutoSize = true;
            this.info_text_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_text_3.Location = new System.Drawing.Point(24, 217);
            this.info_text_3.Name = "info_text_3";
            this.info_text_3.Size = new System.Drawing.Size(269, 25);
            this.info_text_3.TabIndex = 4;
            this.info_text_3.Text = "Share the project, It\'s free!!";
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
            // contacts_label
            // 
            this.contacts_label.AutoSize = true;
            this.contacts_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacts_label.Location = new System.Drawing.Point(25, 319);
            this.contacts_label.Name = "contacts_label";
            this.contacts_label.Size = new System.Drawing.Size(82, 24);
            this.contacts_label.TabIndex = 6;
            this.contacts_label.Text = "Contacts";
            this.contacts_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // information_title
            // 
            this.information_title.AutoSize = true;
            this.information_title.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_title.Location = new System.Drawing.Point(229, 21);
            this.information_title.Name = "information_title";
            this.information_title.Size = new System.Drawing.Size(351, 45);
            this.information_title.TabIndex = 7;
            this.information_title.Text = "Balance Game, V1.1.0";
            // 
            // contact_email
            // 
            this.contact_email.AutoSize = true;
            this.contact_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_email.Location = new System.Drawing.Point(29, 347);
            this.contact_email.Name = "contact_email";
            this.contact_email.Size = new System.Drawing.Size(260, 24);
            this.contact_email.TabIndex = 8;
            this.contact_email.Text = "email@email.it";
            // 
            // Information_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contact_email);
            this.Controls.Add(this.information_title);
            this.Controls.Add(this.contacts_label);
            this.Controls.Add(this.repo_link);
            this.Controls.Add(this.info_text_3);
            this.Controls.Add(this.info_text_2);
            this.Controls.Add(this.info_text_1);
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
        private System.Windows.Forms.Label info_text_1;
        private System.Windows.Forms.Label info_text_2;
        private System.Windows.Forms.Label info_text_3;
        private System.Windows.Forms.LinkLabel repo_link;
        private System.Windows.Forms.Label contacts_label;
        private System.Windows.Forms.Label information_title;
        private System.Windows.Forms.Label contact_email;
    }
}