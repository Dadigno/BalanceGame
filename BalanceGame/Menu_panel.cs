using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalanceGame
{
    partial class Game : Form
    {
        private void button_start_Click(object sender, EventArgs e)
        {
            panel_menu.Hide();
            panel_game.Show();
            panel_onplate_1.Hide();
            panel_onplate_5.Hide();
            panel_onplate_10.Hide();
            panel_onplate_100.Hide();
            panel_onplate_500.Hide();
            panel_onplate_1000.Hide();
            panel_plateweight_1.Hide();
            panel_plateweight_5.Hide();
            panel_plateweight_10.Hide();
            panel_plateweight_100.Hide();
            panel_plateweight_500.Hide();
            panel_plateweight_1000.Hide();
        }

        private void button_options_Click(object sender, EventArgs e)
        {
            if (!panel_options.Visible)
            {
                panel_menu.Hide();
                panel_options.Show();
            }
            else
            {
                panel_menu.Show();
                panel_options.Hide();
            }
        }

        private void return_menu_button_Click(object sender, EventArgs e)
        {
            panel_menu.Show();
            panel_options.Hide();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
