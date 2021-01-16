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
        private void button_start_click(object sender, EventArgs e)
        {
            panel_menu.Hide();
            panel_game.Show();
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

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
