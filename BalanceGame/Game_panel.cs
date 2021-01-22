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
        private void return_menu_click(object sender, EventArgs e)
        {
            panel_game.Hide();
            panel_menu.Show();
        }

        private void weight_1_button_click(object sender, EventArgs e)
        {
            panel_onplate_1.Show();
            panel_onplate_5.Hide();
            panel_onplate_10.Hide();
            panel_onplate_100.Hide();
            panel_onplate_500.Hide();
            panel_onplate_1000.Hide();
        }

        private void weight_5_button_click(object sender, EventArgs e)
        {
            panel_onplate_1.Hide();
            panel_onplate_5.Show();
            panel_onplate_10.Hide();
            panel_onplate_100.Hide();
            panel_onplate_500.Hide();
            panel_onplate_1000.Hide();
        }

        private void weight_10_button_click(object sender, EventArgs e)
        {
            panel_onplate_1.Hide();
            panel_onplate_5.Hide();
            panel_onplate_10.Show();
            panel_onplate_100.Hide();
            panel_onplate_500.Hide();
            panel_onplate_1000.Hide();
        }

        private void weight_100_button_click(object sender, EventArgs e)
        {
            panel_onplate_1.Hide();
            panel_onplate_5.Hide();
            panel_onplate_10.Hide();
            panel_onplate_100.Show();
            panel_onplate_500.Hide();
            panel_onplate_1000.Hide();
        }

        private void weight_500_button_click(object sender, EventArgs e)
        {
            panel_onplate_1.Hide();
            panel_onplate_5.Hide();
            panel_onplate_10.Hide();
            panel_onplate_100.Hide();
            panel_onplate_500.Show();
            panel_onplate_1000.Hide();
        }

        private void weight_1000_button_click(object sender, EventArgs e)
        {
            panel_onplate_1.Hide();
            panel_onplate_5.Hide();
            panel_onplate_10.Hide();
            panel_onplate_100.Hide();
            panel_onplate_500.Hide();
            panel_onplate_1000.Show();
        }

        private void onplate_1_click(object sender, EventArgs e)
        {
            panel_plateweight_1.Show();
        }

        private void onplate_5_click(object sender, EventArgs e)
        {
            panel_plateweight_5.Show();
        }

        private void onplate_10_click(object sender, EventArgs e)
        {
            panel_plateweight_10.Show();
        }

        private void onplate_100_click(object sender, EventArgs e)
        {
            panel_plateweight_100.Show();
        }

        private void onplate_500_click(object sender, EventArgs e)
        {
            panel_plateweight_500.Show();
        }

        private void onplate_1000_click(object sender, EventArgs e)
        {
            panel_plateweight_1000.Show();
        }

        private void clear_click(object sender, EventArgs e)
        {
            panel_plateweight_1.Hide();
            panel_plateweight_5.Hide();
            panel_plateweight_10.Hide();
            panel_plateweight_100.Hide();
            panel_plateweight_500.Hide();
            panel_plateweight_1000.Hide();
        }



    }

}
