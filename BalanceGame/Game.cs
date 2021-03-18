using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace BalanceGame
{
    public partial class Game : Form
    {
        Size screen;

        //Controls
        List<Control> menu_controls;
        List<Control> game_controls;

        public Game()
        {
            screen = Screen.PrimaryScreen.Bounds.Size;

            InitializeComponent();

            menu_controls = new List<Control>() { panel_menu, button_exit, button_options, button_start, info_button, title_label, info_label,
                                                  save_options_button, title_options, reset_settings_button, color_combobox, return_menu_button, background_color_label, range_to_label, range_from_label, weight_to_combobox, weight_from_combobox, weight_range_label, language_label, language_combobox
            };

            game_controls = new List<Control>() {
                outplate_1000, onplate_1000, weight_1000, weight_1000_sprite, weight_1000_button, weight_1000_label, panel_onplate_1000, panel_plateweight_1000,
                outplate_500, onplate_500, weight_500, weight_500_sprite, weight_500_button, weight_500_label, panel_onplate_500, panel_plateweight_500,
                outplate_100, onplate_100, weight_100, weight_100_sprite, weight_100_button, weight_100_label, panel_onplate_100, panel_plateweight_100,
                outplate_10, onplate_10, weight_10, weight_10_sprite, weight_10_button, weight_10_label, panel_onplate_10, panel_plateweight_10,
                outplate_5, onplate_5, weight_5, weight_5_sprite, weight_5_button, weight_5_label, panel_onplate_5, panel_plateweight_5,
                outplate_1, onplate_1, weight_1, weight_1_sprite, weight_1_button, weight_1_label, panel_onplate_1, panel_plateweight_1,
                weight_text, balance_indicator, weight_inc, balance_rightplate, balance_leftplate, undo, clear, new_weight, balance_body, return_menu,
                tutorial_button, 
                debug_arrowX, debug_reached, debug_target, debug_label0, debug_label1, debug_label2, debug_label3,
                panel_plate_left, panel_plate_right,
            };
           
            InitializeMenu();

        }

        private static void SetSetting(string key, string value)
        {
            Configuration configuration =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static bool CheckConfigFileIsPresent()
        {
            return File.Exists(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }

        private void Game_Load(object sender, EventArgs e)
        {
            if (CheckConfigFileIsPresent())
            {
                try
                {
                    Globals.Configuration_file = ConfigurationManager.AppSettings;
                    
                    if(Globals.Configuration_file.Get("Default_conf") == "True")
                    {
                        //Load deafult configuration
                        set_configuration(true);
                    }
                    else
                    {
                        //Load from config file a custom configuration
                        set_configuration();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("{0} Exception caught.", ex.Message);
                    Console.WriteLine("Default configuration loaded");
                    set_configuration(true);
                }
            }
            else
            {
                set_configuration(true);
                Console.WriteLine("No config file found, default configuration loaded");
            }

            set_language();
            InitializeGame();
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
                Globals.maximum_moves = Globals.maximum_moves_default;
                set_aspect();

                //Set language default TODO

            }
            else
            {
                if (Globals.Configuration_file.Get("Debug_mode") == "True")
                {
                    debug_arrowX.Visible = true;
                    debug_reached.Visible = true;
                    debug_target.Visible = true;
                    debug_arrowX.Visible = true;
                    debug_label0.Visible = true;
                    debug_label1.Visible = true;
                    debug_label2.Visible = true;
                    debug_label3.Visible = true;
                }

                //Load and set game variables
                Globals.language = Globals.Configuration_file.Get("Lang");
                Globals.weight_from = Convert.ToInt32(Globals.Configuration_file.Get("Weight_from"));
                Globals.weight_to = Convert.ToInt32(Globals.Configuration_file.Get("Weight_to"));
                Globals.weight_from_to_maximum = Convert.ToInt32(Globals.Configuration_file.Get("Weight_from_to_maximum"));
                Globals.weight_from_to_minimum = Convert.ToInt32(Globals.Configuration_file.Get("Weight_from_to_minimum"));
                Globals.backColor = System.Drawing.Color.FromName(Globals.Configuration_file.Get("BackColor"));
                Globals.maximum_moves = Convert.ToInt32(Globals.Configuration_file.Get("maximum_moves"));

                set_aspect();

                //Set language saved in globals TODO
            }
        }

        private void set_language() /* TODO */
        {
            if (Globals.language == "Italiano")
            {//Load italian language
                //Panel menu
                title_label.Text = Globals.Configuration_file.Get("label_title");
                button_exit.Text = Globals.Configuration_file.Get("button_text_exit");
                button_start.Text = Globals.Configuration_file.Get("button_text_start");
                button_options.Text = Globals.Configuration_file.Get("button_text_options");
                

                //Panel options
                title_options.Text = Globals.Configuration_file.Get("label_title_options");
                language_label.Text = Globals.Configuration_file.Get("label_language");
                weight_range_label.Text = Globals.Configuration_file.Get("label_weightrange");
                range_from_label.Text = Globals.Configuration_file.Get("label_rangefrom");
                range_to_label.Text = Globals.Configuration_file.Get("label_rangeto");
                background_color_label.Text = Globals.Configuration_file.Get("label_background_color");
                reset_settings_button.Text = Globals.Configuration_file.Get("button_text_resetsettings");
                return_menu_button.Text = Globals.Configuration_file.Get("button_text_returnmenu");

                //Panel information
                info_label.Text = Globals.Configuration_file.Get("label_information");

                //Panel game
                return_menu.Text = Globals.Configuration_file.Get("button_text_returnmenu");
                new_weight.Text = Globals.Configuration_file.Get("button_text_newweight");
                clear.Text = Globals.Configuration_file.Get("button_text_clear");
                tutorial_button.Text = Globals.Configuration_file.Get("button_text_tutorial");
                weight_text.Text = Globals.Configuration_file.Get("textbox_weight");
                moves_avaliable_label.Text = Globals.Configuration_file.Get("label_moves_avaliable");

                //Messages
                Globals.exiting_without_saving_message = Globals.Configuration_file.Get("exitinh_without_saving_message");
                Globals.exiting_without_saving_caption = Globals.Configuration_file.Get("exiting_without_saving_caption");
                Globals.exit_game_message = Globals.Configuration_file.Get("exit_game_message");
                Globals.exit_game_caption = Globals.Configuration_file.Get("exit_game_caption");
                Globals.saving_message = Globals.Configuration_file.Get("saving_message");
                Globals.saving_caption = Globals.Configuration_file.Get("saving_caption");
                Globals.finish_game_caption = Globals.Configuration_file.Get("finish_game_caption");
                Globals.finish_game_message = Globals.Configuration_file.Get("finish_game_message").Replace("\\n",Environment.NewLine);
            }
            else
            {
                //Panel menu
                title_label.Text = Globals.label_title_default;
                button_exit.Text = Globals.button_text_exit_default;
                button_start.Text = Globals.button_text_start_default;
                button_options.Text = Globals.button_text_options_default;

                //Panel options
                title_options.Text = Globals.label_title_options_default;
                language_label.Text = Globals.label_language_default;
                weight_range_label.Text = Globals.label_weightrange_default;
                range_from_label.Text = Globals.label_rangefrom_default;
                range_to_label.Text = Globals.label_rangeto_default;
                background_color_label.Text = Globals.label_background_color_default;
                reset_settings_button.Text = Globals.button_text_resetsettings_default;
                return_menu_button.Text = Globals.button_text_returnmenu_default;

                //Panel information
                info_label.Text = Globals.label_information_default;

                //Panel game
                return_menu.Text = Globals.button_text_returnmenu_default;
                new_weight.Text = Globals.button_text_newweight_default;
                clear.Text = Globals.button_text_clear_default;
                tutorial_button.Text = Globals.button_text_tutorial_default;
                weight_text.Text = Globals.textbox_weight_default;
                moves_avaliable_label.Text = Globals.label_moves_avaliable;
            }
        }

        private void resize_control(Control ctrl)
        {
            //Dimension
            Size t = ctrl.Size;
            ctrl.Width = (t.Width * screen.Width) / 1920;
            ctrl.Height = (t.Height * screen.Height) / 1080;

            //Location
            Point p = ctrl.Location;
            ctrl.Location = new Point( (p.X * screen.Width) / 1920, ( p.Y * screen.Height) / 1080);

            //Font
            Font font = ctrl.Font;
            float s = font.Size;
            float newSize = (s * screen.Height) / 1080;
            ctrl.Font = new Font(font.FontFamily, newSize, font.Style, font.Unit, font.GdiCharSet);

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

            max_moves_numericUpDown.Value = Globals.maximum_moves;
        }

    }
}
