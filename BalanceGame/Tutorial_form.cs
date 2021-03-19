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
    public partial class Tutorial_form : Form
    {
        Game main_form;
        int page;
        int MAX_PAGE = 6;

        public Tutorial_form(Game main_form)
        {
            set_language();


            this.main_form = main_form;
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            prev_tutorial_button.Enabled = false;
            next_tutorial_button.Enabled = true;
            page = 1;
            tutorial_textbox.Text = Globals.tutorial_text_intro_default;
            page_counter_label.Text = page + "\\" + MAX_PAGE;
            panel_tutorial001.Show();
            panel_tutorial002.Hide();
            panel_tutorial003.Hide();
            panel_tutorial004.Hide();
            panel_tutorial005.Hide();

        }

        private void set_language()
        {
            if (Globals.language == "Italiano")
            {
                Globals.tutorial_text_intro_default = Globals.Configuration_file.Get("tutorial_text_intro_default").Replace("\\n", Environment.NewLine); ;
                Globals.tutorial_text_page1 = Globals.Configuration_file.Get("tutorial_text_page1").Replace("\\n", Environment.NewLine); ;
                Globals.tutorial_text_page2 = Globals.Configuration_file.Get("tutorial_text_page2").Replace("\\n", Environment.NewLine); ;
                Globals.tutorial_text_page3 = Globals.Configuration_file.Get("tutorial_text_page3").Replace("\\n", Environment.NewLine); ;
                Globals.tutorial_text_page4 = Globals.Configuration_file.Get("tutorial_text_page4").Replace("\\n", Environment.NewLine); ;
                Globals.tutorial_text_page5 = Globals.Configuration_file.Get("tutorial_text_page5").Replace("\\n", Environment.NewLine); ;
            }
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            main_form.Enabled = true;
        }

        private void skip_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void next_tutorial_button_Click(object sender, EventArgs e)
        {
            page++;
            show_page(page);
            if (page == MAX_PAGE)
            {
                next_tutorial_button.Enabled = false;
            }
            prev_tutorial_button.Enabled = true;

            page_counter_label.Text = page + "\\" + MAX_PAGE;
        }

        private void prev_tutorial_button_Click(object sender, EventArgs e)
        {
            page--;
            show_page(page);
            if (page == 1)
            {
                prev_tutorial_button.Enabled = false;
            }
            next_tutorial_button.Enabled = true;

            page_counter_label.Text = page + "\\" + MAX_PAGE;
        }

        private void show_page(int page)
        {
            switch (page)
            {
                case 1:
                    panel_tutorial001.Hide();
                    panel_tutorial002.Hide();
                    panel_tutorial003.Hide();
                    panel_tutorial004.Hide();
                    panel_tutorial005.Hide();
                    tutorial_textbox.Text = Globals.tutorial_text_intro_default;
                    panel_tutorial001.Show();
                    panel_tutorial002.Hide();
                    panel_tutorial003.Hide();
                    panel_tutorial004.Hide();
                    panel_tutorial005.Hide();
                    break;
                case 2:
                    panel_tutorial001.Hide();
                    panel_tutorial002.Hide();
                    panel_tutorial003.Hide();
                    panel_tutorial004.Hide();
                    panel_tutorial005.Hide();
                    tutorial_textbox.Text = Globals.tutorial_text_page1;
                    panel_tutorial001.Hide();
                    panel_tutorial002.Show();
                    panel_tutorial003.Hide();
                    panel_tutorial004.Hide();
                    panel_tutorial005.Hide();
                    break;
                case 3:
                    panel_tutorial001.Hide();
                    panel_tutorial002.Hide();
                    panel_tutorial003.Hide();
                    panel_tutorial004.Hide();
                    panel_tutorial005.Hide();
                    tutorial_textbox.Text = Globals.tutorial_text_page2;
                    panel_tutorial001.Hide();
                    panel_tutorial002.Hide();
                    panel_tutorial003.Show();
                    panel_tutorial004.Hide();
                    panel_tutorial005.Hide();
                    break;
                case 4:
                    panel_tutorial001.Hide();
                    panel_tutorial002.Hide();
                    panel_tutorial003.Hide();
                    panel_tutorial004.Hide();
                    panel_tutorial005.Hide();
                    tutorial_textbox.Text = Globals.tutorial_text_page5;
                    panel_tutorial001.Hide();
                    panel_tutorial002.Hide();
                    panel_tutorial003.Hide();
                    panel_tutorial004.Hide();
                    panel_tutorial005.Show();
                    break;
                case 5:
                    panel_tutorial001.Hide();
                    panel_tutorial002.Hide();
                    panel_tutorial003.Hide();
                    panel_tutorial004.Hide();
                    panel_tutorial005.Hide();
                    tutorial_textbox.Text = Globals.tutorial_text_page3;
                    panel_tutorial001.Hide();
                    panel_tutorial002.Hide();
                    panel_tutorial003.Hide();
                    panel_tutorial004.Show();
                    panel_tutorial005.Hide();
                    break;
                case 6:
                    panel_tutorial001.Hide();
                    panel_tutorial002.Hide();
                    panel_tutorial003.Hide();
                    panel_tutorial004.Hide();
                    panel_tutorial005.Hide();
                    tutorial_textbox.Text = Globals.tutorial_text_page4;
                    panel_tutorial001.Hide();
                    panel_tutorial002.Hide();
                    panel_tutorial003.Hide();
                    panel_tutorial004.Hide();
                    panel_tutorial005.Hide();
                    break;
            }
        }
    }
}
