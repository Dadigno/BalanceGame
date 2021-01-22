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

        private void InitializeMenu()
        {
            panel_menu.Show();
            panel_options.Hide();

            language_combobox.Text = "English";
            language_combobox.SelectedIndex = 0;  //Set default value: English

            weight_from.Minimum = 1;
            weight_from.Maximum = 20000;
            weight_to.Maximum = 20000;
            weight_to.Minimum = 1;

            weight_from.Value = 1;
            weight_to.Value = 10000;

            weight_from.ValueChanged += new System.EventHandler(weight_from_ValueChange);
            weight_to.ValueChanged += new System.EventHandler(weight_to_ValueChange);

            color_combobox.SelectedIndexChanged += new System.EventHandler(color_combobox_SelectedIndexChanged);
            color_combobox.SelectedIndex = 0;
            panel_game.BackColor = System.Drawing.Color.FromName("MenuHighlight");
            panel_menu.BackColor = System.Drawing.Color.FromName("MenuHighlight");
            panel_options.BackColor = System.Drawing.Color.FromName("MenuHighlight");

        }

        private void weight_from_ValueChange(object sender, System.EventArgs e)
        {
            if (weight_to.Value < weight_from.Value)
            {
                weight_to.Value = weight_from.Value;
            }
        }

        private void weight_to_ValueChange(object sender, System.EventArgs e)
        {
            if (weight_from.Value > weight_to.Value)
            {
                weight_from.Value = weight_to.Value;
            }
        }


        private void color_combobox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
           // panel_options.BackColor = System.Drawing.Color.FromName((string)color_combobox.SelectedItem);
        }

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

        private void reset_settings_button_Click(object sender, EventArgs e)
        {
            language_combobox.Text = Globals.language_default;
            language_combobox.SelectedIndex = 0;  //Set default value: English

            weight_from.Minimum = 1;
            weight_from.Maximum = 20000;
            weight_to.Maximum = 20000;
            weight_to.Minimum = 1;
            weight_from.Value = 1;
            weight_to.Value = 10000;

            color_combobox.SelectedIndex = 0;
            panel_game.BackColor = Globals.backColor_default;
            panel_menu.BackColor = Globals.backColor_default;
            panel_options.BackColor = Globals.backColor_default;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Globals.weight_from = weight_from.Value;
            Globals.weight_to = weight_to.Value;
            Globals.backColor = System.Drawing.Color.FromName((string)color_combobox.SelectedItem);

            return_menu_button_Click(sender, e);
        }

        private void set_value(bool set_default_settings = false)
        {
            if (set_default_settings)
            {
                panel_game.BackColor = Globals.backColor_default;
                panel_menu.BackColor = Globals.backColor_default;
                panel_options.BackColor = Globals.backColor_default;

                //Set language default TODO
            }
            else
            {
                panel_game.BackColor = Globals.backColor;
                panel_menu.BackColor = Globals.backColor;
                panel_options.BackColor = Globals.backColor;

                //Set language saved in globals TODO
            }
        }

    }
}
