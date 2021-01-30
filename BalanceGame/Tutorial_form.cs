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
        int MAX_PAGE = 3;

        public Tutorial_form(Game main_form)
        {
            this.main_form = main_form;
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            prev_tutorial_button.Enabled = false;
            next_tutorial_button.Enabled = true;
            page = 1;
            tutorial_textbox.Text = Globals.tutorial_text_intro;
            page_counter_label.Text = page + "\\" + MAX_PAGE;
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
                    tutorial_textbox.Text = Globals.tutorial_text_intro;
                    break;
                case 2:
                    tutorial_textbox.Text = Globals.tutorial_text_page1;
                    break;
                case 3:
                    tutorial_textbox.Text = Globals.tutorial_text_page2;
                    break;
            }
        }
    }
}
