﻿using System;
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

            weight_from_combobox.ValueChanged += new System.EventHandler(weight_from_ValueChange);
            weight_to_combobox.ValueChanged += new System.EventHandler(weight_to_ValueChange);
            color_combobox.SelectedIndexChanged += new System.EventHandler(color_combobox_SelectedIndexChanged);
        }

        private void weight_from_ValueChange(object sender, System.EventArgs e)
        {
            save_options_button.Enabled = true;
            if (weight_to_combobox.Value < weight_from_combobox.Value)
            {
                weight_to_combobox.Value = weight_from_combobox.Value;
            }
        }

        private void weight_to_ValueChange(object sender, System.EventArgs e)
        {
            save_options_button.Enabled = true;
            if (weight_from_combobox.Value > weight_to_combobox.Value)
            {
                weight_from_combobox.Value = weight_to_combobox.Value;
            }
        }


        private void color_combobox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            save_options_button.Enabled = true;
        }

        private void info_button_Click(object sender, EventArgs e)
        {
            Information_form info_Form = new Information_form(this);
            info_Form.Show();
            this.Enabled = false;
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
            save_options_button.Enabled = false;
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
            if (save_options_button.Enabled)
            {
                var result = MessageBox.Show(Globals.exiting_without_saving_message, Globals.exiting_without_saving_caption,
                                             MessageBoxButtons.OKCancel,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    panel_menu.Show();
                    panel_options.Hide();
                    set_aspect();
                }
            }
            else
            {
                panel_menu.Show();
                panel_options.Hide();

                set_configuration();
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(Globals.exit_game_message, Globals.exit_game_caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void reset_settings_button_Click(object sender, EventArgs e)
        {
            save_options_button.Enabled = true;
            language_combobox.SelectedIndex = 0;
            color_combobox.SelectedIndex = 0;
            weight_from_combobox.Value = Globals.weight_from_default;
            weight_to_combobox.Value = Globals.weight_to_default;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            //Save value to config file
            SetSetting("Lang", (string)language_combobox.SelectedItem);
            SetSetting("BackColor", (string)color_combobox.SelectedItem);
            SetSetting("Weight_from", Convert.ToString(weight_from_combobox.Value));
            SetSetting("Weight_to", Convert.ToString(weight_to_combobox.Value));

            save_options_button.Enabled = false;

            var result = MessageBox.Show(Globals.saving_message, Globals.saving_caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void set_configuration(bool set_default_settings = false)
        {
            if (set_default_settings)
            {
                //Set default configuration momentarily ( Not saved into config file )

                //Set Game variables
                Globals.language = Globals.language_default;
                Globals.weight_from = Globals.weight_from_default;
                Globals.weight_to = Globals.weight_to_default;
                Globals.weight_from_to_maximum = Globals.weight_from_to_maximum_default;
                Globals.weight_from_to_minimum = Globals.weight_from_to_minimum_default;
                Globals.backColor = Globals.backColor_default;

                set_aspect();
                
                //Set language default TODO

            }
            else
            {
                //Load configuration from config file

                //Load and set game variables
                Globals.language = Globals.language_default;
                Globals.weight_from = Convert.ToInt32(Configuration_file.Get("Weight_from"));
                Globals.weight_to = Convert.ToInt32(Configuration_file.Get("Weight_to"));
                Globals.weight_from_to_maximum = Convert.ToInt32(Configuration_file.Get("Weight_from_to_maximum"));
                Globals.weight_from_to_minimum = Convert.ToInt32(Configuration_file.Get("Weight_from_to_minimum"));
                Globals.backColor = System.Drawing.Color.FromName(Configuration_file.Get("BackColor"));

                set_aspect();

                //Set language saved in globals TODO
            }
        }

        public void set_aspect()
        {
            panel_game.BackColor = Globals.backColor;
            panel_menu.BackColor = Globals.backColor;
            panel_options.BackColor = Globals.backColor;

            language_combobox.SelectedItem = Globals.language;
            color_combobox.SelectedItem = Globals.backColor.Name;
            weight_from_combobox.Minimum = Globals.weight_from_to_minimum;
            weight_from_combobox.Maximum = Globals.weight_from_to_maximum;
            weight_to_combobox.Maximum = Globals.weight_from_to_maximum;
            weight_to_combobox.Minimum = Globals.weight_from_to_minimum;
            weight_from_combobox.Value = Globals.weight_from;
            weight_to_combobox.Value = Globals.weight_to;
        }
    }
}
