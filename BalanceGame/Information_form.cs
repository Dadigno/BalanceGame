using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalanceGame
{
    public partial class Information_form : Form
    {
        Game main_form;
        public Information_form(Game main_form)
        {
            this.main_form = main_form;
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            set_language();
        }
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            main_form.Enabled = true;
        }

        private void set_language()
        {
            if(Globals.language == "English")
            {
                information_title.Text = Globals.label_information_title_default;
                info_text_1.Text = Globals.info_text1_default;
                info_text_2.Text = Globals.info_text2_default;
                info_text_3.Text = Globals.info_text3_default;
                contacts_label.Text = Globals.contacts_label_default;
                contact_email.Text = Globals.label_email;
                this.Text = Globals.caption_information_default;
            }
            else
            {
                information_title.Text = Globals.Configuration_file.Get("label_information_title");
                info_text_1.Text = Globals.Configuration_file.Get("info_text1");
                info_text_2.Text = Globals.Configuration_file.Get("info_text2");
                info_text_3.Text = Globals.Configuration_file.Get("info_text3");
                contacts_label.Text = Globals.Configuration_file.Get("contacts_label");
                contact_email.Text = Globals.Configuration_file.Get("label_email");
                this.Text = Globals.Configuration_file.Get("caption_information");
            }
        }
    }
}
